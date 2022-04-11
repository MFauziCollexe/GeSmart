Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls

Public Class LaporanCheckOffice
    Inherits FrmLaporanBase
    Friend WithEvents GBPilihan As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtTanggalAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtTanggalAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKodeGudang As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtNamaGudang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNamaDriver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKodeDriver As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtNamaKendaraan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKodeKendaraan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaGudang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKodeGudang = New DevExpress.XtraEditors.ButtonEdit()
        Me.BtnView = New DevExpress.XtraEditors.SimpleButton()
        Me.DtTanggalAwal = New DevExpress.XtraEditors.DateEdit()
        Me.DtTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
        Me.GBPilihan = New System.Windows.Forms.GroupBox()
        Me.TxtNamaDriver = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKodeDriver = New DevExpress.XtraEditors.ButtonEdit()
        Me.TxtNamaKendaraan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKodeKendaraan = New DevExpress.XtraEditors.ButtonEdit()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.TxtNamaGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPilihan.SuspendLayout()
        CType(Me.TxtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNamaKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TxtNamaGudang.Location = New System.Drawing.Point(159, 18)
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
        Me.LabelControl2.Location = New System.Drawing.Point(7, 21)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 246
        Me.LabelControl2.Text = "Gudang"
        '
        'TxtKodeGudang
        '
        Me.TxtKodeGudang.Location = New System.Drawing.Point(96, 18)
        Me.TxtKodeGudang.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKodeGudang.Name = "TxtKodeGudang"
        Me.TxtKodeGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeGudang.Properties.ReadOnly = True
        Me.TxtKodeGudang.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeGudang.TabIndex = 245
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(96, 85)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(217, 23)
        Me.BtnView.TabIndex = 244
        Me.BtnView.Text = "View"
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
        Me.GBPilihan.Controls.Add(Me.TxtNamaDriver)
        Me.GBPilihan.Controls.Add(Me.LabelControl3)
        Me.GBPilihan.Controls.Add(Me.TxtKodeDriver)
        Me.GBPilihan.Controls.Add(Me.TxtNamaKendaraan)
        Me.GBPilihan.Controls.Add(Me.LabelControl1)
        Me.GBPilihan.Controls.Add(Me.TxtKodeKendaraan)
        Me.GBPilihan.Controls.Add(Me.TxtNamaGudang)
        Me.GBPilihan.Controls.Add(Me.LabelControl2)
        Me.GBPilihan.Controls.Add(Me.TxtKodeGudang)
        Me.GBPilihan.Controls.Add(Me.BtnView)
        Me.GBPilihan.Location = New System.Drawing.Point(21, 96)
        Me.GBPilihan.Name = "GBPilihan"
        Me.GBPilihan.Size = New System.Drawing.Size(329, 131)
        Me.GBPilihan.TabIndex = 111
        Me.GBPilihan.TabStop = False
        Me.GBPilihan.Text = "FIlter Berdasarkan"
        '
        'TxtNamaDriver
        '
        Me.TxtNamaDriver.Enabled = False
        Me.TxtNamaDriver.EnterMoveNextControl = True
        Me.TxtNamaDriver.Location = New System.Drawing.Point(159, 61)
        Me.TxtNamaDriver.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNamaDriver.Name = "TxtNamaDriver"
        Me.TxtNamaDriver.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TxtNamaDriver.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxtNamaDriver.Properties.ReadOnly = True
        Me.TxtNamaDriver.Size = New System.Drawing.Size(154, 20)
        Me.TxtNamaDriver.TabIndex = 270
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 64)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 269
        Me.LabelControl3.Text = "Driver"
        '
        'TxtKodeDriver
        '
        Me.TxtKodeDriver.Location = New System.Drawing.Point(96, 61)
        Me.TxtKodeDriver.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKodeDriver.Name = "TxtKodeDriver"
        Me.TxtKodeDriver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeDriver.Properties.ReadOnly = True
        Me.TxtKodeDriver.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeDriver.TabIndex = 268
        '
        'TxtNamaKendaraan
        '
        Me.TxtNamaKendaraan.Enabled = False
        Me.TxtNamaKendaraan.EnterMoveNextControl = True
        Me.TxtNamaKendaraan.Location = New System.Drawing.Point(159, 39)
        Me.TxtNamaKendaraan.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNamaKendaraan.Name = "TxtNamaKendaraan"
        Me.TxtNamaKendaraan.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TxtNamaKendaraan.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxtNamaKendaraan.Properties.ReadOnly = True
        Me.TxtNamaKendaraan.Size = New System.Drawing.Size(154, 20)
        Me.TxtNamaKendaraan.TabIndex = 267
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 42)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 266
        Me.LabelControl1.Text = "Kendaraan"
        '
        'TxtKodeKendaraan
        '
        Me.TxtKodeKendaraan.Location = New System.Drawing.Point(96, 39)
        Me.TxtKodeKendaraan.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKodeKendaraan.Name = "TxtKodeKendaraan"
        Me.TxtKodeKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeKendaraan.Properties.ReadOnly = True
        Me.TxtKodeKendaraan.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeKendaraan.TabIndex = 265
        '
        'LaporanCheckOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(941, 580)
        Me.Name = "LaporanCheckOffice"
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.TxtNamaGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPilihan.ResumeLayout(False)
        Me.GBPilihan.PerformLayout()
        CType(Me.TxtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNamaKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub ReportShowPreview()
        Dim MyReport = New XrLaporanCheckOffice
        ' MyReport.lblTitle.Text = "DAILY SALES REPORT"
        Report = MyReport
        Dim filtergudang As String = ""
        Dim filterdriver As String = ""
        Dim filterkendaraan As String = ""
        If TxtKodeGudang.Text <> "" Then
            filtergudang = "and g.gudang = '" & TxtKodeGudang.Text & "'"
        Else
            filtergudang = ""
        End If
        If TxtKodeDriver.Text <> "" Then
            filterdriver = "and a.driver = '" & TxtKodeDriver.Text & "'"
        Else
            filterdriver = ""
        End If
        If TxtKodeKendaraan.Text <> "" Then
            filterkendaraan = "and a.kendaraan = '" & TxtKodeKendaraan.Text & "'"
        Else
            filterkendaraan = ""
        End If
        Dim promo As String = ""
        'If CmbKodePromo.SelectedItem IsNot "" Then
        '    promo = "AND DETAIL_NOTA.ID_BARANG IN (select ID_BARANG from LINK_BARANG_PROMO WHERE CONVERT(DATE,'" & DtTanggalAwal.DateTime & "',103) >= CONVERT(DATE,TGL_AWAL,103) AND CONVERT(DATE,'" & DtTanggalAkhir.DateTime & "',103) <= CONVERT(DATE,TGL_AKHIR,103) AND KODE_PROMO='" & CmbKodePromo.SelectedItem.ToString.Split("-")(0).Trim & "')"
        '    MyReport.lblTitle.Text &= " " & CmbKodePromo.SelectedItem.ToString.Split("-")(1).Trim
        'End If
        Report.DataSource = SelectCon.execute("select a.tgl_pengakuan,a.no_check,c.nopol + ' (' + c.TIPE + ', ' + c.MODEL + ')' KENDARAAN,d.NAMA_USER DRIVER,b.NO_PENGIRIMAN,g.TGL_PENGAKUAN TGL_PENGIRIMAN,b.NO_NOTA,e.TGL_PENGAKUAN tgl_nota,f.NAMA CUSTOMER,e.dpp + e.ppn TOTAL,'OK' [CHECK] from check_office a join detail_check_office b on a.id_transaksi = b.id_transaksi join kendaraan c on c.kode_kendaraan = a.kendaraan join users d on d.ID_USER = a.DRIVER join nota e on e.ID_TRANSAKSI = b.ID_NOTA join customer f on f.KODE_APPROVE = e.KODE_APPROVE and f.ID = e.KODE_CUSTOMER join PENGIRIMAN g on g.ID_TRANSAKSI = b.ID_PENGIRIMAN where a.TGL_PENGAKUAN between '" & Format(DtTanggalAwal.DateTime, "yyyy-MM-dd") & "' and '" & Format(DtTanggalAkhir.DateTime, "yyyy-MM-dd") & "' " & filtergudang & " " & filterkendaraan & " " & filterdriver & " ")

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

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        SetDataTable(sender, e)
    End Sub

    Private Sub LaporanBahan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        InitializeComponent()
        Nama = "Laporan Check Office"
        SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        DtTanggalAwal.DateTime = "1/" & Now.Month.ToString & "/" & Now.Year.ToString
        DtTanggalAkhir.DateTime = Now.Date


    End Sub

    Private Sub RDJenisPembayaran_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DtTanggalAkhir.EditValueChanged, DtTanggalAwal.EditValueChanged
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
        SetData("SELECT NAMA_GUDANG FROM GUDANG WHERE KODE ='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub
    Private Sub TxtKodeGudang_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeGudang.KeyPress
        If CharKeypress(TxtKodeGudang, e) Then TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang)
    End Sub

    Private Sub TxtKodeKendaraan_EditValueChanged(sender As Object, e As EventArgs) Handles TxtKodeKendaraan.EditValueChanged
        SetData("SELECT NOPOL+' ('+TIPE+', '+MODEL+')' AS NAMA FROM KENDARAAN WHERE KODE_KENDARAAN ='" & TxtKodeKendaraan.Text & "'", {TxtNamaKendaraan})

    End Sub

    Private Sub TxtKodeKendaraan_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtKodeKendaraan.ButtonClick
        TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)

    End Sub

    Private Sub TxtKodeKendaraan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeKendaraan.KeyPress
        If CharKeypress(TxtKodeKendaraan, e) Then TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)
    End Sub

    Private Sub TxtKodeDriver_EditValueChanged(sender As Object, e As EventArgs) Handles TxtKodeDriver.EditValueChanged
        SetData("SELECT NAMA_USER FROM USERS WHERE ID_USER ='" & TxtKodeDriver.Text & "'", {TxtNamaDriver})

    End Sub

    Private Sub TxtKodeDriver_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtKodeDriver.ButtonClick
        TxtKodeDriver.Text = Search(FrmPencarian.KeyPencarian.Karyawan)

    End Sub

    Private Sub TxtKodeDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeDriver.KeyPress
        If CharKeypress(TxtKodeDriver, e) Then TxtKodeDriver.Text = Search(FrmPencarian.KeyPencarian.Karyawan)

    End Sub
End Class
