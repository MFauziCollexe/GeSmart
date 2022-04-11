Public Class MenuDeliveryOrderLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        'TBMenu.DataSource = SelectCon.execute("SET NOCOUNT ON SELECT DISTINCT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,G.NAMA_GUDANG,A.PEMBAYARAN,A.TERMS,DPP+PPN AS TOTAL,A.BATAL,ST.STK FROM DELIVERY_ORDER A WITH (NOLOCK) JOIN V_D_DB_PERW_T_STUFF ST WITH (NOLOCK) ON A.ID_TRANSAKSI=ST.ID_TRANSAKSI LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER LEFT JOIN GUDANG G WITH (NOLOCK) ON A.GUDANG=G.KODE WHERE BAGIAN='Langganan Perwakilan' AND JENIS_DO='Ada Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")

        'TBMenu.DataSource = SelectCon.execute("SET NOCOUNT ON SELECT DISTINCT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,G.NAMA_GUDANG,A.PEMBAYARAN,A.TERMS,DPP+PPN AS TOTAL,A.BATAL,ST.STK FROM DELIVERY_ORDER A WITH (NOLOCK) JOIN V_D_DB_PERW_T_STUFF ST WITH (NOLOCK) ON A.ID_TRANSAKSI=ST.ID_TRANSAKSI INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER INNER JOIN GUDANG G WITH (NOLOCK) ON A.GUDANG=G.KODE WHERE BAGIAN='Langganan Perwakilan' AND JENIS_DO='Ada Barang' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")

        'TBMenu.DataSource = SelectCon.execute("select distinct a.ID_TRANSAKSI,a.NO_DO,a.TGL,a.TGL_PENGAKUAN,c.NAMA,u.NAMA_USER,g.NAMA_GUDANG,a.PEMBAYARAN,a.TERMS,(a.DPP+a.PPN) as TOTAL,A.BATAL,st.STK 
        'from ((((DELIVERY_ORDER a WITH (NOLOCK) join CUSTOMER c WITH (NOLOCK) ON A.KODE_CUSTOMER=c.ID) join USERS u WITH (NOLOCK) on a.CRUSER=u.ID_USER) join GUDANG g WITH (NOLOCK) on a.GUDANG=g.KODE) join 
        '(select distinct ddo.ID_TRANSAKSI,ddo.NO_DO,ddo.QUANTITY,ddo.SATUAN,ddo.PCS,isnull(sum(ds.QUANTITY),0) as Qty_T,isnull(sum(ds.PCS),0) as PCS_T,iif(ddo.PCS-isnull(sum(ds.PCS),0)<=0,1,0) as ST,
        'CAST(CASE WHEN (sum(iif(ddo.PCS-isnull(sum(ds.PCS),0)<=0,1,0)) OVER (PARTITION BY ddo.ID_TRANSAKSI)) = (COUNT(ddo.ID_TRANSAKSI) OVER (PARTITION BY ddo.ID_TRANSAKSI)) THEN 1 ELSE 0 END AS BIT) AS STK
        'from ((DELIVERY_ORDER do WITH (NOLOCK) join DETAIL_DELIVERY_ORDER ddo WITH (NOLOCK) on do.ID_TRANSAKSI=ddo.ID_TRANSAKSI) LEFT JOIN STUFFING s WITH (NOLOCK) on do.ID_TRANSAKSI=s.ID_DO) LEFT JOIN DETAIL_STUFFING ds WITH (NOLOCK) on s.ID_TRANSAKSI=ds.ID_TRANSAKSI and ds.ID_BARANG=ddo.ID_BARANG where do.BAGIAN='Langganan Perwakilan' and do.JENIS_DO='ADA BARANG' and do.PERIODE='" & periode & "'
        'group by ddo.ID_TRANSAKSI,ddo.NO_DO,ddo.ID_BARANG,ddo.ISI,ddo.KOLI,ddo.QUANTITY,ddo.SATUAN,ddo.KONVERSI,ddo.PCS,ddo.HARGA,ddo.DISC,ddo.DISKON_SATUAN) st
        'ON a.ID_TRANSAKSI=st.ID_TRANSAKSI) join LINK_USER_DIVISI lud on a.DIVISI=lud.KODE_DIVISI where a.BAGIAN='Langganan Perwakilan' AND a.JENIS_DO='Ada Barang' AND a.PERIODE='" & periode & "' and lud.ID_USER='" & UserID & "'")

        TBMenu.DataSource = SelectCon.execute("Select distinct a.ID_TRANSAKSI,a.NO_DO,a.TGL,a.TGL_PENGAKUAN,c.NAMA,u.NAMA_USER,g.NAMA_GUDANG,a.PEMBAYARAN,a.TERMS,(a.DPP+a.PPN) As TOTAL,A.BATAL,iif(st.STK=0,'Belum Terpenuhi',iif(st.STK=1,'Terpenuhi Sebagian','Terpenuhi')) as STATUS_DO
        from((((DELIVERY_ORDER a WITH (NOLOCK) join CUSTOMER c With (NOLOCK) On A.KODE_CUSTOMER= c.ID) join USERS u With (NOLOCK) On a.CRUSER=u.ID_USER) join GUDANG g With (NOLOCK) On a.GUDANG=g.KODE) join 
        (select distinct ddo.ID_TRANSAKSI,ddo.NO_DO,ddo.QUANTITY,ddo.SATUAN,ddo.PCS,isnull(sum(ds.QUANTITY),0) as Qty_T,isnull(sum(ds.PCS),0) as PCS_T,iif(ddo.PCS-isnull(sum(ds.PCS),0)<=0,1,0) as ST,
        CAST(IIf((sum(IIf(ddo.PCS - isnull(sum(ds.PCS), 0) <= 0, 1, 0)) OVER (PARTITION BY ddo.ID_TRANSAKSI)) = 0,0,iif((sum(iif(ddo.PCS-isnull(sum(ds.PCS),0)<=0,1,0)) OVER (PARTITION BY ddo.ID_TRANSAKSI)) < (COUNT(ddo.ID_TRANSAKSI) OVER (PARTITION BY ddo.ID_TRANSAKSI)),1,2)) As tinyint) As STK
        from((DELIVERY_ORDER do WITH (NOLOCK) join DETAIL_DELIVERY_ORDER ddo With (NOLOCK) On Do.ID_TRANSAKSI= ddo.ID_TRANSAKSI) LEFT JOIN STUFFING s With (NOLOCK) On Do.ID_TRANSAKSI=s.ID_DO) LEFT JOIN DETAIL_STUFFING ds With (NOLOCK) On s.ID_TRANSAKSI=ds.ID_TRANSAKSI And ds.ID_BARANG=ddo.ID_BARANG where Do.BAGIAN='Langganan Perwakilan' and do.JENIS_DO='ADA BARANG' and do.PERIODE='" & periode & "'
        group by ddo.ID_TRANSAKSI, ddo.NO_DO, ddo.ID_BARANG, ddo.ISI, ddo.KOLI, ddo.QUANTITY, ddo.SATUAN, ddo.KONVERSI, ddo.PCS, ddo.HARGA, ddo.DISC, ddo.DISKON_SATUAN) st
        On a.ID_TRANSAKSI=st.ID_TRANSAKSI) join LINK_USER_DIVISI lud WITH (NOLOCK) on a.DIVISI=lud.KODE_DIVISI where a.BAGIAN='Langganan Perwakilan' AND a.JENIS_DO='Ada Barang' AND a.PERIODE='" & periode & "' and lud.ID_USER='" & UserID & "' order by a.TGL,a.ID_TRANSAKSI")
        Application.DoEvents()
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Delivery Order ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Pengakuan"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tanggal"
        GridView1.Columns(2).Width = 25
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tanggal Pengakuan"
        GridView1.Columns(3).Width = 25
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "Nama Customer"
        GridView1.Columns(4).Width = 75
        GridView1.Columns(5).Caption = "Pembuat"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(6).Caption = "Gudang"
        GridView1.Columns(6).Width = 50
        GridView1.Columns(7).Caption = "Pembayaran"
        GridView1.Columns(7).Width = 20
        GridView1.Columns(8).Caption = "Terms"
        GridView1.Columns(8).Width = 15
        GridView1.Columns(9).Caption = "Total"
        GridView1.Columns(9).Width = 40
        GridView1.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(9).DisplayFormat.FormatString = "n2"
        GridView1.Columns(10).Visible = False
        GridView1.Columns(11).Visible = True
        GridView1.Columns(11).Caption = "Stuffing"
        GridView1.Columns(11).Width = 25
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
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
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Delivery Order Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Delivery Order", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
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
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputDeliveryOrderLanggananPerwakilan.MdiParent = Me.MdiParent
        InputDeliveryOrderLanggananPerwakilan.Show()
        InputDeliveryOrderLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditDeliveryOrderLanggananPerwakilan.MdiParent = Me.MdiParent
                EditDeliveryOrderLanggananPerwakilan.Show()
                EditDeliveryOrderLanggananPerwakilan.Focus()
                EditDeliveryOrderLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditDeliveryOrderLanggananPerwakilan
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

Public Class MenuDOTitipanLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.TGL_PRICE,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND JENIS_DO='Tanpa Barang' AND PERIODE='" & periode & "'  AND C.ID_USER='" & UserID & "'")
        'TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL,A.TGL_PENGAKUAN,B.NAMA,D.NAMA_USER,A.TGL_PRICE,DPP+PPN AS TOTAL,A.BATAL FROM DELIVERY_ORDER A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND JENIS_DO='Tanpa Barang' AND PERIODE='" & periode & "'  AND C.ID_USER='" & UserID & "'")
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
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "DO Titipan Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        HakMenu("Penjualan Langganan", "Perwakilan", "DO Titipan", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.DO_Titipan, GridView1.GetFocusedRow(0))
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputDOTitipanLanggananPerwakilan.MdiParent = Me.MdiParent
        InputDOTitipanLanggananPerwakilan.Show()
        InputDOTitipanLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditDOTitipanLanggananPerwakilan.MdiParent = Me.MdiParent
                EditDOTitipanLanggananPerwakilan.Show()
                EditDOTitipanLanggananPerwakilan.Focus()
                EditDOTitipanLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditDOTitipanLanggananPerwakilan
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

Public Class MenuBonPesananLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_BON,A.TGL,A.TGL_PENGAKUAN,A.NO_DO,A.TGL_PRICE,B.NAMA,D.NAMA_USER,DPP+PPN AS TOTAL,A.BATAL FROM BON_PESANAN A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "'")
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
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
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
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Bon Pesanan Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Bon Pesanan (Titipan)", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Titipan, GridView1.GetFocusedRow(0))
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputBonPesananLanggananPerwakilan.MdiParent = Me.MdiParent
        InputBonPesananLanggananPerwakilan.Show()
        InputBonPesananLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditBonPesananLanggananPerwakilan.MdiParent = Me.MdiParent
                EditBonPesananLanggananPerwakilan.Show()
                EditBonPesananLanggananPerwakilan.Focus()
                EditBonPesananLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditBonPesananLanggananPerwakilan
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

