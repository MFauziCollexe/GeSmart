
Public Class MenuKodePerkiraan
    Inherits FrmMenu

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT KODE_PERKIRAAN, NAMA_PERKIRAAN, JENIS, URUTAN, CASE STATUS_AKTIF WHEN 1 THEN 'Aktif' ELSE 'Tidak Aktif' END AS STATUS_AKTIF, KAS_BANK FROM AR_KODE_PERKIRAAN ORDER BY KODE_PERKIRAAN")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Kode Perkiraan ]"
        GridView1.Columns(0).Caption = "Kode"
        GridView1.Columns(0).Width = 50
        GridView1.Columns(1).Caption = "Nama"
        GridView1.Columns(1).Width = 125
        GridView1.Columns(2).Caption = "Jenis"
        GridView1.Columns(2).Width = 75
        GridView1.Columns(3).Caption = "Urutan"
        GridView1.Columns(3).Width = 25
        GridView1.Columns(4).Caption = "Status Aktif"
        GridView1.Columns(4).Width = 75
        GridView1.Columns(5).Caption = "Kas/Bank"
        GridView1.Columns(5).Width = 75
    End Sub


    Private Sub MenuKaryawan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Kode Perkiraan"
        AddHandler Me.Activated, AddressOf GetData
        'HakMenu("", "Master", "Divisi", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputKodePerkiraan.MdiParent = Me.MdiParent
        InputKodePerkiraan.Show()
        InputKodePerkiraan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditKodePerkiraan.MdiParent = Me.MdiParent
                EditKodePerkiraan.Show()
                EditKodePerkiraan.Focus()
                EditKodePerkiraan.TxtKode.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditKodePerkiraan
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.Focus()
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.TxtKode.Text = GridView1.GetFocusedRow(0)
                frm.Toolbar1.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class


Public Class MenuCreateDSRPrw
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI, NO_DSR, TGL, TGL_PENGAKUAN, B.NAMA, C.NAMA_GUDANG FROM AR_DSR A LEFT JOIN DIVISI B ON A.DIVISI=B.KODE LEFT JOIN GUDANG C ON A.GUDANG=C.KODE WHERE A.JENIS='Perwakilan' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data DSR ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. DSR"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. DSR"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Divisi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Gudang"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(5).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Nota"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "DO"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Nama"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Bruto"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Std. Disc"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
                GridView2.Columns(6).Caption = "Add. Disc"
                GridView2.Columns(6).Width = 35
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
                GridView2.Columns(7).Caption = "Cash Disc"
                GridView2.Columns(7).Width = 35
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
                GridView2.Columns(8).Caption = "Netto"
                GridView2.Columns(8).Width = 35
                GridView2.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(8).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Daily Sales Report Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputCreateDSRPrw.MdiParent = Me.MdiParent
        InputCreateDSRPrw.Show()
        InputCreateDSRPrw.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditCreateDSRPrw.MdiParent = Me.MdiParent
                EditCreateDSRPrw.Show()
                EditCreateDSRPrw.Focus()
                EditCreateDSRPrw.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditCreateDSRPrw
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class


