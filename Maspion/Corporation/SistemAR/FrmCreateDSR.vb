
Public MustInherit Class FrmCreateDSR
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
                LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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

    Protected Function Generate() As Boolean
        Dim urut As Short
        Using dtGenerate = SelectCon.execute("SELECT NO_DSR FROM AR_DSR WHERE NO_DSR Like 'DSR-" & TxtNamaDivisi.Text & "-" & TxtKodeGudang.Text & "-%' AND YEAR(TGL_PENGAKUAN)=" & Format(TglTransaksi.EditValue, "yyyy") & " AND DIVISI='" & TxtDivisi.Text & "' ORDER BY NO_DSR DESC")
            If dtGenerate.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Microsoft.VisualBasic.Right(dtGenerate.Rows(0).Item(0), 6) + 1
            End If
            TxtNoTransaksi.Text = "DSR- " & TxtNamaDivisi.Text & "-" & TxtKodeGudang.Text & "-" & Format(urut, "00000")
        End Using

        Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_TRANSAKSI,'DSR','') AS INT)),0) AS ID FROM AR_DSR")
            TxtIDTransaksi.Text = "DSR" & CInt(dtGenerate.Rows(0).Item(0)) + 1
        End Using
        Return True
    End Function

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
    Private Sub TxtDivisi_Click(sender As Object, e As System.EventArgs) Handles TxtDivisi.Click
        TxtDivisi.Text = Search(FrmPencarian.KeyPencarian.Divisi)
    End Sub
    Private Sub TxtDivisi_EditValueChanged(sender As Object, e As System.EventArgs) Handles TxtDivisi.EditValueChanged
        On Error Resume Next
        SetData("SELECT NAMA FROM DIVISI WHERE KODE='" & TxtDivisi.Text & "'", {TxtNamaDivisi})
    End Sub
    Private Sub txtDivisi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDivisi.KeyPress
        If CharKeypress(TxtDivisi, e) Then TxtDivisi.Text = Search(FrmPencarian.KeyPencarian.Divisi)
    End Sub

    'GUDANG
    Private Sub TxtKodeGudang_Click(sender As Object, e As System.EventArgs) Handles TxtKodeGudang.Click
        TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang_All)
    End Sub
    Private Sub TxtKodeGudang_EditValueChanged(sender As Object, e As System.EventArgs) Handles TxtKodeGudang.EditValueChanged
        On Error Resume Next
        SetData("SELECT NAMA_GUDANG FROM GUDANG WHERE KODE='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub
    Private Sub TxtKodeGudang_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeGudang.KeyPress
        If CharKeypress(TxtKodeGudang, e) Then TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang_All)
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.ItemClick
        Me.Close()
    End Sub

End Class


Public Class InputCreateDSR
    Inherits FrmCreateDSR
    Private Sub Batal() Handles _Toolbar1_Button2.ItemClick
        Clean(Me)
        dt.Clear()
        AddRow(dt)
    End Sub

    Private Sub GetDataDSR() Handles TxtDivisi.EditValueChanged, TxtKodeGudang.EditValueChanged, TglPengakuan.EditValueChanged, RDPembayaran.EditValueChanged
        Dim Filter = ""
        If Jenis = JenisEnum.Perwakilan Then Filter = " AND NOTA.BAGIAN LIKE '%Perwakilan%' AND NOTA.GUDANG='" & TxtKodeGudang.Text & "' "
        If Jenis = JenisEnum.Pusat Then Filter = " AND NOTA.BAGIAN LIKE '%Pusat%' AND DO.PEMBAYARAN='" & RDPembayaran.EditValue & "' "
        LoadData.GetData("SELECT ROW_NUMBER() OVER (ORDER BY CAST(RIGHT(Nota, 6) AS INT)) 'No.',* FROM ( SELECT DISTINCT NOTA.NO_NOTA AS 'Nota',NOTA.NO_DO AS 'DO', NOTA.KODE_CUSTOMER 'Id Customer', CUSTOMER.NAMA AS 'Nama', NOTA.SUBTOTAL AS 'Bruto', NOTA.DISC_REG_NOMINAL AS 'Std. Disc', NOTA.DISC_QTY_NOMINAL+NOTA.DISC_QTY_NOMINAL1+NOTA.DISC_1_NOMINAL+NOTA.DISC_2_NOMINAL+NOTA.DISC_3_NOMINAL AS 'Add. Disc', NOTA.CASH_DISC_NOMINAL AS 'Cash Disc', NOTA.DPP+NOTA.PPN AS 'Netto' FROM NOTA LEFT JOIN DELIVERY_ORDER DO ON NOTA.ID_DO=DO.ID_TRANSAKSI LEFT JOIN CUSTOMER ON NOTA.KODE_CUSTOMER = CUSTOMER.ID WHERE CONVERT(DATE,NOTA.TGL_PENGAKUAN,103) = CONVERT(DATE,'" & TglPengakuan.DateTime & "',103) AND NOTA.DIVISI='" & TxtDivisi.Text & "' " & Filter & ") A  ORDER BY CAST(RIGHT(Nota, 6) AS INT)")
        LoadData.SetDataDetail(dt, False)
    End Sub

    Private Sub Simpan() Handles _Toolbar1_Button1.ItemClick
        If Empty({TglTransaksi, TglPengakuan, TxtDivisi}) Then Exit Sub
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
            If SQLServer.InsertHeader({TxtIDTransaksi, TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtDivisi, TxtKodeGudang, RDPembayaran, Jenis.ToString, periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0}, "AR_DSR") = False Then Exit Sub
            'Detail
            If SQLServer.InsertDetail(dt, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), "Nota", "DO", "Id Customer", "Bruto", "Std. Disc", "Add. Disc", "Cash Disc", "Netto", "No."}, "AR_DSR_DETAIL") = False Then Exit Sub
            SQLServer.EndTransaction()
            Batal()
        End Using
    End Sub