Public Class MenuStuffingLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI,NO_STUFFING,TGL,NO_DO,TGL_DO,NAMA,D.NAMA_USER,A.BATAL FROM STUFFING A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Nota ]"
        GridView1.Columns(0).Caption = "ID. Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Stuffing"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Stuffing"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "No. DO"
        GridView1.Columns(3).Width = 50
        GridView1.Columns(4).Caption = "Tgl. DO"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(5).Caption = "Nama Customer"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Pembuat"
        GridView1.Columns(6).Width = 50
        GridView1.Columns(7).Visible = False
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT URUTAN,B.KODE,NAMA,QUANTITY,SATUAN FROM DETAIL_STUFFING A WITH (NOLOCK) LEFT JOIN BARANG B WITH (NOLOCK) ON A.ID_BARANG=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Kode Barang"
                GridView2.Columns(1).Width = 50
                GridView2.Columns(2).Caption = "Nama Barang"
                GridView2.Columns(2).Width = 150
                GridView2.Columns(3).Caption = "Kuantum"
                GridView2.Columns(3).Width = 40
                GridView2.Columns(4).Caption = "Satuan"
                GridView2.Columns(4).Width = 50
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Stuffing Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Stuffing", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Stuffing, GridView1.GetFocusedRow(0))
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputStuffingLanggananPerwakilan.MdiParent = Me.MdiParent
        InputStuffingLanggananPerwakilan.Show()
        InputStuffingLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditStuffingLanggananPerwakilan.MdiParent = Me.MdiParent
                EditStuffingLanggananPerwakilan.Show()
                EditStuffingLanggananPerwakilan.Focus()
                EditStuffingLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditStuffingLanggananPerwakilan
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.Focus()
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuNotaSJLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT DISTINCT ID_TRANSAKSI,NO_NOTA,TGL,TGL_PENGAKUAN,NO_DO,TGL_DO,B.NAMA,D.NAMA_USER,A.DPP+A.PPN AS TOTAL,A.BATAL FROM NOTA A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        'TBMenu.DataSource = SelectCon.execute("SELECT DISTINCT ID_TRANSAKSI,NO_NOTA,TGL,TGL_PENGAKUAN,NO_DO,TGL_DO,B.NAMA,D.NAMA_USER,A.DPP+A.PPN AS TOTAL,A.BATAL FROM NOTA A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Nota ]"
        GridView1.Columns(0).Caption = "ID. Nota"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Nota"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. Nota"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tgl. Pengakuan"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "No. DO"
        GridView1.Columns(4).Width = 50
        GridView1.Columns(5).Caption = "Tgl. DO"
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
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
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
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Nota / SJ Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Nota / Surat Jalan", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
        BtnCetakBeberapa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        keyPrint = ReportPreview.KeyReport.Nota_SJ
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Nota_SJ, GridView1.GetFocusedRow(0))
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputNotaSJLanggananPerwakilan.MdiParent = Me.MdiParent
        InputNotaSJLanggananPerwakilan.Show()
        InputNotaSJLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditNotaSJLanggananPerwakilan.MdiParent = Me.MdiParent
                EditNotaSJLanggananPerwakilan.Show()
                EditNotaSJLanggananPerwakilan.Focus()
                EditNotaSJLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditNotaSJLanggananPerwakilan
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.Focus()
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuSJLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI,NO_SJ,TGL,NO_NOTA,TGL_NOTA,NAMA,D.NAMA_USER,A.BATAL FROM SURAT_JALAN A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        'TBMenu.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI,NO_SJ,TGL,NO_NOTA,TGL_NOTA,NAMA,D.NAMA_USER,A.BATAL FROM SURAT_JALAN A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID INNER JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON A.DIVISI=C.KODE_DIVISI INNER JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE BAGIAN='Langganan Perwakilan' AND PERIODE='" & periode & "' AND C.ID_USER='" & UserID & "' ORDER BY TGL")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Nota ]"
        GridView1.Columns(0).Caption = "ID. Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. SJ"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tgl. SJ"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "No. Nota"
        GridView1.Columns(3).Width = 50
        GridView1.Columns(4).Caption = "Tgl. Nota"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(5).Caption = "Nama Customer"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Pembuat"
        GridView1.Columns(6).Width = 50
        GridView1.Columns(7).Visible = False
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN,A.ID_BARANG,B.KODE,B.NAMA,A.SATUAN,A.KOLI,A.QUANTITY,A.PCS FROM DETAIL_SURAT_JALAN A WITH (NOLOCK) LEFT JOIN BARANG B WITH (NOLOCK) ON A.ID_BARANG=B.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "ID Barang"
                GridView2.Columns(1).Width = 40
                GridView2.Columns(1).Visible = False
                GridView2.Columns(2).Caption = "Kode Barang"
                GridView2.Columns(2).Width = 50
                GridView2.Columns(3).Caption = "Nama Barang"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Satuan"
                GridView2.Columns(4).Width = 50
                GridView2.Columns(5).Caption = "Koli"
                GridView2.Columns(5).Width = 40
                GridView2.Columns(6).Caption = "Kuantum"
                GridView2.Columns(6).Width = 40
                GridView2.Columns(7).Caption = "Pcs"
                GridView2.Columns(7).Width = 40
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "SJ Tanpa Harga Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Surat Jalan Tanpa Harga", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Surat_Jalan, GridView1.GetFocusedRow(0))
        Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputSJLanggananPusat.MdiParent = Me.MdiParent
        InputSJLanggananPusat.Show()
        InputSJLanggananPusat.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditSJLanggananPusat.MdiParent = Me.MdiParent
                EditSJLanggananPusat.Show()
                EditSJLanggananPusat.Focus()
                EditSJLanggananPusat.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditSJLanggananPusat
                frm.MdiParent = Me.MdiParent
                frm.Show()
                frm.Focus()
                frm.Text = Replace(frm.Text, "Edit", "Lihat")
                frm.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
                frm.Bar2.Visible = False
                frm._Toolbar1_Button1.Enabled = False
            End If
        End If
    End Sub