Public Class MenuCreateDSRPus
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI, NO_DSR, TGL, TGL_PENGAKUAN, B.NAMA, C.NAMA_GUDANG FROM AR_DSR A LEFT JOIN DIVISI B ON A.DIVISI=B.KODE LEFT JOIN GUDANG C ON A.GUDANG=C.KODE WHERE A.JENIS='Pusat' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data DSR ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. DSR"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. DSR"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Divisi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Gudang"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(5).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Nota"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "DO"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Nama"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Bruto"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Std. Disc"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
                GridView2.Columns(6).Caption = "Add. Disc"
                GridView2.Columns(6).Width = 35
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
                GridView2.Columns(7).Caption = "Cash Disc"
                GridView2.Columns(7).Width = 35
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
                GridView2.Columns(8).Caption = "Netto"
                GridView2.Columns(8).Width = 35
                GridView2.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(8).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Daily Sales Report Pusat"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputCreateDSRPus.MdiParent = Me.MdiParent
        InputCreateDSRPus.Show()
        InputCreateDSRPus.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditCreateDSRPus.MdiParent = Me.MdiParent
                EditCreateDSRPus.Show()
                EditCreateDSRPus.Focus()
                EditCreateDSRPus.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditCreateDSRPus
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuValidasiDSRPrw
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT AA.ID_TRANSAKSI, AA.NO_VALIDASI,AA.TGL, AA.NO_DSR, A.TGL_PENGAKUAN, B.NAMA, C.NAMA_GUDANG, AA.BATAL FROM AR_VALIDASI_DSR AA JOIN AR_DSR A ON AA.ID_DSR=A.ID_TRANSAKSI LEFT JOIN DIVISI B ON A.DIVISI=B.KODE LEFT JOIN GUDANG C ON A.GUDANG=C.KODE WHERE A.JENIS='Perwakilan' AND AA.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Validasi ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Validasi"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "No. DSR"
        GridView1.Columns(3).Width = 50
        GridView1.Columns(4).Caption = "Tgl. DSR"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(5).Caption = "Divisi"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(6).Caption = "Gudang"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI=(SELECT TOP 1 ID_DSR FROM AR_VALIDASI_DSR WHERE ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "') ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Nota"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "DO"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Nama"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Bruto"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Std. Disc"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
                GridView2.Columns(6).Caption = "Add. Disc"
                GridView2.Columns(6).Width = 35
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
                GridView2.Columns(7).Caption = "Cash Disc"
                GridView2.Columns(7).Width = 35
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
                GridView2.Columns(8).Caption = "Netto"
                GridView2.Columns(8).Width = 35
                GridView2.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(8).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Validasi DSR Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputValidasiDSRPrw.MdiParent = Me.MdiParent
        InputValidasiDSRPrw.Show()
        InputValidasiDSRPrw.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditValidasiDSRPrw.MdiParent = Me.MdiParent
                EditValidasiDSRPrw.Show()
                EditValidasiDSRPrw.Focus()
                EditValidasiDSRPrw.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditValidasiDSRPrw
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuValidasiDSRPus
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT AA.ID_TRANSAKSI, AA.NO_VALIDASI,AA.TGL, AA.NO_DSR, A.TGL_PENGAKUAN, B.NAMA, C.NAMA_GUDANG, AA.BATAL FROM AR_VALIDASI_DSR AA JOIN AR_DSR A ON AA.ID_DSR=A.ID_TRANSAKSI LEFT JOIN DIVISI B ON A.DIVISI=B.KODE LEFT JOIN GUDANG C ON A.GUDANG=C.KODE WHERE A.JENIS='Pusat' AND AA.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Validasi ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Validasi"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "No. DSR"
        GridView1.Columns(3).Width = 50
        GridView1.Columns(4).Caption = "Tgl. DSR"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(5).Caption = "Divisi"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(6).Caption = "Gudang"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.NO_NOTA, A.NO_DO, B.NAMA, A.BRUTO, A.STD_DISC, A.ADD_DISC, A.CASH_DISC, A.NETTO FROM AR_DSR_DETAIL A JOIN CUSTOMER B ON A.ID_CUSTOMER=B.ID WHERE A.ID_TRANSAKSI=(SELECT TOP 1 ID_DSR FROM AR_VALIDASI_DSR WHERE ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "') ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Nota"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "DO"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Nama"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Bruto"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Std. Disc"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
                GridView2.Columns(6).Caption = "Add. Disc"
                GridView2.Columns(6).Width = 35
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
                GridView2.Columns(7).Caption = "Cash Disc"
                GridView2.Columns(7).Width = 35
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
                GridView2.Columns(8).Caption = "Netto"
                GridView2.Columns(8).Width = 35
                GridView2.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(8).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Validasi DSR Pusat"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputValidasiDSRPus.MdiParent = Me.MdiParent
        InputValidasiDSRPus.Show()
        InputValidasiDSRPus.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditValidasiDSRPus.MdiParent = Me.MdiParent
                EditValidasiDSRPus.Show()
                EditValidasiDSRPus.Focus()
                EditValidasiDSRPus.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditValidasiDSRPus
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class


Public Class MenuJurnal
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT ID_JURNAL, NO_JURNAL, TGL, TGL_PENGAKUAN, LINK_TRANSAKSI, LINK_KASBANK, BATAL FROM AR_JURNAL WHERE PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Jurnal ]"
        GridView1.Columns(0).Caption = "ID"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Jurnal"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Link Transaksi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Link Kas/Bank"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(6).Caption = "Batal"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(6).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.KETERANGAN, A.DEBET, A.KREDIT FROM AR_JURNAL_DETAIL A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.ID_JURNAL='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Perkiraan"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "Nama Perkiraan"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Keterangan"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Debet"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Kredit"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Jurnal"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputJurnal.MdiParent = Me.MdiParent
        InputJurnal.Show()
        InputJurnal.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditJurnal.MdiParent = Me.MdiParent
                EditJurnal.Show()
                EditJurnal.Focus()
                EditJurnal.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditJurnal
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class


Public Class MenuKasMasuk
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI, A.NO_KAS, A.TGL, A.TGL_PENGAKUAN, A.LINK_TRANSAKSI, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.BATAL FROM AR_KAS A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.JENIS='KM' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Kas Keluar ]"
        GridView1.Columns(0).Caption = "ID"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Bukti"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Link Transaksi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Kode Perkiraan"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Nama Perkiraan"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.KETERANGAN, A.NOMINAL FROM AR_KAS_DETAIL A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Perkiraan"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "Nama Perkiraan"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Keterangan"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Nominal"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Kas Masuk"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputKasMasuk.MdiParent = Me.MdiParent
        InputKasMasuk.Show()
        InputKasMasuk.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditKasMasuk.MdiParent = Me.MdiParent
                EditKasMasuk.Show()
                EditKasMasuk.Focus()
                EditKasMasuk.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditKasMasuk
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuKasKeluar
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI, A.NO_KAS, A.TGL, A.TGL_PENGAKUAN, A.LINK_TRANSAKSI, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.BATAL FROM AR_KAS A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.JENIS='KK' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Kas Keluar ]"
        GridView1.Columns(0).Caption = "ID"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Bukti"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Link Transaksi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Kode Perkiraan"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Nama Perkiraan"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.KETERANGAN, A.NOMINAL FROM AR_KAS_DETAIL A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Perkiraan"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "Nama Perkiraan"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Keterangan"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Nominal"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Kas Keluar"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputKasKeluar.MdiParent = Me.MdiParent
        InputKasKeluar.Show()
        InputKasKeluar.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditKasKeluar.MdiParent = Me.MdiParent
                EditKasKeluar.Show()
                EditKasKeluar.Focus()
                EditKasKeluar.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditKasKeluar
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class