End Class

Public Class EditCreateDSR
    Inherits FrmCreateDSR

    Private Sub GetData() Handles _Toolbar1_Button2.ItemClick, TxtIDTransaksi.EditValueChanged
        LoadData.GetData("SELECT NO_DSR, TGL, TGL_PENGAKUAN, DIVISI, GUDANG FROM AR_DSR WHERE ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'")
        LoadData.SetData({TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtDivisi, TxtKodeGudang})

        LoadData.GetData("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, A.ID_CUSTOMER, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & TxtIDTransaksi.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, False)
    End Sub

    Private Sub SimpanEdit() Handles _Toolbar1_Button1.ItemClick
        If Empty({TglTransaksi, TxtNoTransaksi, TxtDivisi}) Then Exit Sub

        If dt.Rows.Count = 0 Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If QuestionEdit() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header()
            If SQLServer.UpdateHeader("[NO_DSR] ,[TGL] ,[TGL_PENGAKUAN] ,[DIVISI] ,[GUDANG], [PEMBAYARAN] ,[MDUSER] ,[MDTIME]", {TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtDivisi, TxtKodeGudang, RDPembayaran, ToSyntax(UserID), ToSyntax("CURRENT_TIMESTAMP")}, "AR_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            'Detail
            If SQLServer.Delete("AR_DSR_DETAIL", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.InsertDetail(dt, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), "Nota", "DO", "Id Customer", "Bruto", "Std. Disc", "Add. Disc", "Cash Disc", "Netto", "No."}, "AR_DSR_DETAIL") = False Then Exit Sub
            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub

    Private Sub Hapus() Handles _Toolbar1_Button5.ItemClick
        If QuestionHapus() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("AR_DSR_DETAIL", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.Delete("AR_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub

    Private Sub Batal() Handles _Toolbar1_Button4.ItemClick
        If QuestionBatal() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "AR_DSR", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Me.Dispose()
        End Using
    End Sub
End Class


Public Class InputCreateDSRPrw
    Inherits InputCreateDSR

    Private Sub InputCreateDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Jenis = JenisEnum.Perwakilan
        Text = "Input Daily Sales Report Perwakilan"
        _Toolbar1_Button4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Status_Edit = False
    End Sub
End Class

Public Class EditCreateDSRPrw
    Inherits EditCreateDSR

    Private Sub EditCreateDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Jenis = JenisEnum.Perwakilan
        Text = "Edit Daily Sales Report Perwakilan"
        Status_Edit = True
        'HakForm("", "Retur", "Daily Sales Report", _Toolbar1_Button4, _Toolbar1_Button5, _Toolbar1_Button6)
        'TxtNoTransaksi.Properties.ReadOnly = True
        'TxtDivisi.Enabled = False
    End Sub
End Class


Public Class InputCreateDSRPus
    Inherits InputCreateDSR

    Private Sub InputCreateDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Jenis = JenisEnum.Pusat
        Text = "Input Daily Sales Report Pusat"
        _Toolbar1_Button4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Status_Edit = False
    End Sub
End Class

Public Class EditCreateDSRPus
    Inherits EditCreateDSR

    Private Sub EditCreateDSRPrw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Jenis = JenisEnum.Pusat
        Text = "Edit Daily Sales Report Pusat"
        Status_Edit = True
        'HakForm("", "Retur", "Daily Sales Report", _Toolbar1_Button4, _Toolbar1_Button5, _Toolbar1_Button6)
        'TxtNoTransaksi.Properties.ReadOnly = True
        'TxtDivisi.Enabled = False
    End Sub
End Class