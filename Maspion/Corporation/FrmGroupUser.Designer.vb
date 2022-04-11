<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGroupUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGroupUser))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNama = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKode = New DevExpress.XtraEditors.TextEdit()
        Me.TabCntrl = New DevExpress.XtraTab.XtraTabControl()
        Me.Master = New DevExpress.XtraTab.XtraTabPage()
        Me.TBMaster = New DevExpress.XtraGrid.GridControl()
        Me.GVMaster = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekMaster = New DevExpress.XtraEditors.CheckEdit()
        Me.Pembelian = New DevExpress.XtraTab.XtraTabPage()
        Me.CekPembelian = New DevExpress.XtraEditors.CheckEdit()
        Me.SCPembelian = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CekPembelianLangganan = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPembelianLangganan = New DevExpress.XtraGrid.GridControl()
        Me.GVPembelianLangganan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPembelianSupermarket = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPembelianSuper = New DevExpress.XtraGrid.GridControl()
        Me.GVPembelianSuper = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PenjualanLangganan = New DevExpress.XtraTab.XtraTabPage()
        Me.CekPenjualanLangganan = New DevExpress.XtraEditors.CheckEdit()
        Me.SCPenjualanLangganan = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CekPenjualanLanggananPerwakilan = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanLanggananPerwakilan = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanLanggananPerwakilan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPenjualanLanggananPusat = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanLanggananPusat = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanLanggananPusat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PenjualanSupermarket = New DevExpress.XtraTab.XtraTabPage()
        Me.CekPenjualanSupermarket = New DevExpress.XtraEditors.CheckEdit()
        Me.SCPenjualanSupermarket = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CekPenjualanSupermarketPerwakilan = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanSupermarketPerwakilan = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanSupermarketPerwakilan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPenjualanSupermarketPusat = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanSupermarketPusat = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanSupermarketPusat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PenjualanLain = New DevExpress.XtraTab.XtraTabPage()
        Me.CekPenjualanLain = New DevExpress.XtraEditors.CheckEdit()
        Me.SCPenjualanLain = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CekPenjualanLainPerwakilan = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanLainPerwakilan = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanLainPerwakilan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPenjualanLainPusat = New DevExpress.XtraEditors.CheckEdit()
        Me.TBPenjualanLainPusat = New DevExpress.XtraGrid.GridControl()
        Me.GVPenjualanLainPusat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PenitipanBarang = New DevExpress.XtraTab.XtraTabPage()
        Me.TBPenitipanBarang = New DevExpress.XtraGrid.GridControl()
        Me.GVPenitipanBarang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPenitipanBarang = New DevExpress.XtraEditors.CheckEdit()
        Me.Retur = New DevExpress.XtraTab.XtraTabPage()
        Me.TBRetur = New DevExpress.XtraGrid.GridControl()
        Me.GVRetur = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekRetur = New DevExpress.XtraEditors.CheckEdit()
        Me.Persediaan = New DevExpress.XtraTab.XtraTabPage()
        Me.TBPersediaan = New DevExpress.XtraGrid.GridControl()
        Me.GVPersediaan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekPersediaan = New DevExpress.XtraEditors.CheckEdit()
        Me.Monitoring = New DevExpress.XtraTab.XtraTabPage()
        Me.TBMonitoring = New DevExpress.XtraGrid.GridControl()
        Me.GVMonitoring = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekMonitoring = New DevExpress.XtraEditors.CheckEdit()
        Me.KreditDebit = New DevExpress.XtraTab.XtraTabPage()
        Me.TBDebitKreditNote = New DevExpress.XtraGrid.GridControl()
        Me.GVDebitKreditNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekDebitKreditNote = New DevExpress.XtraEditors.CheckEdit()
        Me.Laporan = New DevExpress.XtraTab.XtraTabPage()
        Me.TBLaporan = New DevExpress.XtraGrid.GridControl()
        Me.GVLaporan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekLaporan = New DevExpress.XtraEditors.CheckEdit()
        Me.Sistem = New DevExpress.XtraTab.XtraTabPage()
        Me.TBSistem = New DevExpress.XtraGrid.GridControl()
        Me.GVSistem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CekSistem = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManagerMain = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me._Toolbar1_Button1 = New DevExpress.XtraBars.BarButtonItem()
        Me._Toolbar1_Button2 = New DevExpress.XtraBars.BarButtonItem()
        Me._Toolbar1_Button3 = New DevExpress.XtraBars.BarButtonItem()
        Me._Toolbar1_Button5 = New DevExpress.XtraBars.BarButtonItem()
        Me.LblTitle = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabCntrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCntrl.SuspendLayout()
        Me.Master.SuspendLayout()
        CType(Me.TBMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pembelian.SuspendLayout()
        CType(Me.CekPembelian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCPembelian.SuspendLayout()
        CType(Me.CekPembelianLangganan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPembelianLangganan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPembelianLangganan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPembelianSupermarket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPembelianSuper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPembelianSuper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenjualanLangganan.SuspendLayout()
        CType(Me.CekPenjualanLangganan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCPenjualanLangganan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCPenjualanLangganan.SuspendLayout()
        CType(Me.CekPenjualanLanggananPerwakilan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanLanggananPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanLanggananPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPenjualanLanggananPusat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanLanggananPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanLanggananPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenjualanSupermarket.SuspendLayout()
        CType(Me.CekPenjualanSupermarket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCPenjualanSupermarket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCPenjualanSupermarket.SuspendLayout()
        CType(Me.CekPenjualanSupermarketPerwakilan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanSupermarketPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanSupermarketPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPenjualanSupermarketPusat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanSupermarketPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanSupermarketPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenjualanLain.SuspendLayout()
        CType(Me.CekPenjualanLain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCPenjualanLain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCPenjualanLain.SuspendLayout()
        CType(Me.CekPenjualanLainPerwakilan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanLainPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanLainPerwakilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPenjualanLainPusat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPenjualanLainPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenjualanLainPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenitipanBarang.SuspendLayout()
        CType(Me.TBPenitipanBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPenitipanBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPenitipanBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Retur.SuspendLayout()
        CType(Me.TBRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekRetur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Persediaan.SuspendLayout()
        CType(Me.TBPersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekPersediaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Monitoring.SuspendLayout()
        CType(Me.TBMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekMonitoring.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KreditDebit.SuspendLayout()
        CType(Me.TBDebitKreditNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDebitKreditNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekDebitKreditNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Laporan.SuspendLayout()
        CType(Me.TBLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekLaporan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sistem.SuspendLayout()
        CType(Me.TBSistem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSistem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekSistem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManagerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(14, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Nama Group User"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(134, 55)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtNama.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtNama.Properties.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.txtNama.Properties.MaxLength = 50
        Me.txtNama.Size = New System.Drawing.Size(283, 20)
        Me.txtNama.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Kode Group"
        '
        'txtKode
        '
        Me.txtKode.EnterMoveNextControl = True
        Me.txtKode.Location = New System.Drawing.Point(134, 33)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(1)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtKode.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtKode.Properties.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.txtKode.Properties.MaxLength = 5
        Me.txtKode.Size = New System.Drawing.Size(75, 20)
        Me.txtKode.TabIndex = 0
        '
        'TabCntrl
        '
        Me.TabCntrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCntrl.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabCntrl.Location = New System.Drawing.Point(5, 79)
        Me.TabCntrl.Name = "TabCntrl"
        Me.TabCntrl.SelectedTabPage = Me.Master
        Me.TabCntrl.Size = New System.Drawing.Size(989, 399)
        Me.TabCntrl.TabIndex = 170
        Me.TabCntrl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Master, Me.Pembelian, Me.PenjualanLangganan, Me.PenjualanSupermarket, Me.PenjualanLain, Me.PenitipanBarang, Me.Retur, Me.Persediaan, Me.Monitoring, Me.KreditDebit, Me.Laporan, Me.Sistem})
        '
        'Master
        '
        Me.Master.Controls.Add(Me.TBMaster)
        Me.Master.Controls.Add(Me.CekMaster)
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(987, 374)
        Me.Master.Text = "Master"
        '
        'TBMaster
        '
        Me.TBMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBMaster.Location = New System.Drawing.Point(3, 30)
        Me.TBMaster.MainView = Me.GVMaster
        Me.TBMaster.Name = "TBMaster"
        Me.TBMaster.Size = New System.Drawing.Size(982, 338)
        Me.TBMaster.TabIndex = 162
        Me.TBMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMaster})
        '
        'GVMaster
        '
        Me.GVMaster.GridControl = Me.TBMaster
        Me.GVMaster.Name = "GVMaster"
        Me.GVMaster.OptionsCustomization.AllowColumnMoving = False
        Me.GVMaster.OptionsCustomization.AllowFilter = False
        Me.GVMaster.OptionsCustomization.AllowGroup = False
        Me.GVMaster.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVMaster.OptionsMenu.EnableColumnMenu = False
        Me.GVMaster.OptionsNavigation.AutoFocusNewRow = True
        Me.GVMaster.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVMaster.OptionsView.ShowFooter = True
        Me.GVMaster.OptionsView.ShowGroupPanel = False
        '
        'CekMaster
        '
        Me.CekMaster.AutoSizeInLayoutControl = True
        Me.CekMaster.Location = New System.Drawing.Point(6, 5)
        Me.CekMaster.Name = "CekMaster"
        Me.CekMaster.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekMaster.Properties.Appearance.Options.UseFont = True
        Me.CekMaster.Properties.Caption = "Master"
        Me.CekMaster.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekMaster.Size = New System.Drawing.Size(98, 19)
        Me.CekMaster.TabIndex = 161
        '
        'Pembelian
        '
        Me.Pembelian.Controls.Add(Me.CekPembelian)
        Me.Pembelian.Controls.Add(Me.SCPembelian)
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Size = New System.Drawing.Size(987, 374)
        Me.Pembelian.Text = "Pembelian"
        '
        'CekPembelian
        '
        Me.CekPembelian.AutoSizeInLayoutControl = True
        Me.CekPembelian.Location = New System.Drawing.Point(3, 3)
        Me.CekPembelian.Name = "CekPembelian"
        Me.CekPembelian.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPembelian.Properties.Appearance.Options.UseFont = True
        Me.CekPembelian.Properties.Caption = "Pembelian"
        Me.CekPembelian.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPembelian.Size = New System.Drawing.Size(181, 19)
        Me.CekPembelian.TabIndex = 167
        '
        'SCPembelian
        '
        Me.SCPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCPembelian.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SCPembelian.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SCPembelian.Location = New System.Drawing.Point(0, 28)
        Me.SCPembelian.Name = "SCPembelian"
        Me.SCPembelian.Panel1.Controls.Add(Me.CekPembelianLangganan)
        Me.SCPembelian.Panel1.Controls.Add(Me.TBPembelianLangganan)
        Me.SCPembelian.Panel1.Text = "Panel1"
        Me.SCPembelian.Panel2.Controls.Add(Me.CekPembelianSupermarket)
        Me.SCPembelian.Panel2.Controls.Add(Me.TBPembelianSuper)
        Me.SCPembelian.Panel2.Text = "Panel2"
        Me.SCPembelian.Size = New System.Drawing.Size(984, 346)
        Me.SCPembelian.SplitterPosition = 486
        Me.SCPembelian.TabIndex = 166
        Me.SCPembelian.Text = "SplitContainerControl1"
        '
        'CekPembelianLangganan
        '
        Me.CekPembelianLangganan.AutoSizeInLayoutControl = True
        Me.CekPembelianLangganan.Location = New System.Drawing.Point(3, 3)
        Me.CekPembelianLangganan.Name = "CekPembelianLangganan"
        Me.CekPembelianLangganan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPembelianLangganan.Properties.Appearance.Options.UseFont = True
        Me.CekPembelianLangganan.Properties.Caption = "Langganan"
        Me.CekPembelianLangganan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPembelianLangganan.Size = New System.Drawing.Size(98, 19)
        Me.CekPembelianLangganan.TabIndex = 164
        '
        'TBPembelianLangganan
        '
        Me.TBPembelianLangganan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPembelianLangganan.Location = New System.Drawing.Point(2, 25)
        Me.TBPembelianLangganan.MainView = Me.GVPembelianLangganan
        Me.TBPembelianLangganan.Name = "TBPembelianLangganan"
        Me.TBPembelianLangganan.Size = New System.Drawing.Size(483, 318)
        Me.TBPembelianLangganan.TabIndex = 165
        Me.TBPembelianLangganan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPembelianLangganan})
        '
        'GVPembelianLangganan
        '
        Me.GVPembelianLangganan.GridControl = Me.TBPembelianLangganan
        Me.GVPembelianLangganan.Name = "GVPembelianLangganan"
        Me.GVPembelianLangganan.OptionsCustomization.AllowColumnMoving = False
        Me.GVPembelianLangganan.OptionsCustomization.AllowFilter = False
        Me.GVPembelianLangganan.OptionsCustomization.AllowGroup = False
        Me.GVPembelianLangganan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPembelianLangganan.OptionsMenu.EnableColumnMenu = False
        Me.GVPembelianLangganan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPembelianLangganan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPembelianLangganan.OptionsView.ShowFooter = True
        Me.GVPembelianLangganan.OptionsView.ShowGroupPanel = False
        '
        'CekPembelianSupermarket
        '
        Me.CekPembelianSupermarket.AutoSizeInLayoutControl = True
        Me.CekPembelianSupermarket.Location = New System.Drawing.Point(2, 3)
        Me.CekPembelianSupermarket.Name = "CekPembelianSupermarket"
        Me.CekPembelianSupermarket.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPembelianSupermarket.Properties.Appearance.Options.UseFont = True
        Me.CekPembelianSupermarket.Properties.Caption = "Supermarket"
        Me.CekPembelianSupermarket.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPembelianSupermarket.Size = New System.Drawing.Size(98, 19)
        Me.CekPembelianSupermarket.TabIndex = 167
        '
        'TBPembelianSuper
        '
        Me.TBPembelianSuper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPembelianSuper.Location = New System.Drawing.Point(1, 25)
        Me.TBPembelianSuper.MainView = Me.GVPembelianSuper
        Me.TBPembelianSuper.Name = "TBPembelianSuper"
        Me.TBPembelianSuper.Size = New System.Drawing.Size(482, 318)
        Me.TBPembelianSuper.TabIndex = 168
        Me.TBPembelianSuper.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPembelianSuper})
        '
        'GVPembelianSuper
        '
        Me.GVPembelianSuper.GridControl = Me.TBPembelianSuper
        Me.GVPembelianSuper.Name = "GVPembelianSuper"
        Me.GVPembelianSuper.OptionsCustomization.AllowColumnMoving = False
        Me.GVPembelianSuper.OptionsCustomization.AllowFilter = False
        Me.GVPembelianSuper.OptionsCustomization.AllowGroup = False
        Me.GVPembelianSuper.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPembelianSuper.OptionsMenu.EnableColumnMenu = False
        Me.GVPembelianSuper.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPembelianSuper.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPembelianSuper.OptionsView.ShowFooter = True
        Me.GVPembelianSuper.OptionsView.ShowGroupPanel = False
        '
        'PenjualanLangganan
        '
        Me.PenjualanLangganan.Controls.Add(Me.CekPenjualanLangganan)
        Me.PenjualanLangganan.Controls.Add(Me.SCPenjualanLangganan)
        Me.PenjualanLangganan.Name = "PenjualanLangganan"
        Me.PenjualanLangganan.Size = New System.Drawing.Size(987, 374)
        Me.PenjualanLangganan.Text = "Penjualan Langganan"
        '
        'CekPenjualanLangganan
        '
        Me.CekPenjualanLangganan.AutoSizeInLayoutControl = True
        Me.CekPenjualanLangganan.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanLangganan.Name = "CekPenjualanLangganan"
        Me.CekPenjualanLangganan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLangganan.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLangganan.Properties.Caption = "Penjualan Langganan"
        Me.CekPenjualanLangganan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLangganan.Size = New System.Drawing.Size(181, 19)
        Me.CekPenjualanLangganan.TabIndex = 164
        '
        'SCPenjualanLangganan
        '
        Me.SCPenjualanLangganan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCPenjualanLangganan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SCPenjualanLangganan.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SCPenjualanLangganan.Location = New System.Drawing.Point(0, 28)
        Me.SCPenjualanLangganan.Name = "SCPenjualanLangganan"
        Me.SCPenjualanLangganan.Panel1.Controls.Add(Me.CekPenjualanLanggananPerwakilan)
        Me.SCPenjualanLangganan.Panel1.Controls.Add(Me.TBPenjualanLanggananPerwakilan)
        Me.SCPenjualanLangganan.Panel1.Text = "Panel1"
        Me.SCPenjualanLangganan.Panel2.Controls.Add(Me.CekPenjualanLanggananPusat)
        Me.SCPenjualanLangganan.Panel2.Controls.Add(Me.TBPenjualanLanggananPusat)
        Me.SCPenjualanLangganan.Panel2.Text = "Panel2"
        Me.SCPenjualanLangganan.Size = New System.Drawing.Size(984, 346)
        Me.SCPenjualanLangganan.SplitterPosition = 486
        Me.SCPenjualanLangganan.TabIndex = 167
        Me.SCPenjualanLangganan.Text = "SplitContainerControl2"
        '
        'CekPenjualanLanggananPerwakilan
        '
        Me.CekPenjualanLanggananPerwakilan.AutoSizeInLayoutControl = True
        Me.CekPenjualanLanggananPerwakilan.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanLanggananPerwakilan.Name = "CekPenjualanLanggananPerwakilan"
        Me.CekPenjualanLanggananPerwakilan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLanggananPerwakilan.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLanggananPerwakilan.Properties.Caption = "Perwakilan"
        Me.CekPenjualanLanggananPerwakilan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLanggananPerwakilan.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanLanggananPerwakilan.TabIndex = 164
        '
        'TBPenjualanLanggananPerwakilan
        '
        Me.TBPenjualanLanggananPerwakilan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanLanggananPerwakilan.Location = New System.Drawing.Point(2, 25)
        Me.TBPenjualanLanggananPerwakilan.MainView = Me.GVPenjualanLanggananPerwakilan
        Me.TBPenjualanLanggananPerwakilan.Name = "TBPenjualanLanggananPerwakilan"
        Me.TBPenjualanLanggananPerwakilan.Size = New System.Drawing.Size(483, 318)
        Me.TBPenjualanLanggananPerwakilan.TabIndex = 165
        Me.TBPenjualanLanggananPerwakilan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanLanggananPerwakilan})
        '
        'GVPenjualanLanggananPerwakilan
        '
        Me.GVPenjualanLanggananPerwakilan.GridControl = Me.TBPenjualanLanggananPerwakilan
        Me.GVPenjualanLanggananPerwakilan.Name = "GVPenjualanLanggananPerwakilan"
        Me.GVPenjualanLanggananPerwakilan.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanLanggananPerwakilan.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanLanggananPerwakilan.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanLanggananPerwakilan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanLanggananPerwakilan.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanLanggananPerwakilan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanLanggananPerwakilan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanLanggananPerwakilan.OptionsView.ShowFooter = True
        Me.GVPenjualanLanggananPerwakilan.OptionsView.ShowGroupPanel = False
        '
        'CekPenjualanLanggananPusat
        '
        Me.CekPenjualanLanggananPusat.AutoSizeInLayoutControl = True
        Me.CekPenjualanLanggananPusat.Location = New System.Drawing.Point(2, 3)
        Me.CekPenjualanLanggananPusat.Name = "CekPenjualanLanggananPusat"
        Me.CekPenjualanLanggananPusat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLanggananPusat.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLanggananPusat.Properties.Caption = "Pusat"
        Me.CekPenjualanLanggananPusat.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLanggananPusat.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanLanggananPusat.TabIndex = 167
        '
        'TBPenjualanLanggananPusat
        '
        Me.TBPenjualanLanggananPusat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanLanggananPusat.Location = New System.Drawing.Point(1, 25)
        Me.TBPenjualanLanggananPusat.MainView = Me.GVPenjualanLanggananPusat
        Me.TBPenjualanLanggananPusat.Name = "TBPenjualanLanggananPusat"
        Me.TBPenjualanLanggananPusat.Size = New System.Drawing.Size(482, 318)
        Me.TBPenjualanLanggananPusat.TabIndex = 168
        Me.TBPenjualanLanggananPusat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanLanggananPusat})
        '
        'GVPenjualanLanggananPusat
        '
        Me.GVPenjualanLanggananPusat.GridControl = Me.TBPenjualanLanggananPusat
        Me.GVPenjualanLanggananPusat.Name = "GVPenjualanLanggananPusat"
        Me.GVPenjualanLanggananPusat.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanLanggananPusat.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanLanggananPusat.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanLanggananPusat.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanLanggananPusat.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanLanggananPusat.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanLanggananPusat.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanLanggananPusat.OptionsView.ShowFooter = True
        Me.GVPenjualanLanggananPusat.OptionsView.ShowGroupPanel = False
        '
        'PenjualanSupermarket
        '
        Me.PenjualanSupermarket.Controls.Add(Me.CekPenjualanSupermarket)
        Me.PenjualanSupermarket.Controls.Add(Me.SCPenjualanSupermarket)
        Me.PenjualanSupermarket.Name = "PenjualanSupermarket"
        Me.PenjualanSupermarket.Size = New System.Drawing.Size(987, 374)
        Me.PenjualanSupermarket.Text = "Penjualan Supermarket"
        '
        'CekPenjualanSupermarket
        '
        Me.CekPenjualanSupermarket.AutoSizeInLayoutControl = True
        Me.CekPenjualanSupermarket.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanSupermarket.Name = "CekPenjualanSupermarket"
        Me.CekPenjualanSupermarket.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanSupermarket.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanSupermarket.Properties.Caption = "Penjualan Supermarket"
        Me.CekPenjualanSupermarket.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanSupermarket.Size = New System.Drawing.Size(181, 19)
        Me.CekPenjualanSupermarket.TabIndex = 169
        '
        'SCPenjualanSupermarket
        '
        Me.SCPenjualanSupermarket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCPenjualanSupermarket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SCPenjualanSupermarket.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SCPenjualanSupermarket.Location = New System.Drawing.Point(0, 28)
        Me.SCPenjualanSupermarket.Name = "SCPenjualanSupermarket"
        Me.SCPenjualanSupermarket.Panel1.Controls.Add(Me.CekPenjualanSupermarketPerwakilan)
        Me.SCPenjualanSupermarket.Panel1.Controls.Add(Me.TBPenjualanSupermarketPerwakilan)
        Me.SCPenjualanSupermarket.Panel1.Text = "Panel1"
        Me.SCPenjualanSupermarket.Panel2.Controls.Add(Me.CekPenjualanSupermarketPusat)
        Me.SCPenjualanSupermarket.Panel2.Controls.Add(Me.TBPenjualanSupermarketPusat)
        Me.SCPenjualanSupermarket.Panel2.Text = "Panel2"
        Me.SCPenjualanSupermarket.Size = New System.Drawing.Size(984, 346)
        Me.SCPenjualanSupermarket.SplitterPosition = 486
        Me.SCPenjualanSupermarket.TabIndex = 168
        Me.SCPenjualanSupermarket.Text = "SplitContainerControl3"
        '
        'CekPenjualanSupermarketPerwakilan
        '
        Me.CekPenjualanSupermarketPerwakilan.AutoSizeInLayoutControl = True
        Me.CekPenjualanSupermarketPerwakilan.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanSupermarketPerwakilan.Name = "CekPenjualanSupermarketPerwakilan"
        Me.CekPenjualanSupermarketPerwakilan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanSupermarketPerwakilan.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanSupermarketPerwakilan.Properties.Caption = "Perwakilan"
        Me.CekPenjualanSupermarketPerwakilan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanSupermarketPerwakilan.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanSupermarketPerwakilan.TabIndex = 164
        '
        'TBPenjualanSupermarketPerwakilan
        '
        Me.TBPenjualanSupermarketPerwakilan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanSupermarketPerwakilan.Location = New System.Drawing.Point(2, 25)
        Me.TBPenjualanSupermarketPerwakilan.MainView = Me.GVPenjualanSupermarketPerwakilan
        Me.TBPenjualanSupermarketPerwakilan.Name = "TBPenjualanSupermarketPerwakilan"
        Me.TBPenjualanSupermarketPerwakilan.Size = New System.Drawing.Size(483, 318)
        Me.TBPenjualanSupermarketPerwakilan.TabIndex = 165
        Me.TBPenjualanSupermarketPerwakilan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanSupermarketPerwakilan})
        '
        'GVPenjualanSupermarketPerwakilan
        '
        Me.GVPenjualanSupermarketPerwakilan.GridControl = Me.TBPenjualanSupermarketPerwakilan
        Me.GVPenjualanSupermarketPerwakilan.Name = "GVPenjualanSupermarketPerwakilan"
        Me.GVPenjualanSupermarketPerwakilan.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanSupermarketPerwakilan.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanSupermarketPerwakilan.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanSupermarketPerwakilan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanSupermarketPerwakilan.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanSupermarketPerwakilan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanSupermarketPerwakilan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanSupermarketPerwakilan.OptionsView.ShowFooter = True
        Me.GVPenjualanSupermarketPerwakilan.OptionsView.ShowGroupPanel = False
        '
        'CekPenjualanSupermarketPusat
        '
        Me.CekPenjualanSupermarketPusat.AutoSizeInLayoutControl = True
        Me.CekPenjualanSupermarketPusat.Location = New System.Drawing.Point(2, 3)
        Me.CekPenjualanSupermarketPusat.Name = "CekPenjualanSupermarketPusat"
        Me.CekPenjualanSupermarketPusat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanSupermarketPusat.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanSupermarketPusat.Properties.Caption = "Pusat"
        Me.CekPenjualanSupermarketPusat.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanSupermarketPusat.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanSupermarketPusat.TabIndex = 167
        '
        'TBPenjualanSupermarketPusat
        '
        Me.TBPenjualanSupermarketPusat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanSupermarketPusat.Location = New System.Drawing.Point(1, 25)
        Me.TBPenjualanSupermarketPusat.MainView = Me.GVPenjualanSupermarketPusat
        Me.TBPenjualanSupermarketPusat.Name = "TBPenjualanSupermarketPusat"
        Me.TBPenjualanSupermarketPusat.Size = New System.Drawing.Size(482, 318)
        Me.TBPenjualanSupermarketPusat.TabIndex = 168
        Me.TBPenjualanSupermarketPusat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanSupermarketPusat})
        '
        'GVPenjualanSupermarketPusat
        '
        Me.GVPenjualanSupermarketPusat.GridControl = Me.TBPenjualanSupermarketPusat
        Me.GVPenjualanSupermarketPusat.Name = "GVPenjualanSupermarketPusat"
        Me.GVPenjualanSupermarketPusat.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanSupermarketPusat.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanSupermarketPusat.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanSupermarketPusat.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanSupermarketPusat.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanSupermarketPusat.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanSupermarketPusat.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanSupermarketPusat.OptionsView.ShowFooter = True
        Me.GVPenjualanSupermarketPusat.OptionsView.ShowGroupPanel = False
        '
        'PenjualanLain
        '
        Me.PenjualanLain.Controls.Add(Me.CekPenjualanLain)
        Me.PenjualanLain.Controls.Add(Me.SCPenjualanLain)
        Me.PenjualanLain.Name = "PenjualanLain"
        Me.PenjualanLain.Size = New System.Drawing.Size(987, 374)
        Me.PenjualanLain.Text = "Penjualan Lain-lain"
        '
        'CekPenjualanLain
        '
        Me.CekPenjualanLain.AutoSizeInLayoutControl = True
        Me.CekPenjualanLain.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanLain.Name = "CekPenjualanLain"
        Me.CekPenjualanLain.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLain.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLain.Properties.Caption = "Penjualan Lain - lain"
        Me.CekPenjualanLain.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLain.Size = New System.Drawing.Size(181, 19)
        Me.CekPenjualanLain.TabIndex = 170
        '
        'SCPenjualanLain
        '
        Me.SCPenjualanLain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCPenjualanLain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SCPenjualanLain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SCPenjualanLain.Location = New System.Drawing.Point(0, 28)
        Me.SCPenjualanLain.Name = "SCPenjualanLain"
        Me.SCPenjualanLain.Panel1.Controls.Add(Me.CekPenjualanLainPerwakilan)
        Me.SCPenjualanLain.Panel1.Controls.Add(Me.TBPenjualanLainPerwakilan)
        Me.SCPenjualanLain.Panel1.Text = "Panel1"
        Me.SCPenjualanLain.Panel2.Controls.Add(Me.CekPenjualanLainPusat)
        Me.SCPenjualanLain.Panel2.Controls.Add(Me.TBPenjualanLainPusat)
        Me.SCPenjualanLain.Panel2.Text = "Panel2"
        Me.SCPenjualanLain.Size = New System.Drawing.Size(984, 346)
        Me.SCPenjualanLain.SplitterPosition = 486
        Me.SCPenjualanLain.TabIndex = 169
        Me.SCPenjualanLain.Text = "SplitContainerControl4"
        '
        'CekPenjualanLainPerwakilan
        '
        Me.CekPenjualanLainPerwakilan.AutoSizeInLayoutControl = True
        Me.CekPenjualanLainPerwakilan.Location = New System.Drawing.Point(3, 3)
        Me.CekPenjualanLainPerwakilan.Name = "CekPenjualanLainPerwakilan"
        Me.CekPenjualanLainPerwakilan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLainPerwakilan.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLainPerwakilan.Properties.Caption = "Perwakilan"
        Me.CekPenjualanLainPerwakilan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLainPerwakilan.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanLainPerwakilan.TabIndex = 164
        '
        'TBPenjualanLainPerwakilan
        '
        Me.TBPenjualanLainPerwakilan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanLainPerwakilan.Location = New System.Drawing.Point(2, 25)
        Me.TBPenjualanLainPerwakilan.MainView = Me.GVPenjualanLainPerwakilan
        Me.TBPenjualanLainPerwakilan.Name = "TBPenjualanLainPerwakilan"
        Me.TBPenjualanLainPerwakilan.Size = New System.Drawing.Size(483, 318)
        Me.TBPenjualanLainPerwakilan.TabIndex = 165
        Me.TBPenjualanLainPerwakilan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanLainPerwakilan})
        '
        'GVPenjualanLainPerwakilan
        '
        Me.GVPenjualanLainPerwakilan.GridControl = Me.TBPenjualanLainPerwakilan
        Me.GVPenjualanLainPerwakilan.Name = "GVPenjualanLainPerwakilan"
        Me.GVPenjualanLainPerwakilan.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanLainPerwakilan.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanLainPerwakilan.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanLainPerwakilan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanLainPerwakilan.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanLainPerwakilan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanLainPerwakilan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanLainPerwakilan.OptionsView.ShowFooter = True
        Me.GVPenjualanLainPerwakilan.OptionsView.ShowGroupPanel = False
        '
        'CekPenjualanLainPusat
        '
        Me.CekPenjualanLainPusat.AutoSizeInLayoutControl = True
        Me.CekPenjualanLainPusat.Location = New System.Drawing.Point(2, 3)
        Me.CekPenjualanLainPusat.Name = "CekPenjualanLainPusat"
        Me.CekPenjualanLainPusat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenjualanLainPusat.Properties.Appearance.Options.UseFont = True
        Me.CekPenjualanLainPusat.Properties.Caption = "Pusat"
        Me.CekPenjualanLainPusat.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenjualanLainPusat.Size = New System.Drawing.Size(98, 19)
        Me.CekPenjualanLainPusat.TabIndex = 167
        '
        'TBPenjualanLainPusat
        '
        Me.TBPenjualanLainPusat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenjualanLainPusat.Location = New System.Drawing.Point(1, 25)
        Me.TBPenjualanLainPusat.MainView = Me.GVPenjualanLainPusat
        Me.TBPenjualanLainPusat.Name = "TBPenjualanLainPusat"
        Me.TBPenjualanLainPusat.Size = New System.Drawing.Size(482, 318)
        Me.TBPenjualanLainPusat.TabIndex = 168
        Me.TBPenjualanLainPusat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenjualanLainPusat})
        '
        'GVPenjualanLainPusat
        '
        Me.GVPenjualanLainPusat.GridControl = Me.TBPenjualanLainPusat
        Me.GVPenjualanLainPusat.Name = "GVPenjualanLainPusat"
        Me.GVPenjualanLainPusat.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenjualanLainPusat.OptionsCustomization.AllowFilter = False
        Me.GVPenjualanLainPusat.OptionsCustomization.AllowGroup = False
        Me.GVPenjualanLainPusat.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenjualanLainPusat.OptionsMenu.EnableColumnMenu = False
        Me.GVPenjualanLainPusat.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenjualanLainPusat.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenjualanLainPusat.OptionsView.ShowFooter = True
        Me.GVPenjualanLainPusat.OptionsView.ShowGroupPanel = False
        '
        'PenitipanBarang
        '
        Me.PenitipanBarang.Controls.Add(Me.TBPenitipanBarang)
        Me.PenitipanBarang.Controls.Add(Me.CekPenitipanBarang)
        Me.PenitipanBarang.Name = "PenitipanBarang"
        Me.PenitipanBarang.Size = New System.Drawing.Size(987, 374)
        Me.PenitipanBarang.Text = "Penitipan Barang"
        '
        'TBPenitipanBarang
        '
        Me.TBPenitipanBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPenitipanBarang.Location = New System.Drawing.Point(2, 31)
        Me.TBPenitipanBarang.MainView = Me.GVPenitipanBarang
        Me.TBPenitipanBarang.Name = "TBPenitipanBarang"
        Me.TBPenitipanBarang.Size = New System.Drawing.Size(982, 338)
        Me.TBPenitipanBarang.TabIndex = 164
        Me.TBPenitipanBarang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPenitipanBarang})
        '
        'GVPenitipanBarang
        '
        Me.GVPenitipanBarang.GridControl = Me.TBPenitipanBarang
        Me.GVPenitipanBarang.Name = "GVPenitipanBarang"
        Me.GVPenitipanBarang.OptionsCustomization.AllowColumnMoving = False
        Me.GVPenitipanBarang.OptionsCustomization.AllowFilter = False
        Me.GVPenitipanBarang.OptionsCustomization.AllowGroup = False
        Me.GVPenitipanBarang.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPenitipanBarang.OptionsMenu.EnableColumnMenu = False
        Me.GVPenitipanBarang.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPenitipanBarang.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPenitipanBarang.OptionsView.ShowFooter = True
        Me.GVPenitipanBarang.OptionsView.ShowGroupPanel = False
        '
        'CekPenitipanBarang
        '
        Me.CekPenitipanBarang.AutoSizeInLayoutControl = True
        Me.CekPenitipanBarang.Location = New System.Drawing.Point(5, 6)
        Me.CekPenitipanBarang.Name = "CekPenitipanBarang"
        Me.CekPenitipanBarang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPenitipanBarang.Properties.Appearance.Options.UseFont = True
        Me.CekPenitipanBarang.Properties.Caption = "Penitipan Barang"
        Me.CekPenitipanBarang.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPenitipanBarang.Size = New System.Drawing.Size(157, 19)
        Me.CekPenitipanBarang.TabIndex = 163
        '
        'Retur
        '
        Me.Retur.Controls.Add(Me.TBRetur)
        Me.Retur.Controls.Add(Me.CekRetur)
        Me.Retur.Name = "Retur"
        Me.Retur.Size = New System.Drawing.Size(987, 374)
        Me.Retur.Text = "Retur"
        '
        'TBRetur
        '
        Me.TBRetur.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBRetur.Location = New System.Drawing.Point(2, 31)
        Me.TBRetur.MainView = Me.GVRetur
        Me.TBRetur.Name = "TBRetur"
        Me.TBRetur.Size = New System.Drawing.Size(982, 338)
        Me.TBRetur.TabIndex = 166
        Me.TBRetur.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRetur})
        '
        'GVRetur
        '
        Me.GVRetur.GridControl = Me.TBRetur
        Me.GVRetur.Name = "GVRetur"
        Me.GVRetur.OptionsCustomization.AllowColumnMoving = False
        Me.GVRetur.OptionsCustomization.AllowFilter = False
        Me.GVRetur.OptionsCustomization.AllowGroup = False
        Me.GVRetur.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVRetur.OptionsMenu.EnableColumnMenu = False
        Me.GVRetur.OptionsNavigation.AutoFocusNewRow = True
        Me.GVRetur.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVRetur.OptionsView.ShowFooter = True
        Me.GVRetur.OptionsView.ShowGroupPanel = False
        '
        'CekRetur
        '
        Me.CekRetur.AutoSizeInLayoutControl = True
        Me.CekRetur.Location = New System.Drawing.Point(5, 6)
        Me.CekRetur.Name = "CekRetur"
        Me.CekRetur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekRetur.Properties.Appearance.Options.UseFont = True
        Me.CekRetur.Properties.Caption = "Retur"
        Me.CekRetur.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekRetur.Size = New System.Drawing.Size(157, 19)
        Me.CekRetur.TabIndex = 165
        '
        'Persediaan
        '
        Me.Persediaan.Controls.Add(Me.TBPersediaan)
        Me.Persediaan.Controls.Add(Me.CekPersediaan)
        Me.Persediaan.Name = "Persediaan"
        Me.Persediaan.Size = New System.Drawing.Size(987, 374)
        Me.Persediaan.Text = "Persediaan"
        '
        'TBPersediaan
        '
        Me.TBPersediaan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPersediaan.Location = New System.Drawing.Point(2, 31)
        Me.TBPersediaan.MainView = Me.GVPersediaan
        Me.TBPersediaan.Name = "TBPersediaan"
        Me.TBPersediaan.Size = New System.Drawing.Size(982, 338)
        Me.TBPersediaan.TabIndex = 168
        Me.TBPersediaan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPersediaan})
        '
        'GVPersediaan
        '
        Me.GVPersediaan.GridControl = Me.TBPersediaan
        Me.GVPersediaan.Name = "GVPersediaan"
        Me.GVPersediaan.OptionsCustomization.AllowColumnMoving = False
        Me.GVPersediaan.OptionsCustomization.AllowFilter = False
        Me.GVPersediaan.OptionsCustomization.AllowGroup = False
        Me.GVPersediaan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVPersediaan.OptionsMenu.EnableColumnMenu = False
        Me.GVPersediaan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVPersediaan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVPersediaan.OptionsView.ShowFooter = True
        Me.GVPersediaan.OptionsView.ShowGroupPanel = False
        '
        'CekPersediaan
        '
        Me.CekPersediaan.AutoSizeInLayoutControl = True
        Me.CekPersediaan.Location = New System.Drawing.Point(5, 6)
        Me.CekPersediaan.Name = "CekPersediaan"
        Me.CekPersediaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekPersediaan.Properties.Appearance.Options.UseFont = True
        Me.CekPersediaan.Properties.Caption = "Persediaan"
        Me.CekPersediaan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekPersediaan.Size = New System.Drawing.Size(157, 19)
        Me.CekPersediaan.TabIndex = 167
        '
        'Monitoring
        '
        Me.Monitoring.Controls.Add(Me.TBMonitoring)
        Me.Monitoring.Controls.Add(Me.CekMonitoring)
        Me.Monitoring.Name = "Monitoring"
        Me.Monitoring.Size = New System.Drawing.Size(987, 374)
        Me.Monitoring.Text = "Monitoring"
        '
        'TBMonitoring
        '
        Me.TBMonitoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBMonitoring.Location = New System.Drawing.Point(2, 31)
        Me.TBMonitoring.MainView = Me.GVMonitoring
        Me.TBMonitoring.Name = "TBMonitoring"
        Me.TBMonitoring.Size = New System.Drawing.Size(982, 338)
        Me.TBMonitoring.TabIndex = 170
        Me.TBMonitoring.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMonitoring})
        '
        'GVMonitoring
        '
        Me.GVMonitoring.GridControl = Me.TBMonitoring
        Me.GVMonitoring.Name = "GVMonitoring"
        Me.GVMonitoring.OptionsCustomization.AllowColumnMoving = False
        Me.GVMonitoring.OptionsCustomization.AllowFilter = False
        Me.GVMonitoring.OptionsCustomization.AllowGroup = False
        Me.GVMonitoring.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVMonitoring.OptionsMenu.EnableColumnMenu = False
        Me.GVMonitoring.OptionsNavigation.AutoFocusNewRow = True
        Me.GVMonitoring.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVMonitoring.OptionsView.ShowFooter = True
        Me.GVMonitoring.OptionsView.ShowGroupPanel = False
        '
        'CekMonitoring
        '
        Me.CekMonitoring.AutoSizeInLayoutControl = True
        Me.CekMonitoring.Location = New System.Drawing.Point(5, 6)
        Me.CekMonitoring.Name = "CekMonitoring"
        Me.CekMonitoring.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekMonitoring.Properties.Appearance.Options.UseFont = True
        Me.CekMonitoring.Properties.Caption = "Monitoring"
        Me.CekMonitoring.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekMonitoring.Size = New System.Drawing.Size(157, 19)
        Me.CekMonitoring.TabIndex = 169
        '
        'KreditDebit
        '
        Me.KreditDebit.Controls.Add(Me.TBDebitKreditNote)
        Me.KreditDebit.Controls.Add(Me.CekDebitKreditNote)
        Me.KreditDebit.Name = "KreditDebit"
        Me.KreditDebit.Size = New System.Drawing.Size(987, 374)
        Me.KreditDebit.Text = "Debit Kredit Note"
        '
        'TBDebitKreditNote
        '
        Me.TBDebitKreditNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBDebitKreditNote.Location = New System.Drawing.Point(2, 31)
        Me.TBDebitKreditNote.MainView = Me.GVDebitKreditNote
        Me.TBDebitKreditNote.Name = "TBDebitKreditNote"
        Me.TBDebitKreditNote.Size = New System.Drawing.Size(982, 338)
        Me.TBDebitKreditNote.TabIndex = 172
        Me.TBDebitKreditNote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDebitKreditNote})
        '
        'GVDebitKreditNote
        '
        Me.GVDebitKreditNote.GridControl = Me.TBDebitKreditNote
        Me.GVDebitKreditNote.Name = "GVDebitKreditNote"
        Me.GVDebitKreditNote.OptionsCustomization.AllowColumnMoving = False
        Me.GVDebitKreditNote.OptionsCustomization.AllowFilter = False
        Me.GVDebitKreditNote.OptionsCustomization.AllowGroup = False
        Me.GVDebitKreditNote.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVDebitKreditNote.OptionsMenu.EnableColumnMenu = False
        Me.GVDebitKreditNote.OptionsNavigation.AutoFocusNewRow = True
        Me.GVDebitKreditNote.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVDebitKreditNote.OptionsView.ShowFooter = True
        Me.GVDebitKreditNote.OptionsView.ShowGroupPanel = False
        '
        'CekDebitKreditNote
        '
        Me.CekDebitKreditNote.AutoSizeInLayoutControl = True
        Me.CekDebitKreditNote.Location = New System.Drawing.Point(5, 6)
        Me.CekDebitKreditNote.Name = "CekDebitKreditNote"
        Me.CekDebitKreditNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekDebitKreditNote.Properties.Appearance.Options.UseFont = True
        Me.CekDebitKreditNote.Properties.Caption = "Debit Kredit Note"
        Me.CekDebitKreditNote.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekDebitKreditNote.Size = New System.Drawing.Size(157, 19)
        Me.CekDebitKreditNote.TabIndex = 171
        '
        'Laporan
        '
        Me.Laporan.Controls.Add(Me.TBLaporan)
        Me.Laporan.Controls.Add(Me.CekLaporan)
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Size = New System.Drawing.Size(987, 374)
        Me.Laporan.Text = "Laporan"
        '
        'TBLaporan
        '
        Me.TBLaporan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBLaporan.Location = New System.Drawing.Point(2, 31)
        Me.TBLaporan.MainView = Me.GVLaporan
        Me.TBLaporan.Name = "TBLaporan"
        Me.TBLaporan.Size = New System.Drawing.Size(982, 338)
        Me.TBLaporan.TabIndex = 174
        Me.TBLaporan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLaporan})
        '
        'GVLaporan
        '
        Me.GVLaporan.GridControl = Me.TBLaporan
        Me.GVLaporan.Name = "GVLaporan"
        Me.GVLaporan.OptionsCustomization.AllowColumnMoving = False
        Me.GVLaporan.OptionsCustomization.AllowFilter = False
        Me.GVLaporan.OptionsCustomization.AllowGroup = False
        Me.GVLaporan.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVLaporan.OptionsMenu.EnableColumnMenu = False
        Me.GVLaporan.OptionsNavigation.AutoFocusNewRow = True
        Me.GVLaporan.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVLaporan.OptionsView.ShowFooter = True
        Me.GVLaporan.OptionsView.ShowGroupPanel = False
        '
        'CekLaporan
        '
        Me.CekLaporan.AutoSizeInLayoutControl = True
        Me.CekLaporan.Location = New System.Drawing.Point(5, 6)
        Me.CekLaporan.Name = "CekLaporan"
        Me.CekLaporan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekLaporan.Properties.Appearance.Options.UseFont = True
        Me.CekLaporan.Properties.Caption = "Laporan"
        Me.CekLaporan.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekLaporan.Size = New System.Drawing.Size(157, 19)
        Me.CekLaporan.TabIndex = 173
        '
        'Sistem
        '
        Me.Sistem.Controls.Add(Me.TBSistem)
        Me.Sistem.Controls.Add(Me.CekSistem)
        Me.Sistem.Name = "Sistem"
        Me.Sistem.Size = New System.Drawing.Size(987, 374)
        Me.Sistem.Text = "Sistem"
        '
        'TBSistem
        '
        Me.TBSistem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBSistem.Location = New System.Drawing.Point(2, 31)
        Me.TBSistem.MainView = Me.GVSistem
        Me.TBSistem.Name = "TBSistem"
        Me.TBSistem.Size = New System.Drawing.Size(982, 338)
        Me.TBSistem.TabIndex = 176
        Me.TBSistem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSistem})
        '
        'GVSistem
        '
        Me.GVSistem.GridControl = Me.TBSistem
        Me.GVSistem.Name = "GVSistem"
        Me.GVSistem.OptionsCustomization.AllowColumnMoving = False
        Me.GVSistem.OptionsCustomization.AllowFilter = False
        Me.GVSistem.OptionsCustomization.AllowGroup = False
        Me.GVSistem.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVSistem.OptionsMenu.EnableColumnMenu = False
        Me.GVSistem.OptionsNavigation.AutoFocusNewRow = True
        Me.GVSistem.OptionsNavigation.EnterMoveNextColumn = True
        Me.GVSistem.OptionsView.ShowFooter = True
        Me.GVSistem.OptionsView.ShowGroupPanel = False
        '
        'CekSistem
        '
        Me.CekSistem.AutoSizeInLayoutControl = True
        Me.CekSistem.Location = New System.Drawing.Point(5, 6)
        Me.CekSistem.Name = "CekSistem"
        Me.CekSistem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekSistem.Properties.Appearance.Options.UseFont = True
        Me.CekSistem.Properties.Caption = "Sistem"
        Me.CekSistem.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray"
        Me.CekSistem.Size = New System.Drawing.Size(157, 19)
        Me.CekSistem.TabIndex = 175
        '
        'BarManagerMain
        '
        Me.BarManagerMain.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManagerMain.DockControls.Add(Me.BarDockControl1)
        Me.BarManagerMain.DockControls.Add(Me.BarDockControl2)
        Me.BarManagerMain.DockControls.Add(Me.BarDockControl3)
        Me.BarManagerMain.DockControls.Add(Me.BarDockControl4)
        Me.BarManagerMain.Form = Me
        Me.BarManagerMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me._Toolbar1_Button3, Me._Toolbar1_Button5, Me.LblTitle})
        Me.BarManagerMain.MainMenu = Me.Bar2
        Me.BarManagerMain.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me._Toolbar1_Button1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me._Toolbar1_Button2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me._Toolbar1_Button3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me._Toolbar1_Button5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.LblTitle)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.Caption = "F2 - Simpan"
        Me._Toolbar1_Button1.Glyph = CType(resources.GetObject("_Toolbar1_Button1.Glyph"), System.Drawing.Image)
        Me._Toolbar1_Button1.Id = 0
        Me._Toolbar1_Button1.LargeGlyph = CType(resources.GetObject("_Toolbar1_Button1.LargeGlyph"), System.Drawing.Image)
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        '
        '_Toolbar1_Button2
        '
        Me._Toolbar1_Button2.Caption = "F3 - Bersih"
        Me._Toolbar1_Button2.Glyph = CType(resources.GetObject("_Toolbar1_Button2.Glyph"), System.Drawing.Image)
        Me._Toolbar1_Button2.Id = 1
        Me._Toolbar1_Button2.LargeGlyph = CType(resources.GetObject("_Toolbar1_Button2.LargeGlyph"), System.Drawing.Image)
        Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.Caption = "F5 - Keluar"
        Me._Toolbar1_Button3.Glyph = CType(resources.GetObject("_Toolbar1_Button3.Glyph"), System.Drawing.Image)
        Me._Toolbar1_Button3.Id = 2
        Me._Toolbar1_Button3.LargeGlyph = CType(resources.GetObject("_Toolbar1_Button3.LargeGlyph"), System.Drawing.Image)
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.Caption = "F7 - Hapus"
        Me._Toolbar1_Button5.Glyph = CType(resources.GetObject("_Toolbar1_Button5.Glyph"), System.Drawing.Image)
        Me._Toolbar1_Button5.Id = 4
        Me._Toolbar1_Button5.LargeGlyph = CType(resources.GetObject("_Toolbar1_Button5.LargeGlyph"), System.Drawing.Image)
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        '
        'LblTitle
        '
        Me.LblTitle.Id = 6
        Me.LblTitle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ItemAppearance.Normal.Options.UseFont = True
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(996, 24)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 483)
        Me.BarDockControl2.Size = New System.Drawing.Size(996, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 459)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(996, 24)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 459)
        '
        'FrmGroupUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(996, 483)
        Me.Controls.Add(Me.TabCntrl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Name = "FrmGroupUser"
        Me.Text = "Group User"
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabCntrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCntrl.ResumeLayout(False)
        Me.Master.ResumeLayout(False)
        CType(Me.TBMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pembelian.ResumeLayout(False)
        CType(Me.CekPembelian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCPembelian.ResumeLayout(False)
        CType(Me.CekPembelianLangganan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPembelianLangganan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPembelianLangganan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPembelianSupermarket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPembelianSuper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPembelianSuper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenjualanLangganan.ResumeLayout(False)
        CType(Me.CekPenjualanLangganan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCPenjualanLangganan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCPenjualanLangganan.ResumeLayout(False)
        CType(Me.CekPenjualanLanggananPerwakilan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanLanggananPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanLanggananPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPenjualanLanggananPusat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanLanggananPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanLanggananPusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenjualanSupermarket.ResumeLayout(False)
        CType(Me.CekPenjualanSupermarket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCPenjualanSupermarket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCPenjualanSupermarket.ResumeLayout(False)
        CType(Me.CekPenjualanSupermarketPerwakilan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanSupermarketPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanSupermarketPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPenjualanSupermarketPusat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanSupermarketPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanSupermarketPusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenjualanLain.ResumeLayout(False)
        CType(Me.CekPenjualanLain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCPenjualanLain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCPenjualanLain.ResumeLayout(False)
        CType(Me.CekPenjualanLainPerwakilan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanLainPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanLainPerwakilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPenjualanLainPusat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPenjualanLainPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenjualanLainPusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenitipanBarang.ResumeLayout(False)
        CType(Me.TBPenitipanBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPenitipanBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPenitipanBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Retur.ResumeLayout(False)
        CType(Me.TBRetur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRetur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekRetur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Persediaan.ResumeLayout(False)
        CType(Me.TBPersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekPersediaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Monitoring.ResumeLayout(False)
        CType(Me.TBMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekMonitoring.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KreditDebit.ResumeLayout(False)
        CType(Me.TBDebitKreditNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDebitKreditNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekDebitKreditNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Laporan.ResumeLayout(False)
        CType(Me.TBLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekLaporan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sistem.ResumeLayout(False)
        CType(Me.TBSistem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSistem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekSistem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManagerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabCntrl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Master As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TBMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMaster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekMaster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Pembelian As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TBPembelianLangganan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPembelianLangganan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPembelianLangganan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PenjualanLangganan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PenjualanSupermarket As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PenjualanLain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PenitipanBarang As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Laporan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Sistem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarManagerMain As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents _Toolbar1_Button1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _Toolbar1_Button2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _Toolbar1_Button3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _Toolbar1_Button5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LblTitle As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SCPembelian As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CekPembelianSupermarket As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPembelianSuper As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPembelianSuper As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SCPenjualanLangganan As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CekPenjualanLanggananPerwakilan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanLanggananPerwakilan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanLanggananPerwakilan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPenjualanLanggananPusat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanLanggananPusat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanLanggananPusat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SCPenjualanSupermarket As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CekPenjualanSupermarketPerwakilan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanSupermarketPerwakilan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanSupermarketPerwakilan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPenjualanSupermarketPusat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanSupermarketPusat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanSupermarketPusat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SCPenjualanLain As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CekPenjualanLainPerwakilan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanLainPerwakilan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanLainPerwakilan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPenjualanLainPusat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPenjualanLainPusat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenjualanLainPusat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPenjualanLangganan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CekPembelian As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CekPenjualanSupermarket As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CekPenjualanLain As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Retur As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Persediaan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Monitoring As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents KreditDebit As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TBPenitipanBarang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPenitipanBarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPenitipanBarang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBRetur As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRetur As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekRetur As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBPersediaan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPersediaan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekPersediaan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBMonitoring As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMonitoring As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekMonitoring As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBDebitKreditNote As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDebitKreditNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekDebitKreditNote As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBLaporan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLaporan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekLaporan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TBSistem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSistem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CekSistem As DevExpress.XtraEditors.CheckEdit
End Class