Public Class MenuBankMasuk
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI, A.NO_BANK, A.TGL, A.TGL_PENGAKUAN, A.LINK_TRANSAKSI, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.BATAL FROM AR_BANK A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.JENIS='BM' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Bank Masuk ]"
        GridView1.Columns(0).Caption = "ID"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Bukti"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Link Transaksi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Kode Perkiraan"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Nama Perkiraan"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.KETERANGAN, A.NOMINAL FROM AR_BANK_DETAIL A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Perkiraan"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "Nama Perkiraan"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Keterangan"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Nominal"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Bank Masuk"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputBankMasuk.MdiParent = Me.MdiParent
        InputBankMasuk.Show()
        InputBankMasuk.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditBankMasuk.MdiParent = Me.MdiParent
                EditBankMasuk.Show()
                EditBankMasuk.Focus()
                EditBankMasuk.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditBankMasuk
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuBankKeluar
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI, A.NO_BANK, A.TGL, A.TGL_PENGAKUAN, A.LINK_TRANSAKSI, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.BATAL FROM AR_BANK A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.JENIS='BK' AND A.PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Bank Keluar ]"
        GridView1.Columns(0).Caption = "ID"
        GridView1.Columns(0).Width = 40
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "No. Bukti"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Dibuat"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Link Transaksi"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Kode Perkiraan"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Nama Perkiraan"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.KODE_PERKIRAAN, B.NAMA_PERKIRAAN, A.KETERANGAN, A.NOMINAL FROM AR_BANK_DETAIL A JOIN AR_KODE_PERKIRAAN B ON A.KODE_PERKIRAAN=B.KODE_PERKIRAAN WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Perkiraan"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "Nama Perkiraan"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Keterangan"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Nominal"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Bank Keluar"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        'HakMenu("", "Retur", "Tanda Terima Barang", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        'BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'keyPrint = ReportPreview.KeyReport.TTB
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        'If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.TTB, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputBankKeluar.MdiParent = Me.MdiParent
        InputBankKeluar.Show()
        InputBankKeluar.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditBankKeluar.MdiParent = Me.MdiParent
                EditBankKeluar.Show()
                EditBankKeluar.Focus()
                EditBankKeluar.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditBankKeluar
                frm.MdiParent = Me.MdiParent
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.Show()
                frm.Focus()
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class
