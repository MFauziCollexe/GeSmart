
Public Class MenuDebitNote
    Inherits FrmMenuDetail

    Private Sub GetData()
        'TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_TRANSAKSI,A.TGL,A.TGL_PENGAKUAN,B.NAMA,JUMLAH FROM DEBIT_KREDIT_NOTE A LEFT JOIN CUSTOMER B ON A.KODE_CUSTOMER=B.ID WHERE JENIS='Debit' AND PERIODE='" & periode & "'")
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_TRANSAKSI,A.TGL,A.TGL_PENGAKUAN,B.NAMA,JUMLAH FROM DEBIT_KREDIT_NOTE A WITH (NOLOCK) INNER JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID WHERE JENIS='Debit' AND PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Debit Note ]"
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
        GridView1.Columns(5).Caption = "Total"
        GridView1.Columns(5).Width = 40
        GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(5).DisplayFormat.FormatString = "c2"
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Debit Note"
        AddHandler Activated, AddressOf GetData
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputDebitNote.MdiParent = Me.MdiParent
        InputDebitNote.Show()
        InputDebitNote.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditDebitNote.MdiParent = Me.MdiParent
                EditDebitNote.Show()
                EditDebitNote.Focus()
                EditDebitNote.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub
End Class


Public Class MenuKreditNote
    Inherits FrmMenuDetail

    Private Sub GetData()
        TBMenu.DataSource = SelectCon.execute("SELECT A.ID_TRANSAKSI,A.NO_TRANSAKSI,A.TGL,A.TGL_PENGAKUAN,B.NAMA,JUMLAH FROM DEBIT_KREDIT_NOTE A WITH (NOLOCK) LEFT JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID WHERE JENIS='Kredit' AND PERIODE='" & periode & "'")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Kredit Note ]"
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
        GridView1.Columns(5).Caption = "Total"
        GridView1.Columns(5).Width = 40
        GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns(5).DisplayFormat.FormatString = "c2"
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Kredit Note"
        AddHandler Activated, AddressOf GetData
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputKreditNote.MdiParent = Me.MdiParent
        InputKreditNote.Show()
        InputKreditNote.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditKreditNote.MdiParent = Me.MdiParent
                EditKreditNote.Show()
                EditKreditNote.Focus()
                EditKreditNote.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub
End Class


