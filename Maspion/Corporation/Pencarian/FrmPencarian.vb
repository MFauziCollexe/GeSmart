﻿Public Class FrmPencarian
    Property Key As KeyPencarian
    Property ParamKode As String
    Property ParamSupplier As String
    Property ParamGudang As String
    Property ParamCustomer As String
    Property ParamNumber As Double
    Property ParamDate As DateTime
    Property Bagian As EBagian
    Property ParamDivisi As String

    '================Begin Setting Button================
    Public Enum TypeButton
        None = 0
        Barang = 1
        Customer = 2
        Supplier = 3
        Satuan = 4
        Promo = 5
    End Enum

    Public Sub SetButton(ByVal Button As System.Windows.Forms.ToolStripButton, ByVal SetType As TypeButton)
        Select Case SetType
            Case TypeButton.None
                Button.Visible = False
                Button.Enabled = False
            Case TypeButton.Barang
                Button.Text = "Input &Barang"
            Case TypeButton.Customer
                Button.Text = "Input &Customer"
            Case TypeButton.Supplier
                Button.Text = "Input &Supplier"
            Case TypeButton.Satuan
                Button.Text = "Input &Satuan"
            Case TypeButton.Satuan
                Button.Text = "Input &Satuan"
            Case TypeButton.Promo
                Button.Text = "Input &Promo"
        End Select
    End Sub

    Private Sub Button_Click(ByVal Button As System.Windows.Forms.ToolStripButton)
        Select Case Button.Text
            Case "Input &Barang"
                InputBarang.ShowDialog()
            Case "Input &Supplier"
                'InputSupplier.ShowDialog()
            Case "Input &Satuan"
                FrmSatuan.ShowDialog()
                Proses()
            Case "Input &Promo"
                FrmPromo.ShowDialog()
                Proses()
        End Select
    End Sub
    '============================End Setting Button=====================================

    Public Enum KeyPencarian
        Satuan = 1
        Divisi = 2
        Customer_Penjualan = 3
        Barang_Divisi = 4
        Satuan_Barang = 5
        Formula_Diskon = 6
        DO_Titipan = 7
        Gudang = 8
        Supplier_Pembelian = 9
        Customer = 10
        Ekspedisi = 11
        Cabang_Customer = 12
        SBU = 13
        Promo = 14
        Gudang_All = 15
        Karyawan = 16
        AllDO = 17
        BarangAll = 18
        Corporate = 19
        PT = 20
        Kode_Perkiraan = 21
        Kendaraan = 22
        Kendaraan_Pengiriman = 23
        DSR = 24
        CustomerGudang = 25
        GudangCustomer = 26
        Karyawan_driver = 27
    End Enum

    Private Sub Proses()
        On Error GoTo keluar
        Me.Show()
        ProgressPanel1.Visible = True
        TBCari.DataSource = Nothing
        Application.DoEvents()

        Select Case Key
            Case KeyPencarian.Satuan
                TBCari.DataSource = SelectCon.execute("SELECT NAMA FROM SATUAN WITH (NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(NAMA,'')") & " ORDER BY NAMA")
                GridView1.Columns(0).Caption = "Satuan"
                GridView1.Columns(0).Width = 100

            Case KeyPencarian.Divisi
                'Dim filter As String
                'filter = IIf(Bagian = EBagian.Supermarket_Perwakilan Or Bagian = EBagian.Supermarket_Pusat Or Bagian = EBagian.Pembelian Or Bagian = EBagian.None, "", IIf(ParamCustomer = "", "", " AND A.ID='" & ParamCustomer & "' "))
                'TBCari.DataSource = SelectCon.execute("SELECT DISTINCT A.KODE_DIVISI,B.NAMA,B.PENANGGUNG_JAWAB FROM V_SBU_CUST_DIVISI A LEFT JOIN DIVISI B ON A.KODE_DIVISI=B.KODE WHERE " & SmartSearch(TxtCari.Text, "ISNULL(A.KODE_DIVISI,'')+ISNULL(B.NAMA,'')+ISNULL(B.PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1 " & " ORDER BY B.NAMA")

                TBCari.DataSource = SelectCon.execute("SELECT DISTINCT B.KODE,B.NAMA,B.PENANGGUNG_JAWAB FROM DIVISI B WITH (NOLOCK) LEFT JOIN LINK_USER_DIVISI C WITH (NOLOCK) ON B.KODE=C.KODE_DIVISI WHERE " & SmartSearch(TxtCari.Text, "ISNULL(B.KODE,'')+ISNULL(B.NAMA,'')+ISNULL(B.PENANGGUNG_JAWAB,'')") & " AND C.ID_USER='" & UserID & "' AND STATUS_AKTIF=1 " & " ORDER BY B.NAMA")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Penanggung Jawab"
                GridView1.Columns(2).Width = 100

            Case KeyPencarian.Customer_Penjualan
                Dim filter As String = Nothing
                Select Case Bagian
                    Case EBagian.Langganan_Perwakilan, EBagian.Langganan_Pusat
                        filter = " AND B.GROUP_CUSTOMER='Distributor' "
                        'If ParamDivisi IsNot "" Then filter = filter & " AND A.KODE_DIVISI='" & ParamDivisi & "' "
                    Case EBagian.Supermarket_Perwakilan, EBagian.Supermarket_Pusat
                        filter = " AND B.GROUP_CUSTOMER='Supermarket' "
                    Case EBagian.Lain_Perwakilan, EBagian.Lain_Pusat
                        filter = " AND B.GROUP_CUSTOMER='Lain - lain' "
                        'If ParamDivisi IsNot "" Then filter = filter & " AND A.KODE_DIVISI='" & ParamDivisi & "' "
                    Case Else
                        filter = ""
                End Select

                If ParamDivisi IsNot Nothing Then filter = filter & " AND C.KODE_DIVISI='" & ParamDivisi & "' "

                'If Bagian = EBagian.Supermarket_Perwakilan Or Bagian = EBagian.Lain_Pusat Or Bagian = EBagian.None Or Bagian = EBagian.Pembelian Then
                '    TBCari.DataSource = SelectCon.execute("SELECT DISTINCT B.ID,B.KODE_APPROVE,B.NAMA,B.ALAMAT_KANTOR,B.LOKASI_PENGIRIMAN,B.KOTA,B.GROUP_CUSTOMER FROM CUSTOMER B WHERE " & SmartSearch(TxtCari.Text, "ISNULL(B.ID,'')+ISNULL(B.KODE_APPROVE,'')+ISNULL(B.NAMA,'')+ISNULL(B.ALAMAT_KANTOR,'')+ISNULL(B.LOKASI_PENGIRIMAN,'')+ISNULL(B.KOTA,'')+ISNULL(B.GROUP_CUSTOMER,'')") & " AND KODE_APPROVE IS NOT NULL AND STATUS_AKTIF=1 " & filter & " ORDER BY KODE_APPROVE")
                'Else
                '    TBCari.DataSource = SelectCon.execute("SELECT DISTINCT A.ID,B.KODE_APPROVE,B.NAMA,B.ALAMAT_KANTOR,B.LOKASI_PENGIRIMAN,B.KOTA,B.GROUP_CUSTOMER FROM V_SBU_CUST_DIVISI A LEFT JOIN CUSTOMER B ON A.ID=B.ID WHERE " & SmartSearch(TxtCari.Text, "ISNULL(A.ID,'')+ISNULL(B.KODE_APPROVE,'')+ISNULL(B.NAMA,'')+ISNULL(B.ALAMAT_KANTOR,'')+ISNULL(B.LOKASI_PENGIRIMAN,'')+ISNULL(B.KOTA,'')+ISNULL(B.GROUP_CUSTOMER,'')") & " AND KODE_APPROVE IS NOT NULL AND STATUS_AKTIF=1 " & filter & " ORDER BY KODE_APPROVE")
                'End If

                TBCari.DataSource = SelectCon.execute("SELECT DISTINCT B.ID,B.KODE_APPROVE,B.NAMA,B.ALAMAT_KANTOR,B.LOKASI_PENGIRIMAN,B.KOTA,B.GROUP_CUSTOMER FROM CUSTOMER B WITH (NOLOCK) LEFT JOIN (LINK_SBU_DIVISI C INNER JOIN LINK_PT_SBU D ON C.KODE_SBU=D.KODE_SBU) ON D.KODE_PT=B.KODE_PT WHERE " & SmartSearch(TxtCari.Text, "ISNULL(B.ID,'')+ISNULL(B.KODE_APPROVE,'')+ISNULL(B.NAMA,'')+ISNULL(B.ALAMAT_KANTOR,'')+ISNULL(B.LOKASI_PENGIRIMAN,'')+ISNULL(B.KOTA,'')+ISNULL(B.GROUP_CUSTOMER,'')") & " AND KODE_APPROVE IS NOT NULL AND STATUS_AKTIF=1 " & filter & " ORDER BY KODE_APPROVE")
                GridView1.Columns(0).Caption = "ID Customer"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Caption = "Kode Customer"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Nama Customer"
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Caption = "Alamat Kantor"
                GridView1.Columns(3).Width = 125
                GridView1.Columns(4).Caption = "Lokasi Pengiriman"
                GridView1.Columns(4).Width = 125
                GridView1.Columns(5).Caption = "Kota"
                GridView1.Columns(5).Width = 75
                GridView1.Columns(6).Caption = "Group Customer"
                GridView1.Columns(6).Width = 50
                GridView1.Columns(1).BestFit()
                GridView1.Columns(2).BestFit()

            Case KeyPencarian.Barang_Divisi
                TBCari.DataSource = SelectCon.execute("SELECT A.ID,A.KODE,A.NAMA,PROMO = STUFF((SELECT ', ' + PR.NAMA_PROMO FROM LINK_BARANG_PROMO P JOIN PROMO PR ON P.KODE_PROMO=PR.KODE WHERE P.ID_BARANG = A.ID AND '" & ParamSupplier & "' BETWEEN P.TGL_AWAL AND P.TGL_AKHIR FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''),A.NAMA_ALIAS2,A.NAMA_ALIAS3,B.NAMA FROM BARANG A LEFT JOIN GROUP_BARANG B ON A.GROUP_BARANG=B.KODE INNER JOIN LINK_BARANG_DIVISI C ON A.ID=C.ID_BARANG WHERE " & SmartSearch(TxtCari.Text, "ISNULL(A.KODE,'')+ISNULL(A.NAMA,'')+ISNULL(A.NAMA_ALIAS1,'')+ISNULL(A.NAMA_ALIAS2,'')+ISNULL(A.NAMA_ALIAS3,'')+ISNULL(B.NAMA,'')") & " AND STATUS_AKTIF=1 AND C.KODE_DIVISI LIKE '" & ParamKode & "' ORDER BY A.KODE")
                GridView1.Columns(0).Caption = "ID Barang"
                GridView1.Columns(0).Width = 15
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Caption = "Kode Barang"
                GridView1.Columns(1).Width = 25
                GridView1.Columns(2).Caption = "Nama Barang"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Promo"
                GridView1.Columns(3).Width = 50
                GridView1.Columns(4).Caption = "Nama Alias 2"
                GridView1.Columns(4).Width = 50
                GridView1.Columns(5).Caption = "Nama Alias 3"
                GridView1.Columns(5).Width = 50
                GridView1.Columns(6).Caption = "Group Barang"
                GridView1.Columns(6).Width = 75
                GridView1.Columns(6).Visible = False
                GridView1.Columns(1).BestFit()
                GridView1.Columns(2).BestFit()

            Case KeyPencarian.BarangAll
                TBCari.DataSource = SelectCon.execute("SELECT A.ID,A.KODE,A.NAMA,A.NAMA_ALIAS1,A.NAMA_ALIAS2,A.NAMA_ALIAS3,B.NAMA FROM BARANG A WITH (NOLOCK) LEFT JOIN GROUP_BARANG B WITH (NOLOCK) ON A.GROUP_BARANG=B.KODE INNER JOIN LINK_BARANG_DIVISI C ON A.ID=C.ID_BARANG WHERE " & SmartSearch(TxtCari.Text, "ISNULL(A.KODE,'')+ISNULL(A.NAMA,'')+ISNULL(A.NAMA_ALIAS1,'')+ISNULL(A.NAMA_ALIAS2,'')+ISNULL(A.NAMA_ALIAS3,'')+ISNULL(B.NAMA,'')") & " AND STATUS_AKTIF=1 ORDER BY A.KODE")
                GridView1.Columns(0).Caption = "ID Barang"
                GridView1.Columns(0).Width = 15
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Caption = "Kode Barang"
                GridView1.Columns(1).Width = 25
                GridView1.Columns(2).Caption = "Nama Barang"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Nama Alias 1"
                GridView1.Columns(3).Width = 50
                GridView1.Columns(4).Caption = "Nama Alias 2"
                GridView1.Columns(4).Width = 50
                GridView1.Columns(5).Caption = "Nama Alias 3"
                GridView1.Columns(5).Width = 50
                GridView1.Columns(6).Caption = "Group Barang"
                GridView1.Columns(6).Width = 75
                GridView1.Columns(6).Visible = False
                GridView1.Columns(1).BestFit()
                GridView1.Columns(2).BestFit()

            Case KeyPencarian.Formula_Diskon
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA,KETERANGAN FROM DISKON WITH (NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE,'')+ISNULL(NAMA,'')+ISNULL(KETERANGAN,'')") & " AND STATUS_AKTIF=1 ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode Diskon"
                GridView1.Columns(0).Width = 25
                GridView1.Columns(1).Caption = "Nama Diskon"
                GridView1.Columns(1).Width = 150
                GridView1.Columns(2).Caption = "Keterangan"
                GridView1.Columns(2).Width = 150


            Case KeyPencarian.Satuan_Barang
                TBCari.DataSource = SelectCon.execute("SELECT SATUANA1, SATUANA2, ISI,SATUANB1,SATUANB2,P.HARGA_BARU FROM BARANG CROSS APPLY(VALUES (SAT_DIST1, SAT_DIST2, QTY_DIST, SAT_SUPER1, SAT_SUPER2,HARGA_DIST), (SAT_SUPER1, SAT_SUPER2, 1,SAT_SUPER1, SAT_SUPER2,HARGA_SUPER)) AS C (SATUANA1, SATUANA2, ISI,SATUANB1,SATUANB2, HARGA) LEFT JOIN VI_PRICE_LIST P ON BARANG.ID=P.ID_BARANG AND P.JENIS= IIF(C.SATUANA1=BARANG.SAT_DIST1, 'Langganan', 'Supermarket') AND  P.ID='UMUM' WHERE " & SmartSearch(TxtCari.Text, "ISNULL(SATUANA1,'')+ISNULL(SATUANA2,'')+ISNULL(CAST(ISI AS VARCHAR(MAX)),'')+ISNULL(SATUANB1,'')+ISNULL(SATUANB2,'')") & " AND BARANG.ID='" & ParamKode & "' ORDER BY ISI DESC")
                GridView1.Columns(0).Caption = "Satuan Besar"
                GridView1.Columns(0).Width = 75
                GridView1.Columns(1).Caption = "Satuan Besar"
                GridView1.Columns(1).Width = 75
                GridView1.Columns(2).Caption = "Isi"
                GridView1.Columns(2).Width = 15
                GridView1.Columns(3).Caption = "Satuan Kecil"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Satuan Kecil"
                GridView1.Columns(4).Width = 75

            Case KeyPencarian.DO_Titipan
                BtnClosing.Visible = True
                TBCari.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL_PENGAKUAN,C.NAMA,A.TGL_PRICE,B.TITIP,B.TITIP-B.BON FROM DELIVERY_ORDER A WITH (NOLOCK) INNER JOIN V_TITIPAN_TERPENUHI_BON B WITH (NOLOCK) ON A.ID_TRANSAKSI=B.ID_TRANSAKSI INNER JOIN CUSTOMER C WITH (NOLOCK) ON A.KODE_CUSTOMER=C.ID INNER JOIN VI_PAY_KONTAN D WITH (NOLOCK) ON A.ID_TRANSAKSI=D.ID_TRANSAKSI WHERE NOT EXISTS (SELECT * FROM CLOSING_TRANSAKSI WHERE A.ID_TRANSAKSI=ID_TRANSAKSI) AND " & SmartSearch(TxtCari.Text, "ISNULL(A.NO_DO,'')+ISNULL(C.NAMA,'')+ISNULL(A.ALAMAT_KIRIM,'')") & " AND A.BAGIAN='" & ParamKode & "' AND D.STATUS_LUNAS=1")
                GridView1.Columns(0).Caption = "ID DO"
                GridView1.Columns(0).Width = 30
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Caption = "No. DO"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Tanggal DO"
                GridView1.Columns(2).Width = 40
                GridView1.Columns(3).Caption = "Nama Customer"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Tgl. Price List"
                GridView1.Columns(4).Width = 40
                GridView1.Columns(5).Caption = "Total"
                GridView1.Columns(5).Width = 50
                GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(5).DisplayFormat.FormatString = "n2"
                GridView1.Columns(6).Caption = "Sisa"
                GridView1.Columns(6).Width = 50
                GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(6).DisplayFormat.FormatString = "n2"
                GridView1.BestFitColumns()
            Case KeyPencarian.Gudang
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA_GUDANG,ALAMAT,PENANGGUNG_JAWAB FROM GUDANG WITH(NOLOCK) INNER JOIN LINK_USER_GUDANG B ON GUDANG.KODE=B.KODE_GUDANG WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE,'')+ISNULL(NAMA_GUDANG,'')+ISNULL(ALAMAT,'')+ISNULL(PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1 AND B.ID_USER='" & UserID & "' ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama Gudang"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Alamat"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Penanggung Jawab"
                GridView1.Columns(3).Width = 50

            Case KeyPencarian.GudangCustomer
                TBCari.DataSource = SelectCon.execute("SELECT KODE_GUDANG_CUSTOMER,NAMA_GUDANG,ALAMAT_GUDANG,KOTA_GUDANG,PENANGGUNG_JAWAB FROM GUDANG_CUSTOMER WITH(NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE_GUDANG_CUSTOMER,'')+ISNULL(NAMA_GUDANG,'')+ISNULL(ALAMAT_GUDANG,'')+ISNULL(KOTA_GUDANG,'')+ISNULL(PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1 AND KODE_CUSTOMER='" & IDCustomer & "' ORDER BY KODE_GUDANG_CUSTOMER")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama Gudang"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Alamat"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Kota"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Penanggung Jawab"
                GridView1.Columns(4).Width = 50

            Case KeyPencarian.Gudang_All
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA_GUDANG,ALAMAT,PENANGGUNG_JAWAB FROM GUDANG WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE,'')+ISNULL(NAMA_GUDANG,'')+ISNULL(ALAMAT,'')+ISNULL(PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1 ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama Gudang"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Alamat"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Penanggung Jawab"
                GridView1.Columns(3).Width = 50

            Case KeyPencarian.Supplier_Pembelian
                TBCari.DataSource = SelectCon.execute("SELECT ID,NAMA,ALAMAT_KANTOR,KOTA,TELP,CONTACT_PERSON FROM SUPPLIER WHERE " & SmartSearch(TxtCari.Text, "ISNULL(ID,'')+ISNULL(NAMA,'')+ISNULL(ALAMAT_KANTOR,'')+ISNULL(TELP,'')+ISNULL(KOTA,'')+ISNULL(CONTACT_PERSON,'')") & " AND STATUS_AKTIF=1 ORDER BY ID")
                GridView1.Columns(0).Caption = "Kode Supplier"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama Supplier"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Alamat Kantor"
                GridView1.Columns(2).Width = 125
                GridView1.Columns(3).Caption = "Kota"
                GridView1.Columns(3).Width = 125
                GridView1.Columns(4).Caption = "No. Telp."
                GridView1.Columns(4).Width = 75
                GridView1.Columns(5).Caption = "Contact Person"
                GridView1.Columns(5).Width = 50

            Case KeyPencarian.Customer
                TBCari.DataSource = SelectCon.execute("SELECT ID,KODE_APPROVE,NAMA,ALAMAT_KANTOR,LOKASI_PENGIRIMAN,KOTA,GROUP_CUSTOMER FROM CUSTOMER WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE_APPROVE,'')+ISNULL(NAMA,'')+ISNULL(ALAMAT_KANTOR,'')+ISNULL(LOKASI_PENGIRIMAN,'')+ISNULL(KOTA,'')+ISNULL(GROUP_CUSTOMER,'')") & " AND KODE_APPROVE IS NOT NULL AND STATUS_AKTIF=1 ORDER BY KODE_APPROVE")
                GridView1.Columns(0).Caption = "ID Customer"
                GridView1.Columns(0).Width = 40
                GridView1.Columns(1).Caption = "Kode Approve"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Nama Customer"
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Caption = "Alamat Kantor"
                GridView1.Columns(3).Width = 125
                GridView1.Columns(4).Caption = "Lokasi Pengiriman"
                GridView1.Columns(4).Width = 125
                GridView1.Columns(5).Caption = "Kota"
                GridView1.Columns(5).Width = 75
                GridView1.Columns(6).Caption = "Group Customer"
                GridView1.Columns(6).Width = 50

            Case KeyPencarian.CustomerGudang
                TBCari.DataSource = SelectCon.execute("SELECT ID,KODE_APPROVE,NAMA,ALAMAT_KANTOR,LOKASI_PENGIRIMAN,KOTA,GROUP_CUSTOMER FROM CUSTOMER WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE_APPROVE,'')+ISNULL(NAMA,'')+ISNULL(ALAMAT_KANTOR,'')+ISNULL(LOKASI_PENGIRIMAN,'')+ISNULL(KOTA,'')+ISNULL(GROUP_CUSTOMER,'')") & " AND KODE_APPROVE IS NOT NULL AND STATUS_AKTIF=1 ORDER BY KODE_APPROVE")
                GridView1.Columns(0).Caption = "ID Customer"
                GridView1.Columns(0).Width = 40
                GridView1.Columns(1).Caption = "Kode Approve"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Nama Customer"
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Caption = "Alamat Kantor"
                GridView1.Columns(3).Width = 125
                GridView1.Columns(4).Caption = "Lokasi Pengiriman"
                GridView1.Columns(4).Width = 125
                GridView1.Columns(5).Caption = "Kota"
                GridView1.Columns(5).Width = 75
                GridView1.Columns(6).Caption = "Group Customer"
                GridView1.Columns(6).Width = 50

            Case KeyPencarian.Ekspedisi
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA,ALAMAT,PENANGGUNG_JAWAB FROM EKSPEDISI WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE,'')+ISNULL(NAMA,'')+ISNULL(ALAMAT,'')+ISNULL(PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1  ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama Ekspedisi"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Alamat"
                GridView1.Columns(2).Width = 150
                GridView1.Columns(3).Caption = "Penanggung Jawab"
                GridView1.Columns(3).Width = 50

            Case KeyPencarian.Cabang_Customer
                TBCari.DataSource = SelectCon.execute("SELECT KODE_CABANG,NAMA_CABANG,ALAMAT_CABANG FROM DETAIL_CUSTOMER_CABANG WHERE " & SmartSearch(TxtCari.Text, "ISNULL(KODE_CABANG,'')+ISNULL(NAMA_CABANG,'')+ISNULL(ALAMAT_CABANG,'')") & " AND ID='" & ParamCustomer & "' ORDER BY KODE_CABANG")
                GridView1.Columns(0).Caption = "Kode Cabang"
                GridView1.Columns(0).Width = 25
                GridView1.Columns(1).Caption = "Nama Cabang"
                GridView1.Columns(1).Width = 150
                GridView1.Columns(2).Caption = "Alamat Cabang"
                GridView1.Columns(2).Width = 150

            Case KeyPencarian.SBU
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA,PENANGGUNG_JAWAB FROM SBU A WITH (NOLOCK) LEFT JOIN LINK_PT_SBU B WITH (NOLOCK) ON A.KODE=B.KODE_SBU WHERE " & SmartSearch(TxtCari.Text, "ISNULL(A.NAMA,'')+ISNULL(A.KODE,'')+ISNULL(A.PENANGGUNG_JAWAB,'')") & " AND STATUS_AKTIF=1 " & IIf(ParamKode IsNot Nothing, " AND B.KODE_PT='" & ParamKode & "' ", "") & " ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "Penanggung Jawab"
                GridView1.Columns(2).Width = 100

            Case KeyPencarian.Promo
                TBCari.DataSource = SelectCon.execute("SELECT KODE,NAMA_PROMO FROM PROMO WITH (NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(NAMA_PROMO,'')+ISNULL(KODE,'')") & " ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100

            Case KeyPencarian.Karyawan
                Dim filter As String = ""
                If ParamKode <> "" Then filter = " AND JABATAN='SALESMAN' "

                TBCari.DataSource = SelectCon.execute("SELECT ID_USER, NAMA_USER, NIK, KELAMIN FROM USERS WITH (NOLOCK) WHERE STATUS_AKTIF=1 AND ID_USER NOT IN ('000','001') " & filter & " AND " & SmartSearch(TxtCari.Text, "ISNULL(ID_USER,'')+ISNULL(NAMA_USER,'')+ISNULL(NIK,'')+ISNULL(KELAMIN,'')") & " ORDER BY NAMA_USER")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "NIK"
                GridView1.Columns(2).Width = 75
                GridView1.Columns(3).Caption = "Jenis Kelamin"
                GridView1.Columns(3).Width = 75

            Case KeyPencarian.Karyawan_driver
                Dim filter As String = ""
                If ParamKode <> "" Then filter = " AND JABATAN='SOPIR' "

                TBCari.DataSource = SelectCon.execute("SELECT ID_USER, NAMA_USER, NIK, KELAMIN FROM USERS WITH (NOLOCK) WHERE STATUS_AKTIF=1 AND JABATAN='SOPIR' AND ID_USER NOT IN ('000','001') " & filter & " AND " & SmartSearch(TxtCari.Text, "ISNULL(ID_USER,'')+ISNULL(NAMA_USER,'')+ISNULL(NIK,'')+ISNULL(KELAMIN,'')") & " ORDER BY NAMA_USER")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100
                GridView1.Columns(2).Caption = "NIK"
                GridView1.Columns(2).Width = 75
                GridView1.Columns(3).Caption = "Jenis Kelamin"
                GridView1.Columns(3).Width = 75

            Case KeyPencarian.AllDO
                BtnClosing.Visible = True
                'TBCari.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_DO,A.TGL_PENGAKUAN,C.NAMA,A.ALAMAT_KIRIM,A.TGL_PRICE,A.DPP+A.PPN FROM DELIVERY_ORDER A WITH (NOLOCK) LEFT JOIN CUSTOMER C WITH (NOLOCK) ON A.KODE_CUSTOMER=C.ID AND " & SmartSearch(TxtCari.Text, "ISNULL(A.NO_DO,'')+ISNULL(C.NAMA,'')+ISNULL(A.ALAMAT_KIRIM,'')"))
                ''06/04/2022 Mukhammad Fauzi (Modif)
                TBCari.DataSource = SelectCon.execute("select A.ID_TRANSAKSI,A.NO_DO,A.TGL_PENGAKUAN,C.NAMA,A.ALAMAT_KIRIM,A.TGL_PRICE,A.DPP+A.PPN from NOTA INNER JOIN (SELECT ID_TRANSAKSI, ID_PO, TGL_PENGAKUAN, SALES, PEMBAYARAN,ISNULL(KODE_GUDANG_CUSTOMER,'') AS KODE_GUDANG_CUSTOMER ,KODE_CUSTOMER,NO_DO,ALAMAT_KIRIM,TGL_PRICE,DPP,PPN from DELIVERY_ORDER UNION ALL SELECT BON.ID_TRANSAKSI, A.ID_PO, BON.TGL_PENGAKUAN, A.SALES, A.PEMBAYARAN,ISNULL(A.KODE_GUDANG_CUSTOMER,'') AS KODE_GUDANG_CUSTOMER ,A.KODE_CUSTOMER ,A.NO_DO, A.ALAMAT_KIRIM,A.TGL_PRICE ,A.DPP,A.PPN FROM DELIVERY_ORDER A JOIN BON_PESANAN BON ON A.ID_TRANSAKSI=BON.ID_DO ) A ON NOTA.ID_DO=A.ID_TRANSAKSI LEFT JOIN CUSTOMER C WITH (NOLOCK) ON A.KODE_CUSTOMER=C.ID AND " & SmartSearch(TxtCari.Text, "ISNULL(A.NO_DO,'')+ISNULL(C.NAMA,'')+ISNULL(A.ALAMAT_KIRIM,'')"))
                GridView1.Columns(0).Caption = "ID DO"
                GridView1.Columns(0).Width = 30
                GridView1.Columns(1).Caption = "No. DO"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Tanggal DO"
                GridView1.Columns(2).Width = 40
                GridView1.Columns(3).Caption = "Nama Customer"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Alamat Kirim"
                GridView1.Columns(4).Width = 100
                GridView1.Columns(5).Caption = "Tgl. Price List"
                GridView1.Columns(5).Width = 40
                GridView1.Columns(6).Caption = "Total"
                GridView1.Columns(6).Width = 50
                GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns(6).DisplayFormat.FormatString = "n2"

            Case KeyPencarian.Corporate
                TBCari.DataSource = SelectCon.execute("SELECT KODE, NAMA FROM CORPORATION WITH (NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(NAMA,'')+ISNULL(KODE,'')") & " ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100

            Case KeyPencarian.PT
                TBCari.DataSource = SelectCon.execute("SELECT KODE, NAMA FROM PT WITH (NOLOCK) WHERE " & SmartSearch(TxtCari.Text, "ISNULL(NAMA,'')+ISNULL(KODE,'')") & " ORDER BY KODE")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nama"
                GridView1.Columns(1).Width = 100

            Case KeyPencarian.Kode_Perkiraan
                TBCari.DataSource = SelectCon.execute("SELECT KODE_PERKIRAAN, NAMA_PERKIRAAN, JENIS, URUTAN, CASE STATUS_AKTIF WHEN 1 THEN 'Aktif' ELSE 'Tidak Aktif' END AS STATUS_AKTIF, KAS_BANK FROM AR_KODE_PERKIRAAN WITH (NOLOCK) ORDER BY KODE_PERKIRAAN")
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

            Case KeyPencarian.Kendaraan
                TBCari.DataSource = SelectCon.execute("SELECT KODE_KENDARAAN, NOPOL, JENIS, MERK, TIPE, WARNA FROM KENDARAAN WITH (NOLOCK) WHERE STATUS_AKTIF=1 AND " & SmartSearch(TxtCari.Text, "ISNULL(KODE_KENDARAAN,'')+ISNULL(NOPOL,'')+ISNULL(JENIS,'')+ISNULL(MERK,'')+ISNULL(TIPE,'')+ISNULL(WARNA,'')") & " ORDER BY KODE_KENDARAAN")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nopol"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Jenis"
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Caption = "Merk"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Tipe"
                GridView1.Columns(4).Width = 75
                GridView1.Columns(5).Caption = "Warna"
                GridView1.Columns(5).Width = 50

            Case KeyPencarian.Kendaraan_Pengiriman
                TBCari.DataSource = SelectCon.execute("SELECT DISTINCT KODE_KENDARAAN, NOPOL, JENIS, MERK, TIPE, WARNA FROM V_PENGIRIMAN_T_CHECK A JOIN KENDARAAN B ON A.KENDARAAN=B.KODE_KENDARAAN WHERE A.ST=0 AND STATUS_AKTIF=1 AND " & SmartSearch(TxtCari.Text, "ISNULL(KODE_KENDARAAN,'')+ISNULL(NOPOL,'')+ISNULL(JENIS,'')+ISNULL(MERK,'')+ISNULL(TIPE,'')+ISNULL(WARNA,'')") & " ORDER BY KODE_KENDARAAN")
                GridView1.Columns(0).Caption = "Kode"
                GridView1.Columns(0).Width = 50
                GridView1.Columns(1).Caption = "Nopol"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Jenis"
                GridView1.Columns(2).Width = 100
                GridView1.Columns(3).Caption = "Merk"
                GridView1.Columns(3).Width = 75
                GridView1.Columns(4).Caption = "Tipe"
                GridView1.Columns(4).Width = 75
                GridView1.Columns(5).Caption = "Warna"
                GridView1.Columns(5).Width = 50

            Case KeyPencarian.DSR
                TBCari.DataSource = SelectCon.execute("SELECT ID_TRANSAKSI, NO_DSR, TGL, TGL_PENGAKUAN, B.NAMA, C.NAMA_GUDANG FROM AR_DSR A WITH (NOLOCK) LEFT JOIN DIVISI B WITH (NOLOCK) ON A.DIVISI=B.KODE LEFT JOIN GUDANG C ON A.GUDANG=C.KODE WHERE ID_TRANSAKSI IN (SELECT ID_DSR FROM AR_PROSES_JURNAL) and ID_TRANSAKSI NOT IN (select ID_DSR FROM SALES_REPORT_JAKARTA) ORDER BY ID_TRANSAKSI")
                GridView1.Columns(0).Caption = "ID Transaksi"
                GridView1.Columns(0).Width = 25
                GridView1.Columns(1).Caption = "No. DSR"
                GridView1.Columns(1).Width = 50
                GridView1.Columns(2).Caption = "Tgl. Dibuat"
                GridView1.Columns(2).Width = 30
                GridView1.Columns(3).Caption = "Tgl. DSR"
                GridView1.Columns(3).Width = 30
                GridView1.Columns(4).Caption = "Divisi"
                GridView1.Columns(4).Width = 25
                GridView1.Columns(5).Caption = "Gudang"
                GridView1.Columns(5).Width = 40

            Case Else
                MsgBox("Key Tidak Terdaftar !!!")
        End Select

        con.CloseConn()
        GridView1.FindFilterText = TxtCari.Text
        Frame1.Text = "[ " & GridView1.DataRowCount & " " & Replace(Key.ToString, "_", " ") & " ]"
        ProgressPanel1.Visible = False
        If GridView1.RowCount = 0 Then
            TxtCari.Focus()
        Else
            TBCari.Focus()
        End If
        Exit Sub
keluar:
        'MsgBox(Err.Description)
        ResultOfSearch = ""
        Me.Dispose()
    End Sub

    Private Sub FrmPencarian_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Call Proses()
        ResultOfSearch = ""
    End Sub

    Private Sub FrmPencarian_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Application.DoEvents()
        ProgressPanel1.Visible = True
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button1.Click
        On Error Resume Next
        ResultOfSearch = GridView1.GetFocusedDataRow(0)
        Me.Dispose()
    End Sub

    Private Sub _Toolbar1_Button9_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button9.Click
        On Error Resume Next
        ResultOfSearch = ""
        Me.Dispose()
    End Sub

    Private Sub TBCari_DoubleClick(sender As Object, e As System.EventArgs) Handles TBCari.DoubleClick, GridView1.DoubleClick
        On Error Resume Next
        ResultOfSearch = GridView1.GetFocusedDataRow(0)
        Me.Dispose()
    End Sub

    Private Sub TBCari_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TBCari.KeyDown, GridView1.KeyDown
        Dim KeyCode As Integer = e.KeyCode
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F11
                e.Handled = False
                _Toolbar1_Button1_Click(sender, e)
            Case System.Windows.Forms.Keys.F12, System.Windows.Forms.Keys.Escape
                e.Handled = False
                _Toolbar1_Button9_Click(sender, e)
            Case 13
                On Error Resume Next
                ResultOfSearch = GridView1.GetFocusedDataRow(0)
                Me.Dispose()
            Case 65
                TxtCari.Focus()
        End Select
    End Sub

    Private Sub TxtCari_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCari.KeyPress
        Dim KeyAscii As Integer = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Asc("/"), Asc("\"), Asc("?"), Asc("*"), Asc("+"), Asc("-"), Asc(":"), Asc("<"), Asc(">"), Asc("|")
                e.Handled = False
                e.KeyChar = Nothing
            Case Asc("'")
                e.KeyChar = ChrW(Asc("`"))
            Case 13
                Try
                    Call Proses()
                Catch ex As Exception
                End Try
            Case Else
                KeyAscii = 0
        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button_Click(Button1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button_Click(Button2)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button_Click(Button3)
    End Sub

    Private Sub BtnClosing_Click(sender As System.Object, e As System.EventArgs) Handles BtnClosing.Click
        If GridView1.FocusedRowHandle < 0 Then
            MsgBox("Tidak ada data yang terpilih !")
            TxtCari.Text = ""
            GridView1.ClearColumnsFilter()
            GridView1.Columns(1).BestFit()
            FrmPencarian_Activated(sender, e)
            Exit Sub
        End If
        Dim IdTransaksi As String = GridView1.GetFocusedDataRow(0)
        Dim NoTransaksi As String = GridView1.GetFocusedDataRow(1)
        If MsgBox("Apakah anda yakin closing nomor " & GridView1.GetFocusedDataRow(1) & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.InsertHeader({ToObject(IdTransaksi), ToObject(NoTransaksi)}, "CLOSING_TRANSAKSI") = False Then Exit Sub
            Log.Insert(Me, IdTransaksi)
            SQLServer.EndTransaction()
        End Using
    End Sub

    Private Sub TxtCari_EditValueChanged(sender As Object, e As EventArgs) Handles TxtCari.EditValueChanged
        GridView1.FindFilterText = TxtCari.Text
        GridView1.RefreshData()
        Frame1.Text = "[ " & GridView1.DataRowCount & " " & Key.ToString & " ]"
    End Sub


    Private Sub TBCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCari.KeyPress
        Dim KeyAscii As Integer = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Asc("/"), Asc("\"), Asc("?"), Asc("*"), Asc("+"), Asc(":"), Asc("<"), Asc(">"), Asc("|")
                e.Handled = False
                e.KeyChar = Nothing
            Case Asc("'")
                e.KeyChar = ChrW(Asc("`"))
            Case 13
                Try
                    Call Proses()
                Catch ex As Exception
                End Try
            Case Else
                KeyAscii = 0
        End Select
        Proses()
    End Sub
End Class