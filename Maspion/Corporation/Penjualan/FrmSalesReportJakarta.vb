
Public MustInherit Class FrmSalesReportJakarta
    Protected dt As New DataTable
    Protected Status_Edit As Boolean
    Protected Bagian As EBagian

#Region "Shared Sub"
    Protected Sub Cetak() Handles _Toolbar1_Button6.ItemClick
        If _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.Pengiriman, TxtIDTransaksi.Text)
        'Log.Cetak(Me, TxtIDTransaksi.Text)
    End Sub

    Protected Sub Batal()
        Clean(Me)
        dt.Clear()
        AddRow(dt)
    End Sub

    Protected Sub Generate()
        Dim urut As Short
        Using dtGenerate = SelectCon.execute("SELECT NO_TRANSAKSI FROM SALES_REPORT_JAKARTA WHERE NO_TRANSAKSI Like 'SRJ" & "(" & InisialPerusahaan & ")" & "%' AND YEAR(TGL_KIRIM)=" & Format(TglPengakuan.EditValue, "yyyy") & " ORDER BY NO_TRANSAKSI DESC")
            If dtGenerate.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Microsoft.VisualBasic.Right(dtGenerate.Rows(0).Item(0), 6) + 1
            End If
            TxtNoTransaksi.Text = "SRJ" & "(" & InisialPerusahaan & ")" & Format(urut, "000000")
        End Using
        Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_TRANSAKSI,'SRJ','') AS BIGINT)),0) AS ID FROM SALES_REPORT_JAKARTA")
            TxtIDTransaksi.Text = "SRJ" & CInt(dtGenerate.Rows(0).Item(0)) + 1
        End Using
    End Sub

    Protected Sub Simpan()
        If Empty({TxtIDDSR, TxtKodeDivisi, TxtKodeGudang, TglTransaksi, TglPengakuan}) Then Exit Sub

        If dt.Select("[Nota]<>''").Length > 0 = False Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
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
            If SQLServer.InsertHeader({TxtIDTransaksi, TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtIDDSR, periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0}, "SALES_REPORT_JAKARTA") = False Then Exit Sub
            'Detail

            If SQLServer.InsertDetail(dt.Select("Nota<>''").CopyToDataTable, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), ToObject(TxtIDDSR.Text), ToObject(TxtNoDSR.Text), "ID Nota", "Nota", "DO", "ID Customer", "Bruto", "Std. Disc", "Add. Disc", "Cash Disc", "Netto", "No."}, "SALES_REPORT_JAKARTA_DETAIL") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Insert(Me, TxtIDTransaksi.Text)
            Batal()
        End Using
    End Sub

