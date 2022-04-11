Public Class FrmGroupUser
    Private MySelectCon As New SelectSQLServer
    Dim dtMaster As DataTable
    Dim dtPembelianLangganan As DataTable
    Dim dtPembelianSuper As DataTable
    Dim dtPenjLanggananPerw As DataTable
    Dim dtPenjLanggananPus As DataTable
    Dim dtPenjSupermarketPerw As DataTable
    Dim dtPenjSupermarketPus As DataTable
    Dim dtPenjLainPerw As DataTable
    Dim dtPenjLainPus As DataTable
    Dim dtPenitipan As DataTable
    Dim dtRetur As DataTable
    Dim dtPersediaan As DataTable
    Dim dtMonitoring As DataTable
    Dim dtDebitKreditNote As DataTable
    Dim dtLaporan As DataTable
    Dim dtSistem As DataTable
    Private _StatusEdit As Boolean = False
    Property StatusEdit As Boolean
        Set(value As Boolean)
            _StatusEdit = value
            If value Then : txtKode.Enabled = False : _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else : txtKode.Enabled = True : _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never : End If
        End Set
        Get
            Return _StatusEdit
        End Get
    End Property

    Private Sub FrmGroupUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler GVMaster.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPembelianLangganan.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPembelianSuper.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanLanggananPerwakilan.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanLanggananPusat.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanSupermarketPerwakilan.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanSupermarketPusat.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanLainPerwakilan.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenjualanLainPusat.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPenitipanBarang.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVRetur.CellValueChanging, AddressOf SetDataTableG
        AddHandler GVPersediaan.CellValueChanging, AddressOf SetDataTableG
        GetData()
    End Sub

    Private Sub SetDataTableG(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        SetDataTable(sender, e)
    End Sub

    Private Sub SetColumnnGrid(ByRef Gridview As DevExpress.XtraGrid.Views.Grid.GridView)
        Gridview.Columns(0).Width = 200
        Gridview.Columns(1).Width = 25
        Gridview.Columns(2).Width = 25
        Gridview.Columns(3).Width = 25
        Gridview.Columns(4).Width = 25
        Gridview.Columns(5).Width = 25
        Gridview.Columns(6).Width = 25
        Gridview.Columns(7).Visible = False
        Gridview.Columns(8).Visible = False

        Gridview.Columns(0).OptionsColumn.AllowFocus = False
        Gridview.Columns(1).OptionsColumn.AllowFocus = True
        Gridview.Columns(2).OptionsColumn.AllowFocus = True
        Gridview.Columns(3).OptionsColumn.AllowFocus = True
        Gridview.Columns(4).OptionsColumn.AllowFocus = True
        Gridview.Columns(5).OptionsColumn.AllowFocus = True
        Gridview.Columns(6).OptionsColumn.AllowFocus = True
        Gridview.OptionsNavigation.EnterMoveNextColumn = True
        Gridview.OptionsNavigation.AutoFocusNewRow = True
        Gridview.BestFitColumns()
    End Sub

    Private Sub _Toolbar1_Button1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles _Toolbar1_Button1.ItemClick
        Simpan()
    End Sub

    Private Sub _Toolbar1_Button3_ItemClick(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.ItemClick
        Me.Close()
    End Sub

    Private Sub GetData()
        Dim Code As String = Nothing
        If StatusEdit Then
            Code = txtKode.Text
            Try : txtNama.Text = SelectCon.execute("SELECT NAMA_GROUP FROM GROUP_USER with (nolock) WHERE ID_GROUP='" & Code & "'").Rows(0).Item(0)
            Catch : End Try
        Else : Code = "Default" : End If

        Dim dtHeader As DataTable
        dtHeader = MySelectCon.execute("SELECT A.GROUP_HEADER,ISNULL(B.HAK_GH,A.HAK_GH) AS HAK_GH,A.HEADER,ISNULL(B.HAK_H,A.HAK_H) AS HAK_H FROM (SELECT DISTINCT GROUP_HEADER,HAK_GH,HEADER,HAK_H FROM HAK_USER WITH (NOLOCK) WHERE ID_GROUP='Default') AS A LEFT JOIN (SELECT DISTINCT GROUP_HEADER,HAK_GH,HEADER,HAK_H FROM HAK_USER WITH (NOLOCK) WHERE ID_GROUP='" & Code & "') AS B ON A.GROUP_HEADER=B.GROUP_HEADER AND A.HEADER=B.HEADER")
        Dim dtAll As DataTable
        dtAll = MySelectCon.execute("SELECT ISNULL(B.ITEM,A.ITEM) AS ITEM ,ISNULL(B.LIHAT,A.LIHAT) AS LIHAT,ISNULL(B.BARU,A.BARU) AS BARU,ISNULL(B.EDIT,A.EDIT) AS EDIT,ISNULL(B.BATAL,A.BATAL) AS BATAL,ISNULL(B.HAPUS,A.HAPUS) AS HAPUS,ISNULL(B.CETAK,A.CETAK) AS CETAK,A.HEADER,A.GROUP_HEADER  FROM (SELECT ITEM,LIHAT,BARU,EDIT,BATAL,HAPUS,CETAK,HEADER,GROUP_HEADER FROM HAK_USER WITH (NOLOCK) WHERE ID_GROUP='Default') AS A LEFT JOIN (SELECT ITEM,LIHAT,BARU,EDIT,BATAL,HAPUS,CETAK,HEADER,GROUP_HEADER FROM HAK_USER WITH (NOLOCK) WHERE ID_GROUP='" & Code & "') AS B ON A.GROUP_HEADER=B.GROUP_HEADER AND A.HEADER=B.HEADER AND A.ITEM=B.ITEM ORDER BY A.GROUP_HEADER")
        'Master
        Try
            If dtHeader.Select("HEADER='Master'")(0).Item(3) Then : CekMaster.Checked = True : TBMaster.Enabled = True
            Else : CekMaster.Checked = False : TBMaster.Enabled = False : End If
            dtMaster = dtAll.Select("HEADER='Master'").CopyToDataTable
            TBMaster.DataSource = dtMaster
            TBMaster.Refresh()
            SetColumnnGrid(GVMaster)
        Catch : End Try
        'Pembelian
        Try
            If dtHeader.Select("GROUP_HEADER='Pembelian'")(0).Item(1) Then : CekPembelian.Checked = True : SCPembelian.Enabled = True
            Else : CekPembelian.Checked = False : SCPembelian.Enabled = False : End If
            If dtHeader.Select("GROUP_HEADER='Pembelian' AND HEADER='Langganan'")(0).Item(3) Then
                CekPembelianLangganan.Checked = True : TBPembelianLangganan.Enabled = True
            Else : CekPembelianLangganan.Checked = False : TBPembelianLangganan.Enabled = False : End If
            dtPembelianLangganan = dtAll.Select("GROUP_HEADER='Pembelian' AND HEADER='Langganan'").CopyToDataTable
            TBPembelianLangganan.DataSource = dtPembelianLangganan
            TBPembelianLangganan.Refresh()
            SetColumnnGrid(GVPembelianLangganan)
            If dtHeader.Select("GROUP_HEADER='Pembelian' AND HEADER='Supermarket'")(0).Item(3) Then
                CekPembelianSupermarket.Checked = True : TBPembelianSuper.Enabled = True
            Else : CekPembelianSupermarket.Checked = False : TBPembelianSuper.Enabled = False : End If
            dtPembelianSuper = dtAll.Select("GROUP_HEADER='Pembelian' AND HEADER='Supermarket'").CopyToDataTable
            TBPembelianSuper.DataSource = dtPembelianSuper
            TBPembelianSuper.Refresh()
            SetColumnnGrid(GVPembelianSuper)
        Catch : End Try
        'Penjualan Langganan
        Try
            If dtHeader.Select("GROUP_HEADER='Penjualan Langganan'")(0).Item(1) Then
                CekPenjualanLangganan.Checked = True : SCPenjualanLangganan.Enabled = True
            Else : CekPenjualanLangganan.Checked = False : SCPenjualanLangganan.Enabled = False : End If
            If dtHeader.Select("GROUP_HEADER='Penjualan Langganan' AND HEADER='Perwakilan'")(0).Item(3) Then
                CekPenjualanLanggananPerwakilan.Checked = True : TBPenjualanLanggananPerwakilan.Enabled = True
            Else : CekPenjualanLanggananPerwakilan.Checked = False : TBPenjualanLanggananPerwakilan.Enabled = False : End If
            dtPenjLanggananPerw = dtAll.Select("GROUP_HEADER='Penjualan Langganan' AND HEADER='Perwakilan'").CopyToDataTable
            TBPenjualanLanggananPerwakilan.DataSource = dtPenjLanggananPerw
            TBPenjualanLanggananPerwakilan.Refresh()
            SetColumnnGrid(GVPenjualanLanggananPerwakilan)
            If dtHeader.Select("GROUP_HEADER='Penjualan Langganan' AND HEADER='Pusat'")(0).Item(3) Then
                CekPenjualanLanggananPusat.Checked = True : TBPenjualanLanggananPusat.Enabled = True
            Else : CekPenjualanLanggananPusat.Checked = False : TBPenjualanLanggananPusat.Enabled = False : End If
            dtPenjLanggananPus = dtAll.Select("GROUP_HEADER='Penjualan Langganan' AND HEADER='Pusat'").CopyToDataTable
            TBPenjualanLanggananPusat.DataSource = dtPenjLanggananPus
            TBPenjualanLanggananPusat.Refresh()
            SetColumnnGrid(GVPenjualanLanggananPusat)
        Catch : End Try
        'Penjualan Supermarket
        Try
            If dtHeader.Select("GROUP_HEADER='Penjualan Supermarket'")(0).Item(1) Then
                CekPenjualanSupermarket.Checked = True : SCPenjualanSupermarket.Enabled = True
            Else : CekPenjualanSupermarket.Checked = False : SCPenjualanSupermarket.Enabled = False : End If
            If dtHeader.Select("GROUP_HEADER='Penjualan Supermarket' AND HEADER='Perwakilan'")(0).Item(3) Then
                CekPenjualanSupermarketPerwakilan.Checked = True : TBPenjualanSupermarketPerwakilan.Enabled = True
            Else : CekPenjualanSupermarketPerwakilan.Checked = False : TBPenjualanSupermarketPerwakilan.Enabled = False : End If
            dtPenjSupermarketPerw = dtAll.Select("GROUP_HEADER='Penjualan Supermarket' AND HEADER='Perwakilan'").CopyToDataTable
            TBPenjualanSupermarketPerwakilan.DataSource = dtPenjSupermarketPerw
            TBPenjualanSupermarketPerwakilan.Refresh()
            SetColumnnGrid(GVPenjualanSupermarketPerwakilan)
            If dtHeader.Select("GROUP_HEADER='Penjualan Supermarket' AND HEADER='Pusat'")(0).Item(3) Then
                CekPenjualanSupermarketPusat.Checked = True : TBPenjualanSupermarketPusat.Enabled = True
            Else : CekPenjualanSupermarketPusat.Checked = False : TBPenjualanSupermarketPusat.Enabled = False : End If
            dtPenjSupermarketPus = dtAll.Select("GROUP_HEADER='Penjualan Supermarket' AND HEADER='Pusat'").CopyToDataTable
            TBPenjualanSupermarketPusat.DataSource = dtPenjSupermarketPus
            TBPenjualanSupermarketPusat.Refresh()
            SetColumnnGrid(GVPenjualanSupermarketPusat)
        Catch : End Try
        'Penjualan Lain
        Try
            If dtHeader.Select("GROUP_HEADER='Penjualan Lain - lain'")(0).Item(1) Then
                CekPenjualanLain.Checked = True : SCPenjualanLain.Enabled = True
            Else : CekPenjualanLain.Checked = False : SCPenjualanLain.Enabled = False : End If
            If dtHeader.Select("GROUP_HEADER='Penjualan Lain - lain' AND HEADER='Perwakilan'")(0).Item(3) Then
                CekPenjualanLainPerwakilan.Checked = True : TBPenjualanLainPerwakilan.Enabled = True
            Else : CekPenjualanLainPerwakilan.Checked = False : TBPenjualanLainPerwakilan.Enabled = False : End If
            dtPenjLainPerw = dtAll.Select("GROUP_HEADER='Penjualan Lain - lain' AND HEADER='Perwakilan'").CopyToDataTable
            TBPenjualanLainPerwakilan.DataSource = dtPenjLainPerw
            TBPenjualanLainPerwakilan.Refresh()
            SetColumnnGrid(GVPenjualanLainPerwakilan)
            If dtHeader.Select("GROUP_HEADER='Penjualan Lain - lain' AND HEADER='Pusat'")(0).Item(3) Then
                CekPenjualanLainPusat.Checked = True : TBPenjualanLainPusat.Enabled = True
            Else : CekPenjualanLainPusat.Checked = False : TBPenjualanLainPusat.Enabled = False : End If
            dtPenjLainPus = dtAll.Select("GROUP_HEADER='Penjualan Lain - lain' AND HEADER='Pusat'").CopyToDataTable
            TBPenjualanLainPusat.DataSource = dtPenjLainPus
            TBPenjualanLainPusat.Refresh()
            SetColumnnGrid(GVPenjualanLainPusat)
        Catch : End Try
        'Penitipan Barang
        Try
            If dtHeader.Select("HEADER='Penitipan Barang'")(0).Item(3) Then
                CekPenitipanBarang.Checked = True : TBPenitipanBarang.Enabled = True
            Else : CekPenitipanBarang.Checked = False : TBPenitipanBarang.Enabled = False : End If
        dtPenitipan = dtAll.Select("HEADER='Penitipan Barang'").CopyToDataTable
        TBPenitipanBarang.DataSource = dtPenitipan
        TBPenitipanBarang.Refresh()
        SetColumnnGrid(GVPenitipanBarang)
        Catch : End Try
        'Retur
        Try
            If dtHeader.Select("HEADER='Retur'")(0).Item(3) Then
                CekRetur.Checked = True : TBRetur.Enabled = True
            Else : CekRetur.Checked = False : TBRetur.Enabled = False : End If
            dtRetur = dtAll.Select("HEADER='Retur'").CopyToDataTable
            TBRetur.DataSource = dtRetur
            TBRetur.Refresh()
            SetColumnnGrid(GVRetur)
        Catch : End Try
        'Persediaan
        Try
            If dtHeader.Select("HEADER='Persediaan'")(0).Item(3) Then
                CekPersediaan.Checked = True : TBPersediaan.Enabled = True
            Else : CekPersediaan.Checked = False : TBPersediaan.Enabled = False : End If
            dtPersediaan = dtAll.Select("HEADER='Persediaan'").CopyToDataTable
            TBPersediaan.DataSource = dtPersediaan
            TBPersediaan.Refresh()
            SetColumnnGrid(GVPersediaan)
        Catch : End Try
        'Monitoring
        Try
            If dtHeader.Select("HEADER='Monitoring'")(0).Item(3) Then
                CekMonitoring.Checked = True : TBMonitoring.Enabled = True
            Else : CekMonitoring.Checked = False : TBMonitoring.Enabled = False : End If
            dtMonitoring = dtAll.Select("HEADER='Monitoring'").CopyToDataTable
            TBMonitoring.DataSource = dtMonitoring
            TBMonitoring.Refresh()
            SetColumnnGrid(GVMonitoring)
        Catch : End Try
        'Kredit Debit Note
        Try
            If dtHeader.Select("HEADER='Kredit Debit Note'")(0).Item(3) Then
                CekDebitKreditNote.Checked = True : TBDebitKreditNote.Enabled = True
            Else : CekDebitKreditNote.Checked = False : TBDebitKreditNote.Enabled = False : End If
            dtDebitKreditNote = dtAll.Select("HEADER='Kredit Debit Note'").CopyToDataTable
            TBDebitKreditNote.DataSource = dtDebitKreditNote
            TBDebitKreditNote.Refresh()
            SetColumnnGrid(GVDebitKreditNote)
        Catch : End Try
        'Laporan
        Try
            If dtHeader.Select("HEADER='Laporan'")(0).Item(3) Then
                CekLaporan.Checked = True : TBLaporan.Enabled = True
            Else : CekLaporan.Checked = False : TBLaporan.Enabled = False : End If
            dtLaporan = dtAll.Select("HEADER='Laporan'").CopyToDataTable
            TBLaporan.DataSource = dtLaporan
            TBLaporan.Refresh()
            SetColumnnGrid(GVLaporan)
            'GVLaporan.Columns(2).Visible = False
            'GVLaporan.Columns(3).Visible = False
            'GVLaporan.Columns(4).Visible = False
            'GVLaporan.Columns(5).Visible = False
            'GVLaporan.Columns(6).Visible = False
            'GVLaporan.Columns(7).Visible = False
            'GVLaporan.Columns(8).Visible = False
        Catch : End Try
        'Sistem
        Try
            If dtHeader.Select("HEADER='Sistem'")(0).Item(3) Then
                CekSistem.Checked = True : TBSistem.Enabled = True
            Else : CekSistem.Checked = False : TBSistem.Enabled = False : End If
            dtSistem = dtAll.Select("HEADER='Sistem'").CopyToDataTable
            TBSistem.DataSource = dtSistem
            TBSistem.Refresh()
            SetColumnnGrid(GVSistem)
        Catch : End Try
    End Sub

    Private Sub Batal()
        Call GetData()
        txtKode.Text = ""
        txtNama.Text = ""
        txtKode.Focus()
    End Sub

    Private Sub _Toolbar1_Button2_ItemClick(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button2.ItemClick
        Call Batal()
    End Sub

    Protected Sub Simpan()
        GVDebitKreditNote.CloseEditor()
        GVLaporan.CloseEditor()
        GVMaster.CloseEditor()
        GVMonitoring.CloseEditor()
        GVPembelianLangganan.CloseEditor()
        GVPembelianSuper.CloseEditor()
        GVPenitipanBarang.CloseEditor()
        GVPenjualanLainPerwakilan.CloseEditor()
        GVPenjualanLainPusat.CloseEditor()
        GVPenjualanLanggananPerwakilan.CloseEditor()
        GVPenjualanLanggananPusat.CloseEditor()
        GVPenjualanSupermarketPerwakilan.CloseEditor()
        GVPenjualanSupermarketPusat.CloseEditor()
        GVPersediaan.CloseEditor()
        GVRetur.CloseEditor()
        GVSistem.CloseEditor()

        If Empty({txtKode, txtNama}) Then Exit Sub
        If QuestionInput() = False Then Exit Sub

        If StatusEdit = False Then
            Using dt As DataTable = SelectCon.execute("SELECT * FROM GROUP_USER WITH (NOLOCK) WHERE ID_GROUP='" & txtKode.Text & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("Kode Group User Sudah Pernah Dipakai Untuk Group : " & dt.Rows(0).Item("NAMA_GROUP") & " !")
                    Exit Sub
                End If
            End Using
        End If

        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If StatusEdit Then
                If SQLServer.UpdateHeader("ID_GROUP,NAMA_GROUP,MDUSER,MDTIME", {txtKode, txtNama, UserID, ToSyntax("CURRENT_TIMESTAMP")}, "GROUP_USER", "ID_GROUP='" & txtKode.Text & "'") = False Then Exit Sub
                If SQLServer.Delete("HAK_USER", "ID_GROUP='" & txtKode.Text & "'") = False Then Exit Sub
            Else : If SQLServer.InsertHeader({txtKode, txtNama, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL")}, "GROUP_USER") = False Then Exit Sub
            End If
            'Detail
            If SQLServer.InsertDetail(dtMaster, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekMaster.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPembelianLangganan, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPembelian.Checked.ToString), "HEADER", ToObject(CekPembelianLangganan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPembelianSuper, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPembelian.Checked.ToString), "HEADER", ToObject(CekPembelianSupermarket.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjLanggananPerw, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanLangganan.Checked.ToString), "HEADER", ToObject(CekPenjualanLanggananPerwakilan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjLanggananPus, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanLangganan.Checked.ToString), "HEADER", ToObject(CekPenjualanLanggananPusat.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjSupermarketPerw, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanSupermarket.Checked.ToString), "HEADER", ToObject(CekPenjualanSupermarketPerwakilan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjSupermarketPus, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanSupermarket.Checked.ToString), "HEADER", ToObject(CekPenjualanSupermarketPusat.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjLainPerw, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanLain.Checked.ToString), "HEADER", ToObject(CekPenjualanLainPerwakilan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenjLainPus, {ToObject(txtKode.Text), "GROUP_HEADER", ToObject(CekPenjualanLain.Checked.ToString), "HEADER", ToObject(CekPenjualanLainPusat.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPenitipan, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekPenitipanBarang.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtRetur, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekRetur.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtPersediaan, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekPersediaan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtMonitoring, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekMonitoring.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtDebitKreditNote, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekDebitKreditNote.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtLaporan, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekLaporan.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            If SQLServer.InsertDetail(dtSistem, {ToObject(txtKode.Text), "GROUP_HEADER", ToSyntax("NULL"), "HEADER", ToObject(CekSistem.Checked.ToString), "ITEM", "LIHAT", "BARU", "EDIT", "BATAL", "HAPUS", "CETAK"}, "HAK_USER") = False Then Exit Sub
            SQLServer.EndTransaction()
        End Using
        Log.Insert(Me, txtKode.Text)
        If StatusEdit Then : Dispose() : Else : Batal() : End If
    End Sub

    Private Sub _Toolbar1_Button5_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles _Toolbar1_Button5.ItemClick
        If QuestionHapus() = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("GROUP_USER", "ID_GROUP='" & txtKode.Text & "'") = False Then Exit Sub
            If SQLServer.Delete("HAK_USER", "ID_GROUP='" & txtKode.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Hapus(Me, txtKode.Text)
            Me.Dispose()
        End Using
    End Sub

    Private Sub txtKode_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtKode.EditValueChanged
        If StatusEdit Then
            GetData()
        End If
    End Sub

    Private Sub SetActive(ByRef Cek As DevExpress.XtraEditors.CheckEdit, ByRef ctl As Control)
        If Cek.Checked Then
            ctl.Enabled = True
        Else : ctl.Enabled = False
        End If
    End Sub
    Private Sub CekMaster_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekMaster.CheckedChanged
        SetActive(sender, TBMaster)
    End Sub
    Private Sub CekPembelian_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPembelian.CheckedChanged
        SetActive(sender, SCPembelian)
    End Sub
    Private Sub CekPembelianLangganan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPembelianLangganan.CheckedChanged
        SetActive(sender, TBPembelianLangganan)
    End Sub
    Private Sub CekPembelianSupermarket_CheckedChanged(sender As Object, e As System.EventArgs) Handles CekPembelianSupermarket.CheckedChanged
        SetActive(sender, TBPembelianSuper)
    End Sub
    Private Sub CekPenjualanLangganan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLangganan.CheckedChanged
        SetActive(sender, SCPenjualanLangganan)
    End Sub
    Private Sub CekPenjualanLanggananPerwakilan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLanggananPerwakilan.CheckedChanged
        SetActive(sender, TBPenjualanLanggananPerwakilan)
    End Sub
    Private Sub CekPenjualanLanggananPusat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLanggananPusat.CheckedChanged
        SetActive(sender, TBPenjualanLanggananPusat)
    End Sub
    Private Sub CekPenjualanSupermarket_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanSupermarket.CheckedChanged
        SetActive(sender, SCPenjualanSupermarket)
    End Sub
    Private Sub CekPenjualanSupermarketPerwakilan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanSupermarketPerwakilan.CheckedChanged
        SetActive(sender, TBPenjualanSupermarketPerwakilan)
    End Sub
    Private Sub CekPenjualanSupermarketPusat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanSupermarketPusat.CheckedChanged
        SetActive(sender, TBPenjualanSupermarketPusat)
    End Sub
    Private Sub CekPenjualanLain_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLain.CheckedChanged
        SetActive(sender, SCPenjualanLain)
    End Sub
    Private Sub CekPenjualanLainPerwakilan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLainPerwakilan.CheckedChanged
        SetActive(sender, TBPenjualanLainPerwakilan)
    End Sub
    Private Sub CekPenjualanLainPusat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenjualanLainPusat.CheckedChanged
        SetActive(sender, TBPenjualanLainPusat)
    End Sub
    Private Sub CekPenitipanBarang_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPenitipanBarang.CheckedChanged
        SetActive(sender, TBPenitipanBarang)
    End Sub
    Private Sub CekRetur_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekRetur.CheckedChanged
        SetActive(sender, TBRetur)
    End Sub
    Private Sub CekMonitoring_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekMonitoring.CheckedChanged
        SetActive(sender, TBMonitoring)
    End Sub
    Private Sub CekPersediaan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekPersediaan.CheckedChanged
        SetActive(sender, TBPersediaan)
    End Sub
    Private Sub CekDebitKreditNote_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekDebitKreditNote.CheckedChanged
        SetActive(sender, TBDebitKreditNote)
    End Sub
    Private Sub CekLaporan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekLaporan.CheckedChanged
        SetActive(sender, TBLaporan)
    End Sub
    Private Sub CekSistem_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CekSistem.CheckedChanged
        SetActive(sender, TBSistem)
    End Sub
End Class

Public Class EditGroupUser
    Inherits FrmGroupUser

    Private Sub EditGroupUser_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        StatusEdit = True
        Text = "Edit Group User"
    End Sub
End Class

Public Class MenuGroupUser
    Inherits FrmMenu

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("select ID_GROUP,NAMA_GROUP FROM GROUP_USER ORDER BY ID_GROUP")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Group User ]"
        GridView1.Columns(0).Caption = "Id"
        GridView1.Columns(0).Width = 50
        GridView1.Columns(1).Caption = "Nama"
        GridView1.Columns(1).Width = 125
    End Sub

    Private Sub MenuKaryawan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Group User"
        AddHandler Me.Activated, AddressOf GetData
        HakMenu("", "Sistem", "Group User", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        FrmGroupUser.MdiParent = Me.MdiParent
        FrmGroupUser.StatusEdit = False
        FrmGroupUser.Show()
        FrmGroupUser.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditGroupUser.MdiParent = Me.MdiParent
                EditGroupUser.Show()
                EditGroupUser.Focus()
                EditGroupUser.txtKode.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub
End Class