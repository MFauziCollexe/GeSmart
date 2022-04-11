Module ModuleAR
    Enum Akun
        PIUTANG_PERWAKILAN = 1
        CASH_PERWAKILAN = 2
        CADANGAN_PERWAKILAN = 3
        UCF_PERWAKILAN = 4
        PERSEDIAAN_PERWAKILAN = 5
        PIUTANG_PUSKON = 6
        CASH_PUSKON = 7
        CADANGAN_PUSKON = 8
        UCF_PUSKON = 9
        PERSEDIAAN_PUSKON = 10
        PIUTANG_PUSKRE = 11
        CASH_PUSKRE = 12
        CADANGAN_PUSKRE = 13
        UCF_PUSKRE = 14
        PERSEDIAAN_PUSKRE = 15
    End Enum

    Enum PosisiJurnal
        Debet = 1
        Kredit = 2
    End Enum

    ''' <summary>
    ''' Class Untuk Get Setup Akun
    ''' </summary>
    Public Class SetupAkun
        Private dt As New DataTable
        Sub New()
            dt = SelectCon.execute("SELECT * FROM AR_SETUP_AKUNTANSI")
        End Sub

        Public Function GetAkun(ByVal Nama As Akun) As String
            Dim Akun As String = ""
            If dt.Rows.Count > 0 Then
                Dim myDt As DataTable = dt.Select("NAMA='" & Nama.ToString & "'").CopyToDataTable
                If myDt.Rows.Count > 0 Then
                    Akun = myDt.Rows(0).Item(1)
                End If
            End If
            Return Akun
        End Function
    End Class

    Public Class DetailJurnal
        Property Posisi As PosisiJurnal
        Property Kode As String
        Property Keterangan As String
        Property Nilai As Double

        Sub New(_Posisi As PosisiJurnal, _Kode As String, _Keterangan As String, _Nilai As Double)
            Posisi = _Posisi
            Kode = _Kode
            Keterangan = _Keterangan
            Nilai = _Nilai
        End Sub
    End Class

    ''' <summary>
    ''' Class Untuk Insert Jurnal
    ''' </summary>
    Public Class ProsesJurnal
        Private IdTransaksi As String
        Private NoTransaksi As String
        Private LinkKasBank As String
        Private LinkTranskasi As String
        Private Jenis As JenisJurnal
        Private Tanggal As Date
        Private SQLServer As SQLServerTransaction
        Private Status As StatusJurnal

        Enum JenisJurnal
            Jurnal_Kas = 1
            Jurnal_Memo = 2
            Jurnal_Penyesuaian = 3
        End Enum

        Enum StatusJurnal
            Baru = 1
            Edit = 2
            Batal = 3
            Hapus = 4
        End Enum

        Sub New(_Jenis As JenisJurnal, _Tgl As Date, _LinkKasBank As String,
                _LinkTransaksi As String, ByRef _SQLServer As SQLServerTransaction, ByVal _Status As StatusJurnal)
            Jenis = _Jenis
            Tanggal = _Tgl
            LinkKasBank = _LinkKasBank
            LinkTranskasi = _LinkTransaksi
            SQLServer = _SQLServer
            Status = _Status
        End Sub

        Private IsiJurnal As New List(Of DetailJurnal)
        Public Sub AddJurnal(Detail As DetailJurnal)
            IsiJurnal.Add(Detail)
        End Sub

        Private Sub Generate()
            Dim urut As Short
            Dim fmt As String = ""
            If Jenis = JenisJurnal.Jurnal_Kas Then
                fmt = "JS"
            ElseIf Jenis = JenisJurnal.Jurnal_Memo Then
                fmt = "JM"
            ElseIf Jenis = JenisJurnal.Jurnal_Penyesuaian Then
                fmt = "JP"
            End If
            fmt = fmt & "/" & Format(Tanggal, "MMyy") & "/"

            Using dtGenerate = SelectCon.execute("SELECT NO_JURNAL FROM AR_JURNAL WITH(NOLOCK) WHERE NO_JURNAL Like '" & fmt & "%' ORDER BY NO_JURNAL DESC")
                If dtGenerate.Rows.Count = 0 Then
                    urut = 1
                Else
                    urut = Right(dtGenerate.Rows(0).Item(0), 6) + 1
                End If
                NoTransaksi = fmt & Format(urut, "000000")
            End Using

            Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_JURNAL,'JR','') AS BIGINT)),0) AS ID FROM AR_JURNAL WITH(NOLOCK)")
                IdTransaksi = "JR" & CInt(dtGenerate.Rows(0).Item(0)) + 1
            End Using
        End Sub

        Private Function Baru() As Boolean
            Generate()
            'Header
            If SQLServer.InsertHeader({IdTransaksi, NoTransaksi, Format(Tanggal, "yyyy-MM-dd"), Format(Tanggal, "yyyy-MM-dd"), Jenis.ToString.Replace("_", " "), "", LinkTranskasi, LinkKasBank, "", "", periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0}, "AR_JURNAL") = False Then Return False
            'Detail
            Dim i As Integer = 1
            For Each Detail As DetailJurnal In IsiJurnal
                If SQLServer.InsertHeader({IdTransaksi, NoTransaksi, Detail.Kode, Detail.Keterangan, IIf(Detail.Posisi = PosisiJurnal.Debet, Detail.Nilai, 0), IIf(Detail.Posisi = PosisiJurnal.Kredit, Detail.Nilai, 0), i}, "AR_JURNAL_DETAIL") = False Then Return False
                i = i + 1
            Next
            Return True
        End Function

        Public Function Submit() As Boolean
            If Status = StatusJurnal.Baru Then
                Baru()
            End If

            If Status = StatusJurnal.Edit Then
                Using dt As DataTable = SelectCon.execute("SELECT * FROM AR_JURNAL WITH(NOLOCK) WHERE LINK_TRANSAKSI='" & LinkTranskasi & "'")
                    If dt.Rows.Count > 0 Then
                        Dim DataJurnal As DataRow = dt.Rows(0)
                        IdTransaksi = DataJurnal.Item("ID_JURNAL")
                        NoTransaksi = DataJurnal.Item("NO_JURNAL")
                        'Header
                        If SQLServer.UpdateHeader("TGL, TGL_PENGAKUAN ,MDUSER ,MDTIME", {Format(Tanggal, "yyyy-MM-dd"), Format(Tanggal, "yyyy-MM-dd"), UserID, ToSyntax("CURRENT_TIMESTAMP")}, "AR_JURNAL", "ID_JURNAL='" & IdTransaksi & "'") = False Then Return False
                        'Detail
                        If SQLServer.Delete("AR_JURNAL_DETAIL", "ID_JURNAL='" & IdTransaksi & "'") = False Then Return False
                        Dim i As Integer = 1
                        For Each Detail As DetailJurnal In IsiJurnal
                            If SQLServer.InsertHeader({IdTransaksi, NoTransaksi, Detail.Kode, Detail.Keterangan, IIf(Detail.Posisi = PosisiJurnal.Debet, Detail.Nilai, 0), IIf(Detail.Posisi = PosisiJurnal.Kredit, Detail.Nilai, 0), i}, "AR_JURNAL_DETAIL") = False Then Return False
                            i = i + 1
                        Next
                    Else
                        'Baru()
                        Return False
                    End If
                End Using
            End If

            If Status = StatusJurnal.Batal Then
                Using dt As DataTable = SelectCon.execute("SELECT * FROM AR_JURNAL WITH(NOLOCK) WHERE LINK_TRANSAKSI='" & LinkTranskasi & "'")
                    If dt.Rows.Count > 0 Then
                        Dim DataJurnal As DataRow = dt.Rows(0)
                        IdTransaksi = DataJurnal.Item("ID_JURNAL")
                        If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "AR_JURNAL", "ID_JURNAL='" & IdTransaksi & "'") = False Then Return False
                    End If
                End Using
            End If

            If Status = StatusJurnal.Hapus Then
                Using dt As DataTable = SelectCon.execute("SELECT * FROM AR_JURNAL WITH(NOLOCK) WHERE LINK_TRANSAKSI='" & LinkTranskasi & "'")
                    If dt.Rows.Count > 0 Then
                        Dim DataJurnal As DataRow = dt.Rows(0)
                        IdTransaksi = DataJurnal.Item("ID_JURNAL")
                        If SQLServer.Delete("AR_JURNAL_DETAIL", "ID_JURNAL='" & IdTransaksi & "'") = False Then Return False
                        If SQLServer.Delete("AR_JURNAL", "ID_JURNAL='" & IdTransaksi & "'") = False Then Return False
                    End If
                End Using
            End If

            Return True
        End Function

    End Class

End Module
