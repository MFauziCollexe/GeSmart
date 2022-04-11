
Public MustInherit Class FrmCheckOffice
    Protected dt As New DataTable
    Protected Status_Edit As Boolean
    Protected Bagian As EBagian

#Region "Shared Sub"
    Protected Sub Cetak() Handles _Toolbar1_Button6.ItemClick
        If _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Check_Office, TxtIDTransaksi.Text)
        Log.Cetak(Me, TxtIDTransaksi.Text)
    End Sub

    Protected Sub Batal()
        Clean(Me)
        dt.Clear()
    End Sub

    Protected Sub Generate()
        Dim urut As Short
        Using dtGenerate = SelectCon.execute("SELECT NO_CHECK FROM CHECK_OFFICE WHERE NO_CHECK Like 'CO" & "(" & InisialPerusahaan & ")" & "%' AND YEAR(TGL_PENGAKUAN)=" & Format(TglPengakuan.EditValue, "yyyy") & " ORDER BY NO_CHECK DESC")
            If dtGenerate.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Microsoft.VisualBasic.Right(dtGenerate.Rows(0).Item(0), 6) + 1
            End If
            TxtNoTransaksi.Text = "CO" & "(" & InisialPerusahaan & ")" & Format(urut, "000000")
        End Using
        Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_TRANSAKSI,'CO','') AS BIGINT)),0) AS ID FROM CHECK_OFFICE")
            TxtIDTransaksi.Text = "CO" & CInt(dtGenerate.Rows(0).Item(0)) + 1
        End Using
    End Sub

    Protected Sub Simpan()
        Dim i As Integer
        If Empty({TxtKodeDriver, TxtKodeKendaraan, TglTransaksi, TglPengakuan}) Then Exit Sub

        If dt.Select("[Check]='-'").Length > 0 Then
            MsgBox("Masih ada Nota yang belum di check, silahkan periksa kembali!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If Format(TglPengakuan.EditValue, "MMyy") <> periode Then
            MsgBox("Tgl transaksi yang anda lakukan tidak sesuai dengan periode yang masuki", vbInformation, "Informasi")
            Exit Sub
        End If

        If QuestionInput() = False Then Exit Sub
        Generate()
        MessageBox.Show("Anda menggunakan nomor transaksi " & TxtNoTransaksi.Text & " !!!", "Pemberitahuan Nomor Transaksi !", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.InsertHeader({TxtIDTransaksi, TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtKodeDriver, TxtKodeKendaraan, periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0, EnumDescription(Bagian)}, "CHECK_OFFICE") = False Then Exit Sub
            'Detail
            If SQLServer.InsertDetail(dt, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), "ID Pengiriman", "No Pengiriman", "ID Nota", "No Nota", "No."}, "DETAIL_CHECK_OFFICE") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Insert(Me, TxtIDTransaksi.Text)
            Batal()
        End Using
        PictureEditTrue.Image = Nothing
    End Sub

