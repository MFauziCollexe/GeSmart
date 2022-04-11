﻿Public Class MenuDeliveryOrderSupermarketPusat
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.PEMBAYARAN,A.TERMS,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND JENIS_DO='Ada Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        'TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.PEMBAYARAN,A.TERMS,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND JENIS_DO='Ada Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Delivery Order ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Pengakuan"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tanggal"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tanggal Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Nama Customer"
        GridView1.Columns(4).Width = 75
        GridView1.Columns(5).Caption = "Pembuat"
        GridView1.Columns(5).Width = 50
        GridView1.Columns(6).Caption = "Pembayaran"
        GridView1.Columns(6).Width = 20
        GridView1.Columns(7).Caption = "Terms"
        GridView1.Columns(7).Width = 15
        GridView1.Columns(8).Caption = "Total"
        GridView1.Columns(8).Width = 40
        GridView1.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(8).DisplayFormat.FormatString = "n2"
        GridView1.Columns(9).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle >= 0 Then
                If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                    TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN,A.ID_BARANG,B.KODE,B.NAMA,A.KOLI,A.QUANTITY,A.SATUAN,A.HARGA,A.DISC,A.DISKON_SATUAN,ROUND(A.QUANTITY * (A.HARGA * ((100 - (A.DISC / A.HARGA) * 100)) / 100),2) AS SUBTOTAL FROM DETAIL_DELIVERY_ORDER A WITH (NOLOCK) LEFT JOIN BARANG B WITH (NOLOCK) ON A.ID_BARANG=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                    TBMenuDetailMenu.Refresh()
                    GridView2.Columns(0).Caption = "No."
                    GridView2.Columns(0).Width = 15
                    GridView2.Columns(1).Caption = "ID Barang"
                    GridView2.Columns(1).Width = 50
                    GridView2.Columns(1).Visible = False
                    GridView2.Columns(2).Caption = "Kode Barang"
                    GridView2.Columns(2).Width = 50
                    GridView2.Columns(3).Caption = "Nama Barang"
                    GridView2.Columns(3).Width = 150
                    GridView2.Columns(4).Caption = "Koli"
                    GridView2.Columns(4).Width = 40
                    GridView2.Columns(5).Caption = "Kuantum"
                    GridView2.Columns(5).Width = 40
                    GridView2.Columns(6).Caption = "Satuan"
                    GridView2.Columns(6).Width = 50
                    GridView2.Columns(7).Caption = "Harga"
                    GridView2.Columns(7).Width = 60
                    GridView2.Columns(8).Caption = "Disc %"
                    GridView2.Columns(8).Width = 30
                    GridView2.Columns(9).Caption = "Disc Satuan"
                    GridView2.Columns(9).Width = 60
                    GridView2.Columns(10).Caption = "Subtotal"
                    GridView2.Columns(10).Width = 70
                    GridView2.Columns(10).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView2.Columns(10).DisplayFormat.FormatString = "n2"
                End If
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Delivery Order Supermarket Pusat"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Supermarket", "Pusat", "Delivery Order", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        keyPrint = ReportPreview.KeyReport.DO_Kontan
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        Using dtcek As DataTable = SelectCon.execute("SELECT PEMBAYARAN FROM DELIVERY_ORDER WITH (NOLOCK) WHERE ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
            If dtcek.Rows.Count > 0 Then
                If dtcek.Rows(0).Item(0) = "Kontan" Then
                    ShowDevexpressReport(ReportPreview.KeyReport.DO_Kontan, GridView1.GetFocusedRow(0))
                ElseIf dtcek.Rows(0).Item(0) = "Kredit" Then
                    ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Order, GridView1.GetFocusedRow(0))
                End If
            End If
        End Using
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputDeliveryOrderSupermarketPusat.MdiParent = Me.MdiParent
        InputDeliveryOrderSupermarketPusat.Show()
        InputDeliveryOrderSupermarketPusat.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditDeliveryOrderSupermarketPusat.MdiParent = Me.MdiParent
                EditDeliveryOrderSupermarketPusat.Show()
                EditDeliveryOrderSupermarketPusat.Focus()
                EditDeliveryOrderSupermarketPusat.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                Log.Load(EditDeliveryOrderSupermarketPusat, GridView1.GetFocusedRow(0))
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditDeliveryOrderSupermarketPusat
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

