<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKendaraan
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKendaraan))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
        Me.TxtModel = New DevExpress.XtraEditors.TextEdit()
        Me.TxtJenis = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNopol = New DevExpress.XtraEditors.TextEdit()
        Me.TxtKode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CekStatusAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtMerk = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTipe = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtWarna = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNoRangka = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNoMesin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBahanBakar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBerlaku = New DevExpress.XtraEditors.DateEdit()
        Me.TxtTahun = New DevExpress.XtraEditors.CalcEdit()
        Me.MemoEditLokasi = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNamaDriver = New DevExpress.XtraEditors.TextEdit()
        Me.TxtKodeDriver = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.Toolbar1.SuspendLayout()
        CType(Me.TxtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNopol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStatusAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtWarna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoRangka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoMesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBahanBakar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBerlaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEditLokasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeDriver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'Toolbar1
        '
        Me.Toolbar1.ImageList = Me.ImageList1
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me.ToolStripSeparator1, Me._Toolbar1_Button4})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(452, 25)
        Me.Toolbar1.TabIndex = 5
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.ImageIndex = 0
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(90, 22)
        Me._Toolbar1_Button1.Text = "F2 - Simpan"
        Me._Toolbar1_Button1.ToolTipText = "F2 - Simpan"
        '
        '_Toolbar1_Button2
        '
        Me._Toolbar1_Button2.AutoSize = False
        Me._Toolbar1_Button2.ImageIndex = 1
        Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
        Me._Toolbar1_Button2.Size = New System.Drawing.Size(84, 22)
        Me._Toolbar1_Button2.Text = "F3 - Bersih"
        Me._Toolbar1_Button2.ToolTipText = "F3 - Batal"
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.AutoSize = False
        Me._Toolbar1_Button3.ImageIndex = 2
        Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        Me._Toolbar1_Button3.Size = New System.Drawing.Size(84, 22)
        Me._Toolbar1_Button3.Text = "F4 - Keluar"
        Me._Toolbar1_Button3.ToolTipText = "F4 - Keluar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        '_Toolbar1_Button4
        '
        Me._Toolbar1_Button4.Image = CType(resources.GetObject("_Toolbar1_Button4.Image"), System.Drawing.Image)
        Me._Toolbar1_Button4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
        Me._Toolbar1_Button4.Size = New System.Drawing.Size(84, 22)
        Me._Toolbar1_Button4.Text = "F5 - Hapus"
        '
        'TxtModel
        '
        Me.TxtModel.EnterMoveNextControl = True
        Me.TxtModel.Location = New System.Drawing.Point(128, 152)
        Me.TxtModel.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtModel.Name = "TxtModel"
        Me.TxtModel.Size = New System.Drawing.Size(291, 20)
        Me.TxtModel.TabIndex = 5
        '
        'TxtJenis
        '
        Me.TxtJenis.EnterMoveNextControl = True
        Me.TxtJenis.Location = New System.Drawing.Point(128, 86)
        Me.TxtJenis.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtJenis.Name = "TxtJenis"
        Me.TxtJenis.Size = New System.Drawing.Size(291, 20)
        Me.TxtJenis.TabIndex = 2
        '
        'TxtNopol
        '
        Me.TxtNopol.EnterMoveNextControl = True
        Me.TxtNopol.Location = New System.Drawing.Point(128, 64)
        Me.TxtNopol.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNopol.Name = "TxtNopol"
        Me.TxtNopol.Size = New System.Drawing.Size(100, 20)
        Me.TxtNopol.TabIndex = 1
        '
        'TxtKode
        '
        Me.TxtKode.Enabled = False
        Me.TxtKode.Location = New System.Drawing.Point(128, 41)
        Me.TxtKode.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Properties.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(100, 20)
        Me.TxtKode.TabIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(232, 67)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl13.TabIndex = 109
        Me.LabelControl13.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(423, 89)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl1.TabIndex = 110
        Me.LabelControl1.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(423, 113)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl2.TabIndex = 110
        Me.LabelControl2.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl3.TabIndex = 111
        Me.LabelControl3.Text = "Kode Kendaraan"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 65)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 111
        Me.LabelControl4.Text = "Nopol"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(22, 89)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 111
        Me.LabelControl6.Text = "Jenis"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(22, 154)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 111
        Me.LabelControl7.Text = "Model"
        '
        'CekStatusAktif
        '
        Me.CekStatusAktif.AutoSizeInLayoutControl = True
        Me.CekStatusAktif.Location = New System.Drawing.Point(230, 41)
        Me.CekStatusAktif.Margin = New System.Windows.Forms.Padding(1)
        Me.CekStatusAktif.Name = "CekStatusAktif"
        Me.CekStatusAktif.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekStatusAktif.Properties.Appearance.Options.UseFont = True
        Me.CekStatusAktif.Properties.Caption = "Status Aktif"
        Me.CekStatusAktif.Size = New System.Drawing.Size(90, 19)
        Me.CekStatusAktif.TabIndex = 99
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 113
        Me.LabelControl5.Text = "Merk"
        '
        'TxtMerk
        '
        Me.TxtMerk.EnterMoveNextControl = True
        Me.TxtMerk.Location = New System.Drawing.Point(128, 108)
        Me.TxtMerk.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtMerk.Name = "TxtMerk"
        Me.TxtMerk.Size = New System.Drawing.Size(291, 20)
        Me.TxtMerk.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(22, 133)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl8.TabIndex = 115
        Me.LabelControl8.Text = "Tipe"
        '
        'TxtTipe
        '
        Me.TxtTipe.EnterMoveNextControl = True
        Me.TxtTipe.Location = New System.Drawing.Point(128, 130)
        Me.TxtTipe.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtTipe.Name = "TxtTipe"
        Me.TxtTipe.Size = New System.Drawing.Size(291, 20)
        Me.TxtTipe.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(22, 176)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl9.TabIndex = 117
        Me.LabelControl9.Text = "Tahun"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(22, 198)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 119
        Me.LabelControl10.Text = "Warna"
        '
        'TxtWarna
        '
        Me.TxtWarna.EnterMoveNextControl = True
        Me.TxtWarna.Location = New System.Drawing.Point(128, 196)
        Me.TxtWarna.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.Size = New System.Drawing.Size(291, 20)
        Me.TxtWarna.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(22, 220)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl11.TabIndex = 121
        Me.LabelControl11.Text = "Nomor Rangka"
        '
        'TxtNoRangka
        '
        Me.TxtNoRangka.EnterMoveNextControl = True
        Me.TxtNoRangka.Location = New System.Drawing.Point(128, 218)
        Me.TxtNoRangka.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNoRangka.Name = "TxtNoRangka"
        Me.TxtNoRangka.Size = New System.Drawing.Size(291, 20)
        Me.TxtNoRangka.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(22, 242)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl12.TabIndex = 123
        Me.LabelControl12.Text = "Nomor Mesin"
        '
        'TxtNoMesin
        '
        Me.TxtNoMesin.EnterMoveNextControl = True
        Me.TxtNoMesin.Location = New System.Drawing.Point(128, 240)
        Me.TxtNoMesin.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNoMesin.Name = "TxtNoMesin"
        Me.TxtNoMesin.Size = New System.Drawing.Size(291, 20)
        Me.TxtNoMesin.TabIndex = 9
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(22, 264)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl14.TabIndex = 125
        Me.LabelControl14.Text = "Bahan Bakar"
        '
        'TxtBahanBakar
        '
        Me.TxtBahanBakar.EnterMoveNextControl = True
        Me.TxtBahanBakar.Location = New System.Drawing.Point(128, 262)
        Me.TxtBahanBakar.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtBahanBakar.Name = "TxtBahanBakar"
        Me.TxtBahanBakar.Size = New System.Drawing.Size(291, 20)
        Me.TxtBahanBakar.TabIndex = 10
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(22, 286)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl15.TabIndex = 127
        Me.LabelControl15.Text = "Tgl Berlaku STNK"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(423, 161)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl16.TabIndex = 128
        Me.LabelControl16.Text = "*"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(423, 137)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl17.TabIndex = 129
        Me.LabelControl17.Text = "*"
        '
        'TxtBerlaku
        '
        Me.TxtBerlaku.EditValue = Nothing
        Me.TxtBerlaku.Location = New System.Drawing.Point(128, 284)
        Me.TxtBerlaku.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtBerlaku.Name = "TxtBerlaku"
        Me.TxtBerlaku.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBerlaku.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBerlaku.Properties.DisplayFormat.FormatString = ""
        Me.TxtBerlaku.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBerlaku.Properties.EditFormat.FormatString = ""
        Me.TxtBerlaku.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBerlaku.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtBerlaku.Size = New System.Drawing.Size(100, 20)
        Me.TxtBerlaku.TabIndex = 11
        '
        'TxtTahun
        '
        Me.TxtTahun.Location = New System.Drawing.Point(128, 174)
        Me.TxtTahun.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtTahun.Size = New System.Drawing.Size(100, 20)
        Me.TxtTahun.TabIndex = 6
        '
        'MemoEditLokasi
        '
        Me.MemoEditLokasi.Location = New System.Drawing.Point(128, 341)
        Me.MemoEditLokasi.Name = "MemoEditLokasi"
        Me.MemoEditLokasi.Size = New System.Drawing.Size(291, 96)
        Me.MemoEditLokasi.TabIndex = 130
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(22, 354)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl18.TabIndex = 131
        Me.LabelControl18.Text = "Lokasi Kendaraan"
        '
        'TxtNamaDriver
        '
        Me.TxtNamaDriver.Enabled = False
        Me.TxtNamaDriver.EnterMoveNextControl = True
        Me.TxtNamaDriver.Location = New System.Drawing.Point(230, 310)
        Me.TxtNamaDriver.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNamaDriver.Name = "TxtNamaDriver"
        Me.TxtNamaDriver.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TxtNamaDriver.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxtNamaDriver.Properties.ReadOnly = True
        Me.TxtNamaDriver.Size = New System.Drawing.Size(189, 20)
        Me.TxtNamaDriver.TabIndex = 12250
        '
        'TxtKodeDriver
        '
        Me.TxtKodeDriver.Location = New System.Drawing.Point(128, 310)
        Me.TxtKodeDriver.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtKodeDriver.Name = "TxtKodeDriver"
        Me.TxtKodeDriver.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TxtKodeDriver.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxtKodeDriver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeDriver.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeDriver.TabIndex = 12249
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(22, 313)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(1)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl19.TabIndex = 12248
        Me.LabelControl19.Text = "Driver"
        '
        'FrmKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 438)
        Me.Controls.Add(Me.TxtNamaDriver)
        Me.Controls.Add(Me.TxtKodeDriver)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.MemoEditLokasi)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.TxtBahanBakar)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.TxtNoMesin)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.TxtNoRangka)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.TxtWarna)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.TxtTipe)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.TxtMerk)
        Me.Controls.Add(Me.CekStatusAktif)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.TxtModel)
        Me.Controls.Add(Me.TxtJenis)
        Me.Controls.Add(Me.TxtNopol)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.TxtBerlaku)
        Me.Controls.Add(Me.TxtTahun)
        Me.KeyPreview = True
        Me.Name = "FrmKendaraan"
        Me.Text = "Input Kendaraan"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.TxtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNopol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStatusAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtWarna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoRangka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoMesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBahanBakar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBerlaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEditLokasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNamaDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeDriver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtJenis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNopol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CekStatusAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtMerk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTipe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtWarna As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNoRangka As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNoMesin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBahanBakar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBerlaku As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtTahun As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents MemoEditLokasi As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNamaDriver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtKodeDriver As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
End Class
