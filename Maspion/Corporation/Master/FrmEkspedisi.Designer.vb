﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEkspedisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEkspedisi))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtPenanggungJawab = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTelp = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNama = New DevExpress.XtraEditors.TextEdit()
        Me.TxtKode = New DevExpress.XtraEditors.TextEdit()
        Me.TxtAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CekStatusAktif = New DevExpress.XtraEditors.CheckEdit()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
        Me.Toolbar1.SuspendLayout()
        CType(Me.TxtPenanggungJawab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStatusAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TxtPenanggungJawab
        '
        Me.TxtPenanggungJawab.EnterMoveNextControl = True
        Me.TxtPenanggungJawab.Location = New System.Drawing.Point(128, 156)
        Me.TxtPenanggungJawab.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtPenanggungJawab.Name = "TxtPenanggungJawab"
        Me.TxtPenanggungJawab.Size = New System.Drawing.Size(291, 20)
        Me.TxtPenanggungJawab.TabIndex = 4
        '
        'TxtTelp
        '
        Me.TxtTelp.EnterMoveNextControl = True
        Me.TxtTelp.Location = New System.Drawing.Point(128, 133)
        Me.TxtTelp.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtTelp.Name = "TxtTelp"
        Me.TxtTelp.Size = New System.Drawing.Size(291, 20)
        Me.TxtTelp.TabIndex = 3
        '
        'TxtNama
        '
        Me.TxtNama.EnterMoveNextControl = True
        Me.TxtNama.Location = New System.Drawing.Point(128, 64)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(291, 20)
        Me.TxtNama.TabIndex = 1
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
        'TxtAlamat
        '
        Me.TxtAlamat.EditValue = ""
        Me.TxtAlamat.EnterMoveNextControl = True
        Me.TxtAlamat.Location = New System.Drawing.Point(128, 87)
        Me.TxtAlamat.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(291, 43)
        Me.TxtAlamat.TabIndex = 2
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Location = New System.Drawing.Point(423, 65)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl13.TabIndex = 109
        Me.LabelControl13.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Location = New System.Drawing.Point(423, 89)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl1.TabIndex = 110
        Me.LabelControl1.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(423, 158)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl2.TabIndex = 110
        Me.LabelControl2.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 111
        Me.LabelControl3.Text = "Kode Ekspedisi"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(22, 65)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl4.TabIndex = 111
        Me.LabelControl4.Text = "Nama Ekspedisi"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 90)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl5.TabIndex = 111
        Me.LabelControl5.Text = "Alamat Ekspedisi"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(22, 136)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl6.TabIndex = 111
        Me.LabelControl6.Text = "Nomer Telp. / HP"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(22, 158)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl7.TabIndex = 111
        Me.LabelControl7.Text = "Penanggung Jawab"
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
        Me.CekStatusAktif.TabIndex = 5
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
        '_Toolbar1_Button4
        '
        Me._Toolbar1_Button4.Image = CType(resources.GetObject("_Toolbar1_Button4.Image"), System.Drawing.Image)
        Me._Toolbar1_Button4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
        Me._Toolbar1_Button4.Size = New System.Drawing.Size(84, 22)
        Me._Toolbar1_Button4.Text = "F5 - Hapus"
        '
        'FrmEkspedisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 198)
        Me.Controls.Add(Me.CekStatusAktif)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.TxtPenanggungJawab)
        Me.Controls.Add(Me.TxtTelp)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.TxtAlamat)
        Me.KeyPreview = True
        Me.Name = "FrmEkspedisi"
        Me.Text = "Input Ekspedisi"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.TxtPenanggungJawab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStatusAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtPenanggungJawab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTelp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtAlamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CekStatusAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
End Class