Public Class MenuDOTitipanSupermarketPusat
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.TGL_PRICE,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND JENIS_DO='Tanpa Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        'TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.TGL_PRICE,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND JENIS_DO='Tanpa Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Delivery Order ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Transaksi"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tanggal"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tanggal Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Nama Customer"
        GridView1.Columns(4).Width = 75
        GridView1.Columns(5).Caption = "Pembuat"
        GridView1.Columns(5).Width = 50
        GridView1.Columns(6).Caption = "Tgl. Price List"
        GridView1.Columns(6).Width = 30
        GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(6).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(7).Caption = "Total"
        GridView1.Columns(7).Width = 40
        GridView1.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(7).DisplayFormat.FormatString = "c2"
        GridView1.Columns(8).Visible = False
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "DO Titipan Supermarket Pusat"
        AddHandler Activated, AddressOf GetData
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        HakMenu("Penjualan Supermarket", "Pusat", "DO Titipan", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        keyPrint = ReportPreview.KeyReport.DO_Titipan
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.DO_Titipan, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputDOTitipanSupermarketPusat.MdiParent = Me.MdiParent
        InputDOTitipanSupermarketPusat.Show()
        InputDOTitipanSupermarketPusat.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditDOTitipanSupermarketPusat.MdiParent = Me.MdiParent
                EditDOTitipanSupermarketPusat.Show()
                EditDOTitipanSupermarketPusat.Focus()
                EditDOTitipanSupermarketPusat.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditDOTitipanSupermarketPusat
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

Public Class MenuBonPesananSupermarketPusat
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_BON,A.TGL,A.TGL_PENGAKUAN,A.NO_DO,A.TGL_PRICE,B.NAMA,D.NAMA_USER,DPP+PPN AS TOTAL,A.BATAL FROM BON_PESANAN A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        'TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_BON,A.TGL,A.TGL_PENGAKUAN,A.NO_DO,A.TGL_PRICE,B.NAMA,D.NAMA_USER,DPP+PPN AS TOTAL,A.BATAL FROM BON_PESANAN A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Delivery Order ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Transaksi"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tanggal"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tanggal Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "No. DO Titipan"
        GridView1.Columns(4).Width = 50
        GridView1.Columns(5).Caption = "Tgl. Price List"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(5).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(6).Caption = "Nama Customer"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Caption = "Pembuat"
        GridView1.Columns(7).Width = 50
        GridView1.Columns(8).Caption = "Total"
        GridView1.Columns(8).Width = 40
        GridView1.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(8).DisplayFormat.FormatString = "n2"
        GridView1.Columns(9).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle >= 0 Then
                If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                    TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN,A.ID_BARANG,B.KODE,B.NAMA,A.KOLI,A.QUANTITY,A.SATUAN,A.HARGA,A.DISC,A.DISKON_SATUAN,ROUND(A.QUANTITY * (A.HARGA * ((100 - (A.DISC / A.HARGA) * 100)) / 100),2) AS SUBTOTAL FROM DETAIL_BON_PESANAN A WITH (NOLOCK) LEFT JOIN BARANG B WITH (NOLOCK) ON A.ID_BARANG=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                    TBMenuDetailMenu.Refresh()
                    GridView2.Columns(0).Caption = "No."
                    GridView2.Columns(0).Width = 15
                    GridView2.Columns(1).Caption = "ID Barang"
                    GridView2.Columns(1).Width = 50
                    GridView2.Columns(1).Visible = False
                    GridView2.Columns(2).Caption = "Kode Barang"
                    GridView2.Columns(2).Width = 50
                    GridView2.Columns(3).Caption = "Nama Barang"
                    GridView2.Columns(3).Width = 150
                    GridView2.Columns(4).Caption = "Koli"
                    GridView2.Columns(4).Width = 40
                    GridView2.Columns(5).Caption = "Kuantum"
                    GridView2.Columns(5).Width = 40
                    GridView2.Columns(6).Caption = "Satuan"
                    GridView2.Columns(6).Width = 50
                    GridView2.Columns(7).Caption = "Harga"
                    GridView2.Columns(7).Width = 60
                    GridView2.Columns(8).Caption = "Disc %"
                    GridView2.Columns(8).Width = 30
                    GridView2.Columns(9).Caption = "Disc Satuan"
                    GridView2.Columns(9).Width = 60
                    GridView2.Columns(10).Caption = "Subtotal"
                    GridView2.Columns(10).Width = 70
                    GridView2.Columns(10).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView2.Columns(10).DisplayFormat.FormatString = "n2"
                End If
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Bon Pesanan Supermarket Pusat"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Supermarket", "Pusat", "Bon Pesanan (Titipan)", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)

        BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        keyPrint = ReportPreview.KeyReport.Bon_Pesanan_Titipan
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Titipan, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputBonPesananSupermarketPusat.MdiParent = Me.MdiParent
        InputBonPesananSupermarketPusat.Show()
        InputBonPesananSupermarketPusat.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditBonPesananSupermarketPusat.MdiParent = Me.MdiParent
                EditBonPesananSupermarketPusat.Show()
                EditBonPesananSupermarketPusat.Focus()
                EditBonPesananSupermarketPusat.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditBonPesananSupermarketPusat
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