End Class

Public Class MenuPengirimanLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_PENGIRIMAN,A.TGL,A.TGL_PENGAKUAN,B.NAMA_GUDANG,C.NAMA_USER NAMA_DRIVER, K.NOPOL+' ('+K.TIPE+', '+K.MODEL+')' AS NAMA_KENDARAAN, D.NAMA_USER, A.SUBTOTAL, A.BATAL FROM PENGIRIMAN A WITH (NOLOCK) LEFT JOIN GUDANG B WITH (NOLOCK) ON A.GUDANG=B.KODE LEFT JOIN USERS C WITH (NOLOCK) ON A.DRIVER=C.ID_USER LEFT JOIN KENDARAAN K WITH (NOLOCK) ON A.KENDARAAN=K.KODE_KENDARAAN LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE PERIODE='" & periode & "' AND D.ID_USER='" & UserID & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Pengiriman ]"
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
        GridView1.Columns(4).Caption = "Gudang"
        GridView1.Columns(4).Width = 50
        GridView1.Columns(5).Caption = "Driver"
        GridView1.Columns(5).Width = 30
        GridView1.Columns(6).Caption = "Kendaraan"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Caption = "Pembuat"
        GridView1.Columns(7).Width = 50
        GridView1.Columns(8).Caption = "Total"
        GridView1.Columns(8).Width = 40
        GridView1.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(8).DisplayFormat.FormatString = "n2"
        GridView1.Columns(9).Visible = False
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.ID_NOTA, A.NO_NOTA, B.TGL_PENGAKUAN, B.KODE_APPROVE, C.NAMA, B.DPP+B.PPN TOTAL FROM DETAIL_PENGIRIMAN A WITH (NOLOCK) LEFT JOIN NOTA B WITH (NOLOCK) ON A.ID_NOTA=B.ID_TRANSAKSI LEFT JOIN CUSTOMER C WITH (NOLOCK) ON B.KODE_CUSTOMER=C.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "ID Nota"
                GridView2.Columns(1).Width = 50
                GridView2.Columns(1).Visible = False
                GridView2.Columns(2).Caption = "No. Nota"
                GridView2.Columns(2).Width = 50
                GridView2.Columns(3).Caption = "Tgl. Pengakuan"
                GridView2.Columns(3).Width = 40
                GridView2.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                GridView2.Columns(3).DisplayFormat.FormatString = "dd/MM/yyyy"
                GridView2.Columns(4).Caption = "Kode Customer"
                GridView2.Columns(4).Width = 40
                GridView2.Columns(5).Caption = "Nama Customer"
                GridView2.Columns(5).Width = 100
                GridView2.Columns(6).Caption = "Total Nota"
                GridView2.Columns(6).Width = 70
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Pengiriman Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Pengiriman", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Titipan, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputPengirimanLanggananPerwakilan.MdiParent = Me.MdiParent
        InputPengirimanLanggananPerwakilan.Show()
        InputPengirimanLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditPengirimanLanggananPerwakilan.MdiParent = Me.MdiParent
                EditPengirimanLanggananPerwakilan.Show()
                EditPengirimanLanggananPerwakilan.Focus()
                EditPengirimanLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditPengirimanLanggananPerwakilan
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

