Imports DevExpress.XtraCharts

Public Class SalesReportJakarta
    Inherits FrmLaporanBase
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RDPenjualan As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GBPilihan As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RdPembayaran As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents RDJenisPenjualan As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtTanggalAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtTanggalAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TBDivisi As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RBEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BtnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKodeGudang As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtNamaGudang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaGudang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKodeGudang = New DevExpress.XtraEditors.ButtonEdit()
        Me.BtnView = New DevExpress.XtraEditors.SimpleButton()
        Me.TBDivisi = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RBEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RdPembayaran = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.RDJenisPenjualan = New DevExpress.XtraEditors.RadioGroup()
        Me.RDPenjualan = New DevExpress.XtraEditors.RadioGroup()
        Me.DtTanggalAwal = New DevExpress.XtraEditors.DateEdit()
        Me.DtTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
        Me.GBPilihan = New System.Windows.Forms.GroupBox()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.TxtNamaGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RdPembayaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDJenisPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPilihan.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.DtTanggalAkhir)
        Me.XtraScrollableControl1.Controls.Add(Me.DtTanggalAwal)
        Me.XtraScrollableControl1.Controls.Add(Me.Label1)
        Me.XtraScrollableControl1.Controls.Add(Me.Label2)
        Me.XtraScrollableControl1.Controls.Add(Me.GBPilihan)
        Me.XtraScrollableControl1.Controls.SetChildIndex(Me.GBPilihan, 0)
        Me.XtraScrollableControl1.Controls.SetChildIndex(Me.Label2, 0)
        Me.XtraScrollableControl1.Controls.SetChildIndex(Me.Label1, 0)
        Me.XtraScrollableControl1.Controls.SetChildIndex(Me.DtTanggalAwal, 0)
        Me.XtraScrollableControl1.Controls.SetChildIndex(Me.DtTanggalAkhir, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Tanggal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "-"
        '
        'TxtNamaGudang
        '
        Me.TxtNamaGudang.Enabled = False
        Me.TxtNamaGudang.EnterMoveNextControl = True
        Me.TxtNamaGudang.Location = New System.Drawing.Point(160, 284)
        Me.TxtNamaGudang.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNamaGudang.Name = "TxtNamaGudang"
        Me.TxtNamaGudang.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TxtNamaGudang.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxtNamaGudang.Properties.ReadOnly = True
        Me.TxtNamaGudang.Size = New System.Drawing.Size(154, 20)
        Me.TxtNamaGudang.TabIndex = 247
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 287)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 246
        Me.LabelControl2.Text = "Gudang"
        '
        'TxtKodeGudang
        '
        Me.TxtKodeGudang.Location = New System.Drawing.Point(97, 284)
        Me.TxtKodeGudang.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKodeGudang.Name = "TxtKodeGudang"
        Me.TxtKodeGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeGudang.Properties.ReadOnly = True
        Me.TxtKodeGudang.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeGudang.TabIndex = 245
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(97, 308)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(217, 23)
        Me.BtnView.TabIndex = 244
        Me.BtnView.Text = "View"
        '
        'TBDivisi
        '
        Me.TBDivisi.Location = New System.Drawing.Point(97, 20)
        Me.TBDivisi.MainView = Me.GridView1
        Me.TBDivisi.Name = "TBDivisi"
        Me.TBDivisi.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RBEdit})
        Me.TBDivisi.Size = New System.Drawing.Size(217, 130)
        Me.TBDivisi.TabIndex = 142
        Me.TBDivisi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.TBDivisi
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RBEdit
        '
        Me.RBEdit.AutoHeight = False
        Me.RBEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RBEdit.Name = "RBEdit"
        Me.RBEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 20)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 141
        Me.LabelControl1.Text = "Divisi"
        '
        'RdPembayaran
        '
        Me.RdPembayaran.AutoSizeInLayoutControl = True
        Me.RdPembayaran.EditValue = "Semua"
        Me.RdPembayaran.EnterMoveNextControl = True
        Me.RdPembayaran.Location = New System.Drawing.Point(97, 257)
        Me.RdPembayaran.Margin = New System.Windows.Forms.Padding(1)
        Me.RdPembayaran.Name = "RdPembayaran"
        Me.RdPembayaran.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("All", "All"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Kontan", "Kontan"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Kredit", "Kredit")})
        Me.RdPembayaran.Size = New System.Drawing.Size(217, 25)
        Me.RdPembayaran.TabIndex = 118
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 154)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 118
        Me.LabelControl3.Text = "Jenis Penjualan"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 202)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 121
        Me.LabelControl6.Text = "Penjualan"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 263)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl5.TabIndex = 119
        Me.LabelControl5.Text = "Jenis Pembayaran"
        '
        'RDJenisPenjualan
        '
        Me.RDJenisPenjualan.AutoSizeInLayoutControl = True
        Me.RDJenisPenjualan.EditValue = "Semua"
        Me.RDJenisPenjualan.EnterMoveNextControl = True
        Me.RDJenisPenjualan.Location = New System.Drawing.Point(97, 154)
        Me.RDJenisPenjualan.Margin = New System.Windows.Forms.Padding(1)
        Me.RDJenisPenjualan.Name = "RDJenisPenjualan"
        Me.RDJenisPenjualan.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Pusat", "Pusat")})
        Me.RDJenisPenjualan.Size = New System.Drawing.Size(217, 46)
        Me.RDJenisPenjualan.TabIndex = 120
        '
        'RDPenjualan
        '
        Me.RDPenjualan.AutoSizeInLayoutControl = True
        Me.RDPenjualan.EditValue = "Semua"
        Me.RDPenjualan.EnterMoveNextControl = True
        Me.RDPenjualan.Location = New System.Drawing.Point(97, 202)
        Me.RDPenjualan.Margin = New System.Windows.Forms.Padding(1)
        Me.RDPenjualan.Name = "RDPenjualan"
        Me.RDPenjualan.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Langganan", "Langganan")})
        Me.RDPenjualan.Size = New System.Drawing.Size(217, 53)
        Me.RDPenjualan.TabIndex = 117
        '
        'DtTanggalAwal
        '
        Me.DtTanggalAwal.EditValue = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.DtTanggalAwal.Location = New System.Drawing.Point(93, 58)
        Me.DtTanggalAwal.Name = "DtTanggalAwal"
        Me.DtTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalAwal.Properties.EditValueChangedDelay = 3
        Me.DtTanggalAwal.Size = New System.Drawing.Size(105, 20)
        Me.DtTanggalAwal.TabIndex = 112
        '
        'DtTanggalAkhir
        '
        Me.DtTanggalAkhir.EditValue = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.DtTanggalAkhir.Location = New System.Drawing.Point(216, 59)
        Me.DtTanggalAkhir.Name = "DtTanggalAkhir"
        Me.DtTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalAkhir.Properties.EditValueChangedDelay = 3
        Me.DtTanggalAkhir.Size = New System.Drawing.Size(105, 20)
        Me.DtTanggalAkhir.TabIndex = 113
        '
        'GBPilihan
        '
        Me.GBPilihan.Controls.Add(Me.TxtNamaGudang)
        Me.GBPilihan.Controls.Add(Me.LabelControl2)
        Me.GBPilihan.Controls.Add(Me.TxtKodeGudang)
        Me.GBPilihan.Controls.Add(Me.BtnView)
        Me.GBPilihan.Controls.Add(Me.TBDivisi)
        Me.GBPilihan.Controls.Add(Me.LabelControl1)
        Me.GBPilihan.Controls.Add(Me.RdPembayaran)
        Me.GBPilihan.Controls.Add(Me.LabelControl3)
        Me.GBPilihan.Controls.Add(Me.LabelControl6)
        Me.GBPilihan.Controls.Add(Me.LabelControl5)
        Me.GBPilihan.Controls.Add(Me.RDJenisPenjualan)
        Me.GBPilihan.Controls.Add(Me.RDPenjualan)
        Me.GBPilihan.Location = New System.Drawing.Point(21, 96)
        Me.GBPilihan.Name = "GBPilihan"
        Me.GBPilihan.Size = New System.Drawing.Size(329, 369)
        Me.GBPilihan.TabIndex = 111
        Me.GBPilihan.TabStop = False
        Me.GBPilihan.Text = "FIlter Berdasarkan"
        '
        'SalesReportJakarta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(941, 580)
        Me.Name = "SalesReportJakarta"
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.TxtNamaGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RdPembayaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDJenisPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPilihan.ResumeLayout(False)
        Me.GBPilihan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub ReportShowPreview()
        Dim MyReport = New XRSalesReportJakarta
        Report = MyReport

        Dim filter As String = " AND ("
        For Each r As DataRow In dtDivisi.Rows
            If r(2) Then
                If filter <> " AND (" Then
                    filter = filter & " OR "
                End If
                filter = filter & "b.DIVISI='" & r(0) & "' "
            End If
        Next
        filter = filter & ") "
        If filter = " AND () " Then filter = ""

        'Dim promo As String = ""
        'If CmbKodePromo.SelectedItem IsNot "" Then
        '    promo = "AND DETAIL_NOTA.ID_BARANG IN (select ID_BARANG from LINK_BARANG_PROMO WHERE CONVERT(DATE,'" & DtTanggalAwal.DateTime & "',103) >= CONVERT(DATE,TGL_AWAL,103) AND CONVERT(DATE,'" & DtTanggalAkhir.DateTime & "',103) <= CONVERT(DATE,TGL_AKHIR,103) AND KODE_PROMO='" & CmbKodePromo.SelectedItem.ToString.Split("-")(0).Trim & "')"
        '    MyReport.lblTitle.Text &= " " & CmbKodePromo.SelectedItem.ToString.Split("-")(1).Trim
        'End If

        'query lama
        '        Report.DataSource = SelectCon.execute("select f.tgl_kirim,b.tgl_pengakuan tgl_nota,d.nama nama_customer,g.nama nama_divisi,replace(b.no_nota,g.nama,'') no_nota,case when c.PEMBAYARAN = 'KREDIT' and c.BAGIAN like '%Pusat%' then a.NETTO else 0 end as extern,case when c.PEMBAYARAN = 'KREDIT' and c.BAGIAN like '%Perwakilan%' then a.netto else 0 end as INTERN,case when c.PEMBAYARAN = 'Kontan' then a.netto else 0 end as CASH  from SALES_REPORT_JAKARTA_DETAIL a with(nolock) join NOTA B with(nolock) on a.ID_NOTA = b.ID_TRANSAKSI join (
        'select ID_TRANSAKSI,DIVISI,pembayaran,bagian from DELIVERY_ORDER with(nolock) where JENIS_DO = 'Ada Barang'
        'union
        'select A.ID_TRANSAKSI,A.DIVISI,PEMBAYARAN,A.BAGIAN from BON_PESANAN a with(nolock) join DELIVERY_ORDER b with(nolock) on a.ID_DO = b.ID_TRANSAKSI and b.JENIS_DO <> 'Ada Barang') c on c.ID_TRANSAKSI = b.ID_DO join customer d with(nolock) on d.ID = a.ID_CUSTOMER join SALES_REPORT_JAKARTA f with(nolock) on f.ID_TRANSAKSI = a.ID_TRANSAKSI join divisi g with(nolock) on g.KODE = c.divisi  WHERE CONVERT(DATE,F.TGL_KIRIM,103) >= CONVERT(DATE,'" & DtTanggalAwal.DateTime & "',103) AND CONVERT(DATE,F.TGL_KIRIM,103) <= CONVERT(DATE,'" & DtTanggalAkhir.DateTime & "',103)  " &

        Report.DataSource = SelectCon.execute("select b.TGL_DSR_PUSAT,b.tgl_pengakuan tgl_nota,d.nama nama_customer,g.nama nama_divisi,replace(b.no_nota,g.nama,'') no_nota,case when c.PEMBAYARAN = 'KREDIT' and c.BAGIAN like '%Pusat%' then (b.DPP+B.PPN) else 0 end as extern,case when c.PEMBAYARAN = 'KREDIT' and c.BAGIAN like '%Perwakilan%' then (b.DPP+B.PPN) else 0 end as INTERN,case when c.PEMBAYARAN = 'Kontan' then (b.DPP+B.PPN) else 0 end as CASH  from NOTA B with(nolock) join (
select ID_TRANSAKSI,DIVISI,pembayaran,bagian from DELIVERY_ORDER with(nolock) where JENIS_DO = 'Ada Barang'
union
select A.ID_TRANSAKSI,A.DIVISI,PEMBAYARAN,A.BAGIAN from BON_PESANAN a with(nolock) join DELIVERY_ORDER b with(nolock) on a.ID_DO = b.ID_TRANSAKSI and b.JENIS_DO <> 'Ada Barang') c on c.ID_TRANSAKSI = b.ID_DO join customer d with(nolock) on d.ID = b.KODE_CUSTOMER  join divisi g with(nolock) on g.KODE = c.divisi  WHERE CONVERT(DATE,B.TGL_DSR_PUSAT,103) >= CONVERT(DATE,'" & DtTanggalAwal.DateTime & "',103) AND CONVERT(DATE,B.TGL_DSR_PUSAT,103) <= CONVERT(DATE,'" & DtTanggalAkhir.DateTime & "',103)  " &
    filter &
    IIf(RDJenisPenjualan.SelectedIndex = -1 Or RDJenisPenjualan.SelectedIndex = 0, "", " AND c.BAGIAN LIKE '%" & RDJenisPenjualan.EditValue & "%' ") &
    IIf(RDPenjualan.SelectedIndex = -1 Or RDPenjualan.SelectedIndex = 0, "", " AND c.BAGIAN LIKE '%" & RDPenjualan.EditValue & "%' ") &
    IIf(RdPembayaran.SelectedIndex = -1 Or RdPembayaran.SelectedIndex = 0, "", " AND c.PEMBAYARAN='" & RdPembayaran.EditValue.ToString & "' ") &
    IIf(TxtKodeGudang.Text = "", "", " AND b.GUDANG='" & TxtKodeGudang.Text & "' ") & "")

        Report.DataMember = Nothing
        Report.CreateDocument()
        DocumentViewer1.DocumentSource = Report

        'ChartControl1.DataSource = Report.DataSource
        'ChartControl1.SeriesDataMember = "DIVISI1"
        'ChartControl1.SeriesTemplate.ArgumentDataMember = "TGL_PENGAKUAN"
        'ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"SUBTOTAL"})
        'ChartControl1.SeriesTemplate.View = New SideBySideBarSeriesView
        'ChartControl1.SeriesNameTemplate.BeginText = "DIVISI : "
    End Sub

    Private dtDivisi As New DataTable
    Private Sub loadDivisi()
        InitGrid.Clear()
        InitGrid.AddColumnGrid("Kode", TypeCode.String, 20, False)
        InitGrid.AddColumnGrid("Divisi", TypeCode.String, 25, False)
        InitGrid.AddColumnGrid("Check", TypeCode.Boolean, 20)
        InitGrid.EndInit(TBDivisi, GridView1, dtDivisi)

        LoadData.GetData("SELECT KODE,NAMA,CAST(0 AS BIT) FROM DIVISI WITH (NOLOCK) WHERE STATUS_AKTIF=1 ORDER BY NAMA")
        LoadData.SetDataDetail(dtDivisi, False)
    End Sub
    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        SetDataTable(sender, e)
    End Sub

    Private Sub LaporanBahan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        InitializeComponent()
        Nama = "Sales Report Jakarta"
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        DtTanggalAwal.DateTime = "1/" & Now.Month.ToString & "/" & Now.Year.ToString
        DtTanggalAkhir.DateTime = Now.Date
        loadDivisi()


    End Sub

    Private Sub RDJenisPembayaran_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles RDJenisPenjualan.SelectedIndexChanged, RdPembayaran.SelectedIndexChanged, RDPenjualan.SelectedIndexChanged, DtTanggalAkhir.EditValueChanged, DtTanggalAwal.EditValueChanged
        'ReportShowPreview()
    End Sub

    Private Sub DtTanggalAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles DtTanggalAkhir.EditValueChanging
        'DtTanggalAkhir.DateTime = e.NewValue
    End Sub

    Private Sub DtTanggalAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles DtTanggalAwal.EditValueChanging
        'DtTanggalAwal.DateTime = e.NewValue
    End Sub

    Private Sub BtnView_Click(sender As System.Object, e As System.EventArgs) Handles BtnView.Click
        ReportShowPreview()
    End Sub

    Private Sub TxtKodeGudang_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtKodeGudang.ButtonClick
        TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang)
    End Sub
    Private Sub TxtKodeGudang_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeGudang.EditValueChanged
        SetData("SELECT NAMA_GUDANG FROM GUDANG WITH (NOLOCK) WHERE KODE ='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub
    Private Sub TxtKodeGudang_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeGudang.KeyPress
        If CharKeypress(TxtKodeGudang, e) Then TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang)
    End Sub
End Class