Public Class MenuNotaSJSupermarketPusat
    Inherits FrmMenuDetail

    Private Sub GetData()
        'TBMenu.DataSource = SelectCon.execute("SELECT DISTINCT ID_TRANSAKSI,NO_NOTA,NO_REF,TGL,TGL_PENGAKUAN,NO_DO,TGL_DO,B.NAMA,D.NAMA_USER,A.DPP+A.PPN AS TOTAL,A.BATAL FROM NOTA A LEFT JOIN CUSTOMER B ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        TBMenu.DataSource = SelectCon.execute("SELECT DISTINCT ID_TRANSAKSI,NO_NOTA,NO_REF,TGL,TGL_PENGAKUAN,NO_DO,TGL_DO,B.NAMA,D.NAMA_USER,A.DPP+A.PPN AS TOTAL,A.BATAL FROM NOTA A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Supermarket Pusat' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Nota ]"
        GridView1.Columns(0).Caption = "ID. Nota"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Nota"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "No. Ref"
        GridView1.Columns(2).Width = 50
        GridView1.Columns(3).Caption = "Tgl. Nota"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Tgl. Pengakuan"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(5).Caption = "No. DO"
        GridView1.Columns(5).Width = 50
        GridView1.Columns(6).Caption = "Tgl. DO"
        GridView1.Columns(6).Width = 30
        GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(6).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(7).Caption = "Nama Customer"
        GridView1.Columns(7).Width = 75
        GridView1.Columns(8).Caption = "Pembuat"
        GridView1.Columns(8).Width = 50
        GridView1.Columns(9).Caption = "Total"
        GridView1.Columns(9).Width = 40
        GridView1.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(9).DisplayFormat.FormatString = "n2"
        GridView1.Columns(10).Visible = False
        GetDataDetail()
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If GridView1.FocusedRowHandle >= 0 Then
                If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                    TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN,B.KODE,B.NAMA,A.KOLI,A.QUANTITY,A.SATUAN,A.HARGA,A.DISC,A.DISKON_SATUAN,ROUND(A.QUANTITY * (A.HARGA * ((100 - (A.DISC / A.HARGA) * 100)) / 100),2) AS SUBTOTAL FROM DETAIL_NOTA A WITH (NOLOCK) LEFT JOIN BARANG B WITH (NOLOCK) ON A.ID_BARANG=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                    TBMenuDetailMenu.Refresh()
                    GridView2.Columns(0).Caption = "No."
                    GridView2.Columns(0).Width = 15
                    GridView2.Columns(1).Caption = "Kode Barang"
                    GridView2.Columns(1).Width = 50
                    GridView2.Columns(2).Caption = "Nama Barang"
                    GridView2.Columns(2).Width = 150
                    GridView2.Columns(3).Caption = "Koli"
                    GridView2.Columns(3).Width = 40
                    GridView2.Columns(4).Caption = "Kuantum"
                    GridView2.Columns(4).Width = 40
                    GridView2.Columns(5).Caption = "Satuan"
                    GridView2.Columns(5).Width = 50
                    GridView2.Columns(6).Caption = "Harga"
                    GridView2.Columns(6).Width = 60
                    GridView2.Columns(7).Caption = "Disc %"
                    GridView2.Columns(7).Width = 30
                    GridView2.Columns(8).Caption = "Disc Satuan"
                    GridView2.Columns(8).Width = 60
                    GridView2.Columns(9).Caption = "Subtotal"
                    GridView2.Columns(9).Width = 70
                    GridView2.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView2.Columns(9).DisplayFormat.FormatString = "n2"
                End If
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Nota / SJ Supermarket Pusat"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Supermarket", "Pusat", "Nota / Surat Jalan", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        keyPrint = ReportPreview.KeyReport.Nota_SJ
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Nota_SJ, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputNotaSJSupermarketPusat.MdiParent = Me.MdiParent
        InputNotaSJSupermarketPusat.Show()
        InputNotaSJSupermarketPusat.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditNotaSJSupermarketPusat.MdiParent = Me.MdiParent
                EditNotaSJSupermarketPusat.Show()
                EditNotaSJSupermarketPusat.Focus()
                EditNotaSJSupermarketPusat.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditNotaSJSupermarketPusat
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