Public Class MenuSalesReportJakarta
    Inherits FrmMenuDetail

    Private Sub GetData()
        StatusLoad = True
        TBMenu.DataSource = SelectCon.execute("select a.ID_TRANSAKSI,a.NO_TRANSAKSI,a.TGL,a.TGL_KIRIM,b.NO_DSR,b.TGL_PENGAKUAN TGL_DSR,c.NAMA_GUDANG GUDANG_DSR,d.NAMA DIVISI,a.batal from sales_report_jakarta a WITH (NOLOCK) join AR_DSR b WITH (NOLOCK) on a.ID_DSR = b.ID_TRANSAKSI join gudang c WITH (NOLOCK) on c.KODE  = b.GUDANG join DIVISI d WITH (NOLOCK) on d.KODE = b.DIVISI WHERE A.PERIODE='" & periode & "' ")
        TBMenu.Refresh()
        Frame1.Text = "[ " & GridView1.DataRowCount & " Data Sales Report Jakarta ]"
        GridView1.Columns(0).Caption = "ID Transaksi"
        GridView1.Columns(0).Width = 30
        GridView1.Columns(1).Caption = "No. Transaksi"
        GridView1.Columns(1).Width = 50
        GridView1.Columns(2).Caption = "Tanggal"
        GridView1.Columns(2).Width = 30
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(3).Caption = "Tanggal Kirim"
        GridView1.Columns(3).Width = 30
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(4).Caption = "NO. DSR"
        GridView1.Columns(4).Width = 50
        GridView1.Columns(5).Caption = "Tanggal Pengakuan DSR"
        GridView1.Columns(5).Width = 50
        GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(5).DisplayFormat.FormatString = "dd-MM-yyyy"
        GridView1.Columns(6).Caption = "Gudang"
        GridView1.Columns(6).Width = 75
        GridView1.Columns(7).Caption = "Divisi"
        GridView1.Columns(7).Width = 50
        GridView1.Columns(8).Visible = False
        SetFocusRow()
        StatusLoad = False
    End Sub

    Private Sub GetDataDetail()
        On Error Resume Next
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                TBMenuDetailMenu.DataSource = SelectCon.execute("select a.URUTAN,a.NO_NOTA,a.NO_DO,b.NAMA,a.BRUTO,a.STD_DISC,a.ADD_DISC,a.CASH_DISC,a.NETTO from sales_report_jakarta_detail a WITH (NOLOCK) join CUSTOMER b WITH (NOLOCK) on a.ID_CUSTOMER= b.ID WHERE A.ID_TRANSAKSI='" & GridView1.GetFocusedRow(0) & "' ORDER BY A.URUTAN")
                TBMenuDetailMenu.Refresh()
                GridView2.Columns(0).Caption = "No."
                GridView2.Columns(0).Width = 15
                GridView2.Columns(1).Caption = "Nota"
                GridView2.Columns(1).Width = 35
                GridView2.Columns(2).Caption = "DO"
                GridView2.Columns(2).Width = 35
                GridView2.Columns(3).Caption = "Nama"
                GridView2.Columns(3).Width = 150
                GridView2.Columns(4).Caption = "Bruto"
                GridView2.Columns(4).Width = 35
                GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(4).DisplayFormat.FormatString = "n2"
                GridView2.Columns(5).Caption = "Std. Disc"
                GridView2.Columns(5).Width = 35
                GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(5).DisplayFormat.FormatString = "n2"
                GridView2.Columns(6).Caption = "Add. Disc"
                GridView2.Columns(6).Width = 35
                GridView2.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(6).DisplayFormat.FormatString = "n2"
                GridView2.Columns(7).Caption = "Cash Disc"
                GridView2.Columns(7).Width = 35
                GridView2.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(7).DisplayFormat.FormatString = "n2"
                GridView2.Columns(8).Caption = "Netto"
                GridView2.Columns(8).Width = 35
                GridView2.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView2.Columns(8).DisplayFormat.FormatString = "n2"
            End If
        End If
    End Sub

    Private Sub MenuPO_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Key = "Sales Report Jakarta"
        AddHandler Activated, AddressOf GetData
        AddHandler GridView1.FocusedRowChanged, AddressOf GetDataDetail
        HakMenu("", "Laporan", "Input Sales Report Jakarta", BarButtonBaru, {BtnEdit, BarButtonEdit}, BtnCetak)
    End Sub

    Private Sub Cetak() Handles BtnCetak.ItemClick
        If BtnCetak.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        'ShowDevexpressReport(ReportPreview.KeyReport.Bon_Pesanan_Titipan, GridView1.GetFocusedRow(0))
        'Log.Cetak(Me, GridView1.GetFocusedRow(0))
    End Sub

    Private Sub Baru() Handles BarButtonBaru.ItemClick
        InputSalesReportJakarta.MdiParent = Me.MdiParent
        InputSalesReportJakarta.Show()
        InputSalesReportJakarta.Focus()
    End Sub

    Private Sub Edit() Handles BarButtonEdit.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                EditSalesReportJakarta.MdiParent = Me.MdiParent
                EditSalesReportJakarta.Show()
                EditSalesReportJakarta.Focus()
                EditSalesReportJakarta.TxtIDTransaksi.Text = GridView1.GetFocusedRow(0)
            End If
        End If
    End Sub

    Private Sub BtnLihat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLihat.ItemClick
        If GridView1.RowCount > 0 Then
            If Not IsDBNull(GridView1.GetFocusedRow(0)) Then
                Dim frm As New EditSalesReportJakarta
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