Public Class MenuCheckOfficeLanggananPerwakilan
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_CHECK,A.TGL,A.TGL_PENGAKUAN,C.NAMA_USER NAMA_DRIVER, K.NOPOL+' ('+K.TIPE+', '+K.MODEL+')' AS NAMA_KENDARAAN, D.NAMA_USER, A.BATAL FROM CHECK_OFFICE A WITH (NOLOCK) LEFT JOIN USERS C WITH (NOLOCK) ON A.DRIVER=C.ID_USER LEFT JOIN KENDARAAN K WITH (NOLOCK) ON A.KENDARAAN=K.KODE_KENDARAAN LEFT JOIN USERS D WITH (NOLOCK) ON A.CRUSER=D.ID_USER WHERE PERIODE='" & periode & "' AND D.ID_USER='" & UserID & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Check Office ]"
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
        GridView1.Columns(4).Caption = "Driver"
        GridView1.Columns(4).Width = 30
        GridView1.Columns(5).Caption = "Kendaraan"
        GridView1.Columns(5).Width = 75
        GridView1.Columns(6).Caption = "Pembuat"
        GridView1.Columns(6).Width = 50
        GridView1.Columns(7).Visible = False
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("SELECT A.URUTAN, A.ID_PENGIRIMAN, A.NO_PENGIRIMAN, A.ID_NOTA, A.NO_NOTA, B.KODE_APPROVE, C.NAMA, B.DPP+B.PPN TOTAL FROM DETAIL_CHECK_OFFICE A LEFT JOIN NOTA B ON A.ID_NOTA=B.ID_TRANSAKSI LEFT JOIN CUSTOMER C ON B.KODE_CUSTOMER=C.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "'")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "ID Pengiriman"
                GridView2.Columns(1).Width = 50
                GridView2.Columns(1).Visible = False
                GridView2.Columns(2).Caption = "No. Pengiriman"
                GridView2.Columns(2).Width = 50
                GridView2.Columns(3).Caption = "ID Nota"
                GridView2.Columns(3).Width = 50
                GridView2.Columns(3).Visible = False
                GridView2.Columns(4).Caption = "No. Nota"
                GridView2.Columns(4).Width = 50
                GridView2.Columns(5).Caption = "Kode Customer"
                GridView2.Columns(5).Width = 40
                GridView2.Columns(6).Caption = "Nama Customer"
                GridView2.Columns(6).Width = 100
                GridView2.Columns(7).Caption = "Total Nota"
                GridView2.Columns(7).Width = 70
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Check Office Langganan Perwakilan"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("Penjualan Langganan", "Perwakilan", "Check Office", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Titipan, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputCheckOfficeLanggananPerwakilan.MdiParent = Me.MdiParent
        InputCheckOfficeLanggananPerwakilan.Show()
        InputCheckOfficeLanggananPerwakilan.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditCheckOfficeLanggananPerwakilan.MdiParent = Me.MdiParent
                EditCheckOfficeLanggananPerwakilan.Show()
                EditCheckOfficeLanggananPerwakilan.Focus()
                EditCheckOfficeLanggananPerwakilan.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditCheckOfficeLanggananPerwakilan
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