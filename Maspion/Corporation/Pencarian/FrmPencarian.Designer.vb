﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPencarian
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPencarian))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.TBCari = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar1_Button9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClosing = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.ToolStripButton()
        Me.Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCari = New DevExpress.XtraEditors.TextEdit()
        Me.Frame1.SuspendLayout()
        CType(Me.TBCari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.TxtCari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.ProgressPanel1)
        Me.Frame1.Controls.Add(Me.TBCari)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 76)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(787, 387)
        Me.Frame1.TabIndex = 19
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Data"
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProgressPanel1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.Appearance.Options.UseBorderColor = True
        Me.ProgressPanel1.Appearance.Options.UseFont = True
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProgressPanel1.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Caption = "Sedang Memuat Data"
        Me.ProgressPanel1.Description = "Silahkan Menunggu ..."
        Me.ProgressPanel1.Location = New System.Drawing.Point(285, 153)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(240, 62)
        Me.ProgressPanel1.TabIndex = 22
        Me.ProgressPanel1.Text = "text"
        '
        'TBCari
        '
        Me.TBCari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.TBCari.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.TBCari.Location = New System.Drawing.Point(3, 15)
        Me.TBCari.MainView = Me.GridView1
        Me.TBCari.Name = "TBCari"
        Me.TBCari.Size = New System.Drawing.Size(781, 369)
        Me.TBCari.TabIndex = 1
        Me.TBCari.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.TBCari
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Toolbar1
        '
        Me.Toolbar1.ImageList = Me.ImageList2
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me.ToolStripSeparator1, Me._Toolbar1_Button9, Me.ToolStripSeparator2, Me.BtnClosing, Me.Button1, Me.Button2, Me.Button3})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(811, 25)
        Me.Toolbar1.TabIndex = 20
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.ImageIndex = 0
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(80, 22)
        Me._Toolbar1_Button1.Text = "F11 - &OK"
        Me._Toolbar1_Button1.ToolTipText = "F2 - Baru"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(50, 25)
        '
        '_Toolbar1_Button9
        '
        Me._Toolbar1_Button9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me._Toolbar1_Button9.AutoSize = False
        Me._Toolbar1_Button9.ImageIndex = 7
        Me._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button9.Name = "_Toolbar1_Button9"
        Me._Toolbar1_Button9.Size = New System.Drawing.Size(90, 22)
        Me._Toolbar1_Button9.Text = "F12 - &Keluar"
        Me._Toolbar1_Button9.ToolTipText = "F5 - Keluar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(50, 25)
        '
        'BtnClosing
        '
        Me.BtnClosing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnClosing.Image = CType(resources.GetObject("BtnClosing.Image"), System.Drawing.Image)
        Me.BtnClosing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClosing.Name = "BtnClosing"
        Me.BtnClosing.Size = New System.Drawing.Size(51, 22)
        Me.BtnClosing.Text = "Closing"
        Me.BtnClosing.Visible = False
        '
        'Button1
        '
        Me.Button1.AutoSize = False
        Me.Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 22)
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.AutoSize = False
        Me.Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 22)
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.AutoSize = False
        Me.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 22)
        Me.Button3.Text = "Button3"
        '
        'Frame2
        '
        Me.Frame2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.TxtCari)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 28)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(763, 42)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Pencarian :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(23, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "K&ata Kunci : "
        '
        'TxtCari
        '
        Me.TxtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCari.Location = New System.Drawing.Point(99, 16)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(641, 20)
        Me.TxtCari.TabIndex = 0
        Me.TxtCari.ToolTipTitle = "Inputkan ID Customer yang ingin di cari"
        '
        'FrmPencarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2013 Light Gray"
        Me.Name = "FrmPencarian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPencarian"
        Me.Frame1.ResumeLayout(False)
        CType(Me.TBCari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.TxtCari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBCari As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Public WithEvents ImageList2 As System.Windows.Forms.ImageList
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button9 As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnClosing As System.Windows.Forms.ToolStripButton
End Class
