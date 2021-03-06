
Public MustInherit Class FrmValidasiDSR
    Protected dt As New DataTable
    Protected DPP As Double
    Protected Status_Edit As Boolean

    Enum JenisEnum
        Perwakilan = 1
        Pusat = 2
    End Enum
    Private _Jenis As JenisEnum
    Public Property Jenis As JenisEnum
        Set(value As JenisEnum)
            _Jenis = value
            If value = JenisEnum.Pusat Then
                LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                LayoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
            If value = JenisEnum.Perwakilan Then
                LayoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
        End Set
        Get
            Return _Jenis
        End Get
    End Property

    Private Sub FrmDeliveryOrder_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Apakah anda yakin ingin keluar dari menu ini ?", "Pertanyaan !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dt.Dispose()
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    'Protected Sub Cetak() Handles _Toolbar1_Button6.ItemClick
    '    ShowDevexpressReport(ReportPreview.KeyReport.Penerimaan_Transfer_Barang_Retur, TxtIDTransaksi.Text)
    '    Log.Cetak(Me, TxtIDTransaksi.Text)
    'End Sub

    Private Sub FrmDeliveryOrder_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Dim KeyCode As Integer = e.KeyCode
        Dim Shift As Integer = e.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F2
                _Toolbar1_Button1.PerformClick()
            Case System.Windows.Forms.Keys.F3
                _Toolbar1_Button2.PerformClick()
            Case System.Windows.Forms.Keys.F5
                _Toolbar1_Button3.PerformClick()
            Case System.Windows.Forms.Keys.F6
                _Toolbar1_Button4.PerformClick()
            Case System.Windows.Forms.Keys.F7
                _Toolbar1_Button5.PerformClick()
            Case System.Windows.Forms.Keys.F8
                _Toolbar1_Button6.PerformClick()
        End Select
    End Sub

    Private Sub FrmDeliveryOrder_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        TglTransaksi.DateTime = Format(Now.Date, "dd/MM/yyyy")
        GridView1.OptionsView.ColumnAutoWidth = False
        InitGrid.Clear()
        InitGrid.AddColumnGrid("No.", TypeCode.Int32, 30, False)
        InitGrid.AddColumnGrid("Nota", TypeCode.String, 50, False)
        InitGrid.AddColumnGrid("DO", TypeCode.String, 60, False)
        InitGrid.AddColumnGrid("Id Customer", TypeCode.String, 80, False,,,,, False)
        InitGrid.AddColumnGrid("Nama", TypeCode.String, 300, False)
        InitGrid.AddColumnGrid("Bruto", TypeCode.Single, 50, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Std. Disc", TypeCode.Single, 50, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Add. Disc", TypeCode.Single, 60, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Cash Disc", TypeCode.Single, 30, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Netto", TypeCode.Single, 50, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.EndInit(TBDO, GridView1, dt)

        With GridView1.Columns.Item("Bruto").SummaryItem
            .DisplayFormat = "{0:n2}"
            .FieldName = "Bruto"
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With
        With GridView1.Columns.Item("Std. Disc").SummaryItem
            .DisplayFormat = "{0:n2}"
            .FieldName = "Std. Disc"
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With
        With GridView1.Columns.Item("Add. Disc").SummaryItem
            .DisplayFormat = "{0:n2}"
            .FieldName = "Add. Disc"
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With
        With GridView1.Columns.Item("Cash Disc").SummaryItem
            .DisplayFormat = "{0:n2}"
            .FieldName = "Cash Disc"
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With
        With GridView1.Columns.Item("Netto").SummaryItem
            .DisplayFormat = "{0:n2}"
            .FieldName = "Netto"
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
        End With
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        SetDataTable(GridView1, e)
        GridView1.RefreshData()
    End Sub

    'DIVISI
    Private Sub TxtDivisi_EditValueChanged(sender As Object, e As System.EventArgs) Handles TxtDivisi.EditValueChanged
        On Error Resume Next
        SetData("SELECT NAMA FROM DIVISI WHERE KODE='" & TxtDivisi.Text & "'", {TxtNamaDivisi})
    End Sub

    'GUDANG
    Private Sub TxtKodeGudang_EditValueChanged(sender As Object, e As System.EventArgs) Handles TxtKodeGudang.EditValueChanged
        On Error Resume Next
        SetData("SELECT NAMA_GUDANG FROM GUDANG WHERE KODE='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.ItemClick
        Me.Close()
    End Sub

    Private Sub ButtonEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TxtNoDSR.EditValueChanged

    End Sub
End Class


Public MustInherit Class InputValidasiDSR
    Inherits FrmValidasiDSR
    Private Sub Batal() Handles _Toolbar1_Button2.ItemClick
        Clean(Me)
        dt.Clear()
        AddRow(dt)
    End Sub

    Private Sub TxtNoDSR_Click(sender As Object, e As System.EventArgs) Handles TxtNoDSR.Click
        TxtIdDSR.Text = SearchTransaction(FrmPencarianTransaksi.KeyPencarian.Transaksi_Create_DSR,, Jenis.ToString)
    End Sub
    Private Sub TxtIdDSR_EditValueChanged(sender As Object, e As System.EventArgs) Handles TxtIdDSR.EditValueChanged
        On Error Resume Next
        SetData("SELECT NO_DSR, TGL_PENGAKUAN, DIVISI, GUDANG FROM AR_DSR WHERE ID_TRANSAKSI='" & TxtIdDSR.Text & "'", {TxtNoDSR, TglPengakuan, TxtDivisi, TxtKodeGudang})
        LoadData.GetData("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, A.ID_CUSTOMER, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & TxtIdDSR.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, False)
    End Sub
    Private Sub TxtNoDSR_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoDSR.KeyPress
        If CharKeypress(TxtNoDSR, e) Then TxtIdDSR.Text = Search(FrmPencarianTransaksi.KeyPencarian.Transaksi_Create_DSR,, Jenis.ToString)
    End Sub

    Private Function Generate() As Boolean
        Dim urut As Short
        Using dtGenerate = SelectCon.execute("SELECT NO_VALIDASI FROM AR_VALIDASI_DSR WHERE NO_DSR Like 'VDSR-" & TxtNamaDivisi.Text & "-" & TxtKodeGudang.Text & "-%' AND YEAR(TGL)=" & Format(TglTransaksi.EditValue, "yyyy") & " ORDER BY NO_DSR DESC")
            If dtGenerate.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Microsoft.VisualBasic.Right(dtGenerate.Rows(0).Item(0), 6) + 1
            End If
            TxtNoTransaksi.Text = "VDSR- " & TxtNamaDivisi.Text & "-" & TxtKodeGudang.Text & "-" & Format(urut, "00000")
        End Using

        Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_TRANSAKSI,'DSR','') AS INT)),0) AS ID FROM AR_VALIDASI_DSR")
            TxtIDTransaksi.Text = "VDSR" & CInt(dtGenerate.Rows(0).Item(0)) + 1
        End Using
        Return True
    End Function

    Private Sub Simpan() Handles _Toolbar1_Button1.ItemClick
        If Empty({TglTransaksi, TxtNoDSR, TglPengakuan, TxtDivisi, TxtKodeGudang}) Then Exit Sub
        GridView1.CloseEditor()

        If dt.Rows.Count = 0 Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If Format(TglPengakuan.EditValue, "MMyy") <> periode Then
            MsgBox("Tgl transaksi yang anda lakukan tidak sesuai dengan periode yang masuki", vbInformation, "Informasi")
            Exit Sub
        End If

        If QuestionInput() = False Then Exit Sub
        If Not Generate() Then Exit Sub
        MessageBox.Show("Anda menggunakan nomor transaksi " & TxtNoTransaksi.Text & " !!!", "Pemberitahuan Nomor Transaksi !", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.InsertHeader({TxtIDTransaksi, TxtNoTransaksi, TglTransaksi, TxtIdDSR, TxtNoDSR, periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0}, "AR_VALIDASI_DSR") = False Then Exit Sub

            Dim Setup As New SetupAkun
            For Each dr As DataRow In dt.Rows
                Dim ProsJurnal As New ProsesJurnal(ProsesJurnal.JenisJurnal.Jurnal_Memo, TglPengakuan.DateTime, "", dr.Item("Nota"), SQLServer, ProsesJurnal.StatusJurnal.Baru)
                'CEK TRANSAKSI
                Dim APiutang = Akun.PIUTANG_PERWAKILAN
                Dim ACash = Akun.CASH_PERWAKILAN
                Dim ACadangan = Akun.CASH_PERWAKILAN
                Dim AUCF = Akun.UCF_PERWAKILAN
                Dim APersediaan = Akun.PERSEDIAAN_PERWAKILAN
                If Jenis = JenisEnum.Pusat Then
                    Using dtCek As DataTable = SelectCon.execute("SELECT DO.PEMBAYARAN, A.BAGIAN FROM NOTA A WITH(NOLOCK) JOIN DELIVERY_ORDER DO WITH(NOLOCK) ON A.ID_DO=DO.ID_TRANSAKSI WHERE A.NO_NOTA='" & dr.Item("Nota") & "' AND A.NO_DO='" & dr.Item("DO") & "'")
                        If dtCek.Rows(0).Item(0) = "Kontan" Then
                            APiutang = Akun.PIUTANG_PUSKON
                            ACash = Akun.CASH_PUSKON
                            ACadangan = Akun.CASH_PUSKON
                            AUCF = Akun.UCF_PUSKON
                            APersediaan = Akun.PERSEDIAAN_PUSKON
                        End If
                        If dtCek.Rows(0).Item(0) = "Kredit" Then
                            APiutang = Akun.PIUTANG_PUSKRE
                            ACash = Akun.CASH_PUSKRE
                            ACadangan = Akun.CASH_PUSKRE
                            AUCF = Akun.UCF_PUSKRE
                            APersediaan = Akun.PERSEDIAAN_PUSKRE
                        End If
                    End Using
                End If

                ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(APiutang), "Piutang Nota " & dr.Item("Nota"), dr.Item("Netto")))
                If dr.Item("Cash Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(ACash), "Cash Diskon Nota " & dr.Item("Nota"), dr.Item("Cash Disc")))
                End If
                If dr.Item("Std. Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(ACadangan), "Standard Diskon Nota " & dr.Item("Nota"), dr.Item("Std. Disc")))
                End If
                If dr.Item("Add. Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(AUCF), "UCF Nota " & dr.Item("Nota"), dr.Item("Add. Disc")))
                End If
                Dim Persediaan As Double = dr.Item("Netto") + dr.Item("Cash Disc") + dr.Item("Std. Disc") + dr.Item("Add. Disc")
                ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Kredit, Setup.GetAkun(APersediaan), "Persediaan Untuk Nota " & dr.Item("Nota"), Persediaan))
                ProsJurnal.Submit()
            Next
            SQLServer.EndTransaction()
            Batal()
        End Using
    End Sub
End Class

Public MustInherit Class EditValidasiDSR
    Inherits FrmValidasiDSR

    Private Sub GetData() Handles _Toolbar1_Button2.ItemClick, TxtIDTransaksi.EditValueChanged
        LoadData.GetData("SELECT NO_VALIDASI, TGL, ID_DSR, NO_DSR FROM AR_VALIDASI_DSR WHERE ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'")
        LoadData.SetData({TxtNoTransaksi, TglTransaksi, TxtIdDSR, TxtNoDSR})
        SetData("SELECT NO_DSR, TGL_PENGAKUAN, DIVISI, GUDANG FROM AR_DSR WHERE ID_TRANSAKSI='" & TxtIdDSR.Text & "'", {TxtNoDSR, TglPengakuan, TxtDivisi, TxtKodeGudang})

        LoadData.GetData("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, A.ID_CUSTOMER, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & TxtIdDSR.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, False)
    End Sub

    Private Sub SimpanEdit() Handles _Toolbar1_Button1.ItemClick
        If Empty({TglTransaksi, TxtNoTransaksi, TxtDivisi, TxtKodeGudang}) Then Exit Sub

        If dt.Rows.Count = 0 Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If QuestionEdit() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header()
            If SQLServer.UpdateHeader("NO_VALIDASI, TGL, ID_DSR, NO_DSR ,[MDUSER] ,[MDTIME]", {TxtNoTransaksi, TglTransaksi, TxtIdDSR, TxtNoDSR, ToSyntax(UserID), ToSyntax("CURRENT_TIMESTAMP")}, "AR_VALIDASI_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub

            Dim Setup As New SetupAkun
            For Each dr As DataRow In dt.Rows
                Dim ProsJurnal As New ProsesJurnal(ProsesJurnal.JenisJurnal.Jurnal_Memo, TglPengakuan.DateTime, "", dr.Item("Nota"), SQLServer, ProsesJurnal.StatusJurnal.Edit)
                'CEK TRANSAKSI
                Dim APiutang = Akun.PIUTANG_PERWAKILAN
                Dim ACash = Akun.CASH_PERWAKILAN
                Dim ACadangan = Akun.CASH_PERWAKILAN
                Dim AUCF = Akun.UCF_PERWAKILAN
                Dim APersediaan = Akun.PERSEDIAAN_PERWAKILAN
                If Jenis = JenisEnum.Pusat Then
                    Using dtCek As DataTable = SelectCon.execute("SELECT DO.PEMBAYARAN, A.BAGIAN FROM NOTA A WITH(NOLOCK) JOIN DELIVERY_ORDER DO WITH(NOLOCK) ON A.ID_DO=DO.ID_TRANSAKSI WHERE A.NO_NOTA='" & dr.Item("Nota") & "' AND A.NO_DO='" & dr.Item("DO") & "'")
                        If dtCek.Rows(0).Item(0) = "Kontan" Then
                            APiutang = Akun.PIUTANG_PUSKON
                            ACash = Akun.CASH_PUSKON
                            ACadangan = Akun.CASH_PUSKON
                            AUCF = Akun.UCF_PUSKON
                            APersediaan = Akun.PERSEDIAAN_PUSKON
                        End If
                        If dtCek.Rows(0).Item(0) = "Kredit" Then
                            APiutang = Akun.PIUTANG_PUSKRE
                            ACash = Akun.CASH_PUSKRE
                            ACadangan = Akun.CASH_PUSKRE
                            AUCF = Akun.UCF_PUSKRE
                            APersediaan = Akun.PERSEDIAAN_PUSKRE
                        End If
                    End Using
                End If

                ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(APiutang), "Piutang Nota " & dr.Item("Nota"), dr.Item("Netto")))
                If dr.Item("Cash Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(ACash), "Cash Diskon Nota " & dr.Item("Nota"), dr.Item("Cash Disc")))
                End If
                If dr.Item("Std. Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(ACadangan), "Standard Diskon Nota " & dr.Item("Nota"), dr.Item("Std. Disc")))
                End If
                If dr.Item("Add. Disc") > 0 Then
                    ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Debet, Setup.GetAkun(AUCF), "UCF Nota " & dr.Item("Nota"), dr.Item("Add. Disc")))
                End If
                Dim Persediaan As Double = dr.Item("Netto") + dr.Item("Cash Disc") + dr.Item("Std. Disc") + dr.Item("Add. Disc")
                ProsJurnal.AddJurnal(New DetailJurnal(PosisiJurnal.Kredit, Setup.GetAkun(APersediaan), "Persediaan Untuk Nota " & dr.Item("Nota"), Persediaan))
                ProsJurnal.Submit()
            Next

            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub

    Private Sub Hapus() Handles _Toolbar1_Button5.ItemClick
        If QuestionHapus() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("AR_VALIDASI_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            For Each dr As DataRow In dt.Rows
                Dim ProsJurnal As New ProsesJurnal(ProsesJurnal.JenisJurnal.Jurnal_Memo, TglPengakuan.DateTime, "", dr.Item("Nota"), SQLServer, ProsesJurnal.StatusJurnal.Hapus)
                ProsJurnal.Submit()
            Next
            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub

    Private Sub Batal() Handles _Toolbar1_Button4.ItemClick
        If QuestionBatal() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "AR_VALIDASI_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            For Each dr As DataRow In dt.Rows
                Dim ProsJurnal As New ProsesJurnal(ProsesJurnal.JenisJurnal.Jurnal_Memo, TglPengakuan.DateTime, "", dr.Item("Nota"), SQLServer, ProsesJurnal.StatusJurnal.Batal)
                ProsJurnal.Submit()
            Next
            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub
End Class

Public Class InputValidasiDSRPrw
    Inherits InputValidasiDSR

    Private Sub InputValidasiDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text = "Input Validasi DSR Perwakilan"
        Jenis = JenisEnum.Perwakilan
        _Toolbar1_Button4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Status_Edit = False
    End Sub
End Class

Public Class EditValidasiDSRPrw
    Inherits EditValidasiDSR

    Private Sub EditValidasiDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text = "Edit Validasi DSR Perwakilan"
        Jenis = JenisEnum.Perwakilan
        Status_Edit = True
        'HakForm("", "Retur", "Daily Sales Report", _Toolbar1_Button4, _Toolbar1_Button5, _Toolbar1_Button6)
        'TxtNoTransaksi.Properties.ReadOnly = True
        'TxtDivisi.Enabled = False
    End Sub
End Class


Public Class InputValidasiDSRPus
    Inherits InputValidasiDSR

    Private Sub InputValidasiDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text = "Input Validasi DSR Pusat"
        Jenis = JenisEnum.Pusat
        _Toolbar1_Button4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Status_Edit = False
    End Sub
End Class

Public Class EditValidasiDSRPus
    Inherits EditValidasiDSR

    Private Sub EditValidasiDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text = "Edit Validasi DSR Pusat"
        Jenis = JenisEnum.Pusat
        Status_Edit = True
        'HakForm("", "Retur", "Daily Sales Report", _Toolbar1_Button4, _Toolbar1_Button5, _Toolbar1_Button6)
        'TxtNoTransaksi.Properties.ReadOnly = True
        'TxtDivisi.Enabled = False
    End Sub
End Class