#Region "Edit"
    Protected Sub GetData()
        LoadData.GetData("SELECT [NO_CHECK] ,[TGL] ,[TGL_PENGAKUAN] ,[KENDARAAN] ,[DRIVER] FROM CHECK_OFFICE WHERE ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'")
        LoadData.SetData({TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtKodeKendaraan, TxtKodeDriver})

        LoadData.GetData("SELECT A.URUTAN, A.ID_PENGIRIMAN, A.NO_PENGIRIMAN, P.TGL_PENGAKUAN, A.ID_NOTA, A.NO_NOTA, B.TGL_PENGAKUAN, B.KODE_CUSTOMER, B.KODE_APPROVE, C.NAMA, B.DPP+B.PPN TOTAL, 'OK' CEK FROM DETAIL_CHECK_OFFICE A LEFT JOIN PENGIRIMAN P ON A.ID_PENGIRIMAN=P.ID_TRANSAKSI LEFT JOIN NOTA B ON A.ID_NOTA=B.ID_TRANSAKSI LEFT JOIN CUSTOMER C ON B.KODE_CUSTOMER=C.ID WHERE A.ID_TRANSAKSI='" & TxtIDTransaksi.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, False)
        Log.Load(Me, TxtIDTransaksi.Text)
        _Toolbar1_Button1.Enabled = False
        _Toolbar1_Button1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        PictureEditTrue.Image = My.Resources.netclipart_com_green_check_clipart_915169
    End Sub

    Protected Sub Hapus()
        If QuestionHapus() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("CHECK_OFFICE", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.Delete("DETAIL_CHECK_OFFICE", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Hapus(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub

    Protected Sub BatalTransaksi()
        If QuestionBatal() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "CHECK_OFFICE", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Batal(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub
#End Region
#End Region

    Private Sub FrmDeliveryOrder_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Apakah anda yakin ingin keluar dari menu ini ?", "Pertanyaan !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dt.Dispose()
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmDeliveryOrder_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
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

    Private Sub FrmDeliveryOrder_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PictureEditTrue.Image = Nothing
        TglTransaksi.DateTime = Format(Now.Date, "dd/MM/yyyy")
        TglPengakuan.DateTime = Format(Now.Date, "dd/MM/yyyy")
        InitGrid.Clear()
        InitGrid.AddColumnGrid("No.", TypeCode.Int32, 15, False)
        InitGrid.AddColumnGrid("ID Pengiriman", TypeCode.String, 35, False,,,,, False)
        InitGrid.AddColumnGrid("No Pengiriman", TypeCode.String, 40, False)
        InitGrid.AddColumnGrid("Tgl Pengiriman", TypeCode.DateTime, 40, False, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", False)
        InitGrid.AddColumnGrid("ID Nota", TypeCode.String, 35, False,,,,, False)
        InitGrid.AddColumnGrid("No Nota", TypeCode.String, 40, False)
        InitGrid.AddColumnGrid("Tgl Nota", TypeCode.DateTime, 40, False, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", False)
        InitGrid.AddColumnGrid("ID Customer", TypeCode.String, 35, False,,,,, False)
        InitGrid.AddColumnGrid("Kode Customer", TypeCode.String, 30, False)
        InitGrid.AddColumnGrid("Nama Customer", TypeCode.String, 100, False)
        InitGrid.AddColumnGrid("Total Nota", TypeCode.Decimal, 75, False, DevExpress.Utils.FormatType.Numeric, "c2")
        InitGrid.AddColumnGrid("Check", TypeCode.String, 30, False)
        InitGrid.EndInit(TBDO, GridView1, dt)
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        SetDataTable(GridView1, e)
        GridView1.RefreshData()
    End Sub

    Private Sub GridView1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        'If e.KeyCode = 46 Then
        '    GridView1.DeleteRow(GridView1.FocusedRowHandle)
        '    GridView1.FocusedColumn = GridView1.Columns("No Nota")
        '    If GridView1.RowCount = 0 Then
        '        AddRow(dt)
        '        GridView1.FocusedColumn = GridView1.Columns("No Nota")
        '    End If
        '    Urutan()
        'End If
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.ItemClick
        Me.Close()
    End Sub

#Region "Declare"
    Protected Sub Urutan()
        For i = 0 To GridView1.RowCount - 1
            GridView1.GetDataRow(i)(0) = i + 1
        Next
    End Sub
#End Region

    Private Sub TxtKodeDriver_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeDriver.EditValueChanged
        SetData("SELECT NAMA_USER FROM USERS WHERE ID_USER ='" & TxtKodeDriver.Text & "'", {TxtNamaDriver})
    End Sub

    Private Sub TxtKodeKendaraan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtKodeKendaraan.ButtonClick
        TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan_Pengiriman)
    End Sub

    Private Sub TxtKodeKendaraan_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeKendaraan.EditValueChanged
        SetData("SELECT NOPOL+' ('+TIPE+', '+MODEL+')' AS NAMA FROM KENDARAAN WHERE KODE_KENDARAAN ='" & TxtKodeKendaraan.Text & "'", {TxtNamaKendaraan})
        SetData("SELECT DRIVER FROM V_PENGIRIMAN_T_CHECK WHERE ST=0 AND KENDARAAN='" & TxtKodeKendaraan.Text & "'", {TxtKodeDriver})

        'If Not Status_Edit Then
        '    LoadData.GetData("SELECT DISTINCT B.URUTAN, A.ID_TRANSAKSI, A.NO_PENGIRIMAN, A.TGL_PENGAKUAN, B.ID_NOTA, C.NO_NOTA, C.TGL_PENGAKUAN, C.KODE_CUSTOMER, C.KODE_APPROVE, D.NAMA, C.DPP+C.PPN AS TOTAL, '-' AS CEK FROM V_PENGIRIMAN_T_CHECK A JOIN DETAIL_PENGIRIMAN B ON A.ID_TRANSAKSI=B.ID_TRANSAKSI LEFT JOIN NOTA C ON B.ID_NOTA=C.ID_TRANSAKSI LEFT JOIN CUSTOMER D ON C.KODE_CUSTOMER=D.ID WHERE A.ST=0 AND KENDARAAN='" & TxtKodeKendaraan.Text & "' ORDER BY B.URUTAN")
        '    LoadData.SetDataDetail(dt, False)
        '    Urutan()
        'End If
    End Sub

    Private Sub TxtKodeKendaraan_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeKendaraan.KeyPress
        If CharKeypress(TxtKodeKendaraan, e) Then TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan_Pengiriman)
    End Sub

    Private Sub TxtScan_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtScan.KeyUp
        If e.KeyCode = 13 Then
            If TxtScan.EditValue IsNot "" Then
                Using dtcekgate = SelectCon.execute("select ID_TRANSAKSI FROM PENGIRIMAN with(Nolock) WHERE NO_PENGIRIMAN = '" & TxtScan.EditValue & "'")
                    If dtcekgate.Rows.Count > 0 Then
                        If Not Status_Edit Then
                            LoadData.GetData("SELECT DISTINCT B.URUTAN, A.ID_TRANSAKSI, A.NO_PENGIRIMAN, A.TGL_PENGAKUAN, B.ID_NOTA, C.NO_NOTA, C.TGL_PENGAKUAN, C.KODE_CUSTOMER, C.KODE_APPROVE, D.NAMA, C.DPP+C.PPN AS TOTAL, '-' AS CEK FROM V_PENGIRIMAN_T_CHECK A JOIN DETAIL_PENGIRIMAN B ON A.ID_TRANSAKSI=B.ID_TRANSAKSI LEFT JOIN NOTA C ON B.ID_NOTA=C.ID_TRANSAKSI LEFT JOIN CUSTOMER D ON C.KODE_CUSTOMER=D.ID WHERE A.ST=0 AND B.NO_PENGIRIMAN='" & TxtScan.Text & "' and KENDARAAN = '" & TxtKodeKendaraan.Text & "' ORDER BY B.URUTAN")
                            LoadData.SetDataDetail(dt, False)
                            Urutan()
                        End If
                    Else
                        If dt.Select("[No Nota]='" & TxtScan.EditValue & "'").Length > 0 Then
                            Dim selected = dt.Select("[No Nota]='" & TxtScan.EditValue & "'")
                            selected.First().Item("Check") = "OK"

                        Else
                            MsgBox("Data nota tidak ditemukan!!!", MsgBoxStyle.Information, "Peringatan")

                        End If
                    End If
                End Using
                TxtScan.EditValue = ""
                If dt.Select("[Check]='Ok'").Length = GridView1.RowCount Then
                    PictureEditTrue.Image = My.Resources.netclipart_com_green_check_clipart_915169
                Else
                    PictureEditTrue.Image = My.Resources.ClipartKey_1304481
                End If
            End If
        End If
    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEditTrue.EditValueChanged

    End Sub

    Private Sub TxtScan_EditValueChanged(sender As Object, e As EventArgs) Handles TxtScan.EditValueChanged

    End Sub
End Class