#Region "Edit"
    Protected Sub GetData()
        LoadData.GetData("select NO_TRANSAKSI,TGL,TGL_KIRIM,ID_DSR from sales_report_jakarta WHERE ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'")
        LoadData.SetData({TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtIDDSR})

        LoadData.GetData("select urutan,id_nota,no_nota,no_do,id_customer,b.nama,a.bruto,a.std_disc,a.add_disc,a.cash_disc,a.netto from sales_report_jakarta_detail a join customer b on a.id_customer = b.id WHERE A.ID_TRANSAKSI='" & TxtIDTransaksi.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, True)
        Hitung()
        Log.Load(Me, TxtIDTransaksi.Text)
    End Sub

    Protected Sub SimpanEdit()
        If Empty(TglTransaksi) Then Exit Sub


        If dt.Select("[Nota]<>''").Length > 0 = False Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If QuestionEdit() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.UpdateHeader("[NO_TRANSAKSI] ,[TGL] ,[TGL_KIRIM] ,[ID_DSR] ,[MDUSER] ,[MDTIME]", {TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtIDDSR, ToSyntax(UserID), ToSyntax("CURRENT_TIMESTAMP")}, "SALES_REPORT_JAKARTA", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            'Detail
            If SQLServer.Delete("SALES_REPORT_JAKARTA_DETAIL", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.InsertDetail(dt.Select("[Nota]<>''").CopyToDataTable, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), ToObject(TxtIDDSR.Text), ToObject(TxtNoDSR.Text), "ID Nota", "Nota", "DO", "ID Customer", "Bruto", "Std. Disc", "Add. Disc", "Cash Disc", "Netto", "No."}, "SALES_REPORT_JAKARTA_DETAIL") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Edit(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub

    Protected Sub Hapus()
        If QuestionHapus() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("SALES_REPORT_JAKARTA", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.Delete("SALES_REPORT_JAKARTA_DETAIL", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
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
            If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "SALES_REPORT_JAKARTA", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
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
        TglTransaksi.DateTime = Format(Now.Date, "dd/MM/yyyy")
        TglPengakuan.DateTime = Format(Now.Date, "dd/MM/yyyy")
        InitGrid.Clear()
        InitGrid.AddColumnGrid("No.", TypeCode.Int32, 20, False)
        InitGrid.AddColumnGrid("Id Nota", TypeCode.String, 80, False,,,,, False)
        InitGrid.AddColumnGrid("Nota", TypeCode.String, 80, False)
        InitGrid.AddColumnGrid("DO", TypeCode.String, 80, False)
        InitGrid.AddColumnGrid("Id Customer", TypeCode.String, 80, False,,,,, False)
        InitGrid.AddColumnGrid("Nama", TypeCode.String, 200, False)
        InitGrid.AddColumnGrid("Bruto", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Std. Disc", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Add. Disc", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Cash Disc", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2")
        InitGrid.AddColumnGrid("Netto", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2")
        '        InitGrid.AddColumnGrid("Batal", TypeCode.Double, 70, False, DevExpress.Utils.FormatType.Numeric, "n2", DevExpress.Utils.DefaultBoolean.False,, False)
        InitGrid.EndInit(TBDO, GridView1, dt)
        AddRow(dt)
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


    Private Sub GridView1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        'If e.KeyCode = 46 Then
        '    GridView1.DeleteRow(GridView1.FocusedRowHandle)
        '    GridView1.FocusedColumn = GridView1.Columns("No Nota")
        '    If GridView1.RowCount = 0 Then
        '        AddRow(dt)
        '        GridView1.FocusedColumn = GridView1.Columns("No Nota")
        '    End If
        '    Urutan()
        '    Hitung()
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

    Private Sub AllowEditColumn(ByRef Gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal EditColumn As String, ByVal CheckColumn As String)
        On Error Resume Next

    End Sub

    Protected Sub Hitung()
        'On Error Resume Next
        'Dim TempTotalDiskon As Double = 0
        'Dim Total As Double = 0
        'For Each col As DataRow In dt.Rows
        '    Total = Total + col("Total Nota")
        '    'TxtSubTotal.Text = Math.Round(Total)
        'Next
    End Sub
#End Region

    Private Sub TxtKodeGudang_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtIDDSR.ButtonClick
        TxtIDDSR.Text = Search(FrmPencarian.KeyPencarian.DSR)
    End Sub

    Private Sub TxtKodeGudang_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtIDDSR.EditValueChanged
        On Error Resume Next
        SetData("SELECT NO_DSR, TGL_PENGAKUAN, DIVISI, GUDANG FROM AR_DSR WHERE ID_TRANSAKSI='" & TxtIDDSR.Text & "'", {TxtNoDSR, DTTanggalDSR, TxtKodeDivisi, TxtKodeGudang})
        LoadData.GetData("SELECT A.URUTAN, A.ID_NOTA, A.NO_NOTA, A.NO_DO, A.ID_CUSTOMER, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & TxtIDDSR.Text & "' and isnull(a.batal,0) = 0 ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, False)
    End Sub

    Private Sub TxtKodeGudang_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIDDSR.KeyPress
        If CharKeypress(TxtIDDSR, e) Then TxtIDDSR.Text = Search(FrmPencarian.KeyPencarian.DSR)
    End Sub



    Private Sub TxtKodeDriver_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeDivisi.EditValueChanged
        SetData("SELECT NAMA FROM DIVISI WHERE KODE ='" & TxtKodeDivisi.Text & "'", {TxtNamaDivisi})
    End Sub

    Private Sub TxtKodeDriver_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeDivisi.KeyPress
        If CharKeypress(TxtKodeDivisi, e) Then TxtKodeDivisi.Text = Search(FrmPencarian.KeyPencarian.Karyawan)
    End Sub

    Private Sub TxtKodeKendaraan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)
    End Sub

    Private Sub TxtKodeKendaraan_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeGudang.EditValueChanged
        SetData("SELECT NAMA_GUDANG from GUDANG WHERE KODE ='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub

    Private Sub TxtKodeKendaraan_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeGudang.KeyPress
        If CharKeypress(TxtKodeGudang, e) Then TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)
    End Sub

    Private Sub TxtNoTransaksi_EditValueChanged(sender As Object, e As EventArgs) Handles TxtNoTransaksi.EditValueChanged

    End Sub

    Private Sub DTTanggalDSR_EditValueChanged(sender As Object, e As EventArgs) Handles DTTanggalDSR.EditValueChanged

    End Sub
End Class