
Public MustInherit Class FrmPengiriman
    Protected dt As New DataTable
    Protected Status_Edit As Boolean
    Protected Bagian As EBagian

#Region "Shared Sub"
    Protected Sub Cetak() Handles _Toolbar1_Button6.ItemClick
        If _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then Exit Sub
        ShowDevexpressReport(ReportPreview.KeyReport.Pengiriman, TxtIDTransaksi.Text)
        Log.Cetak(Me, TxtIDTransaksi.Text)
    End Sub

    Protected Sub Batal()
        Clean(Me)
        dt.Clear()
        AddRow(dt)
    End Sub

    Protected Sub Generate()
        Dim urut As Short
        Using dtGenerate = SelectCon.execute("SELECT NO_PENGIRIMAN FROM PENGIRIMAN WITH (NOLOCK) WHERE NO_PENGIRIMAN Like 'PG" & "(" & InisialPerusahaan & ")" & "%' AND YEAR(TGL_PENGAKUAN)=" & Format(TglPengakuan.EditValue, "yyyy") & " ORDER BY NO_PENGIRIMAN DESC")
            If dtGenerate.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Microsoft.VisualBasic.Right(dtGenerate.Rows(0).Item(0), 6) + 1
            End If
            TxtNoTransaksi.Text = "PG" & "(" & InisialPerusahaan & ")" & Format(urut, "000000")
        End Using
        Using dtGenerate = SelectCon.execute("SELECT ISNULL(MAX(CAST(REPLACE(ID_TRANSAKSI,'PG','') AS BIGINT)),0) AS ID FROM PENGIRIMAN WITH (NOLOCK)")
            TxtIDTransaksi.Text = "PG" & CInt(dtGenerate.Rows(0).Item(0)) + 1
        End Using
    End Sub

    Protected Sub Simpan()
        Dim i As Integer
        If Empty({TxtKodeGudang, TxtKodeDriver, TxtKodeKendaraan, TglTransaksi, TglPengakuan}) Then Exit Sub

        If dt.Select("[No Nota]<>''").Length > 0 = False Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If Format(TglPengakuan.EditValue, "MMyy") <> periode Then
            MsgBox("Tgl transaksi yang anda lakukan tidak sesuai dengan periode yang masuki", vbInformation, "Informasi")
            Exit Sub
        End If

        If QuestionInput() = False Then Exit Sub
        Generate()
        MessageBox.Show("Anda menggunakan nomor transaksi " & TxtNoTransaksi.Text & " !!!", "Pemberitahuan Nomor Transaksi !", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.InsertHeader({TxtIDTransaksi, TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtKodeGudang, TxtKodeDriver, TxtKodeKendaraan, txtKeterangan, txtKeteranganInternal, TxtSubTotal, periode, UserID, ToSyntax("CURRENT_TIMESTAMP"), ToSyntax("NULL"), ToSyntax("NULL"), 0, EnumDescription(Bagian)}, "PENGIRIMAN") = False Then Exit Sub
            'Detail
            If SQLServer.InsertDetail(dt.Select("[No Nota]<>''").CopyToDataTable, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), "ID Nota", "No Nota", "ID Customer", "No."}, "DETAIL_PENGIRIMAN") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Insert(Me, TxtIDTransaksi.Text)
            Batal()
        End Using
    End Sub

#Region "Edit"
    Protected Sub GetData()
        LoadData.GetData("SELECT [NO_PENGIRIMAN] ,[TGL] ,[TGL_PENGAKUAN] ,[GUDANG] ,[DRIVER] ,[KENDARAAN] ,[KETERANGAN_CETAK] ,[KETERANGAN_INTERNAL] ,[SUBTOTAL] FROM PENGIRIMAN WHERE ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'")
        LoadData.SetData({TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtKodeGudang, TxtKodeDriver, TxtKodeKendaraan, txtKeterangan, txtKeteranganInternal, TxtSubTotal})

        LoadData.GetData("SELECT A.URUTAN, A.ID_NOTA, A.NO_NOTA, B.TGL_PENGAKUAN, B.KODE_CUSTOMER, B.KODE_APPROVE, C.NAMA, B.DPP+B.PPN TOTAL FROM DETAIL_PENGIRIMAN A LEFT JOIN NOTA B ON A.ID_NOTA=B.ID_TRANSAKSI LEFT JOIN CUSTOMER C ON B.KODE_CUSTOMER=C.ID WHERE A.ID_TRANSAKSI='" & TxtIDTransaksi.Text & "' ORDER BY A.URUTAN")
        LoadData.SetDataDetail(dt, True)
        Hitung()
        Log.Load(Me, TxtIDTransaksi.Text)
    End Sub

    Protected Sub SimpanEdit()
        Dim i As Integer
        If Empty(TglTransaksi) Then Exit Sub


        If dt.Select("[No Nota]<>''").Length > 0 = False Then
            MsgBox("Data Detail masih kosong!!!", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If

        If QuestionEdit() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            'Header
            If SQLServer.UpdateHeader("[NO_PENGIRIMAN] ,[TGL] ,[TGL_PENGAKUAN] ,[GUDANG] ,[DRIVER] ,[KENDARAAN] ,[KETERANGAN_CETAK] ,[KETERANGAN_INTERNAL] ,[SUBTOTAL] ,[MDUSER] ,[MDTIME]", {TxtNoTransaksi, TglTransaksi, TglPengakuan, TxtKodeGudang, TxtKodeDriver, TxtKodeKendaraan, txtKeterangan, txtKeteranganInternal, TxtSubTotal, ToSyntax(UserID), ToSyntax("CURRENT_TIMESTAMP")}, "PENGIRIMAN", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            'Detail
            If SQLServer.Delete("DETAIL_PENGIRIMAN", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.InsertDetail(dt.Select("[No Nota]<>''").CopyToDataTable, {ToObject(TxtIDTransaksi.Text), ToObject(TxtNoTransaksi.Text), "ID Nota", "No Nota", "ID Customer", "No."}, "DETAIL_PENGIRIMAN") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Edit(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub

    Protected Sub Hapus()
        If QuestionHapus() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("PENGIRIMAN", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            If SQLServer.Delete("DETAIL_PENGIRIMAN", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Hapus(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub

    Protected Sub BatalTransaksi()
        If QuestionBatal() = False Then Exit Sub
        If AuthOTP(TxtIDTransaksi.Text, TxtNoTransaksi.Text, Text) = False Then Exit Sub
        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.UpdateHeader("BATAL", {ToSyntax("1")}, "PENGIRIMAN", "ID_TRANSAKSI='" & TxtIDTransaksi.Text & "'") = False Then Exit Sub
            SQLServer.EndTransaction()
            Log.Batal(Me, TxtIDTransaksi.Text)
            Me.Dispose()
        End Using
    End Sub
#End Region
#End Region

    Private Sub FrmDeliveryOrder_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Apakah anda yakin ingin keluar dari menu ini ?", "Pertanyaan !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dt.Dispose()
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmDeliveryOrder_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim KeyCode As Integer = e.KeyCode
        Dim Shift As Integer = e.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F2
                _Toolbar1_Button1.PerformClick()
            Case System.Windows.Forms.Keys.F3
                _Toolbar1_Button2.PerformClick()
            Case System.Windows.Forms.Keys.F5
                _Toolbar1_Button3.PerformClick()
            Case System.Windows.Forms.Keys.F6
                _Toolbar1_Button4.PerformClick()
            Case System.Windows.Forms.Keys.F7
                _Toolbar1_Button5.PerformClick()
            Case System.Windows.Forms.Keys.F8
                _Toolbar1_Button6.PerformClick()
        End Select
    End Sub

    Private Sub FrmDeliveryOrder_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TglTransaksi.DateTime = Format(Now.Date, "dd/MM/yyyy")
        TglPengakuan.DateTime = Format(Now.Date, "dd/MM/yyyy")
        InitGrid.Clear()
        InitGrid.AddColumnGrid("No.", TypeCode.Int32, 15, False)
        InitGrid.AddColumnGrid("ID Nota", TypeCode.String, 35, False, , , , , False)
        InitGrid.AddColumnGrid("No Nota", TypeCode.String, 40, True, , , , ReBEdit)
        InitGrid.AddColumnGrid("Tgl Pengakuan", TypeCode.DateTime, 40, False, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", False)
        InitGrid.AddColumnGrid("ID Customer", TypeCode.String, 35, False, , , , , False)
        InitGrid.AddColumnGrid("Kode Customer", TypeCode.String, 30, False)
        InitGrid.AddColumnGrid("Nama Customer", TypeCode.String, 100, False)
        InitGrid.AddColumnGrid("Total Nota", TypeCode.Decimal, 75, False, DevExpress.Utils.FormatType.Numeric, "c2")
        InitGrid.EndInit(TBDO, GridView1, dt)
        AddRow(dt)
    End Sub

    Private Sub TBDO_EditorKeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TBDO.EditorKeyDown
        Dim KeyAscii As Integer = e.KeyCode
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Enter
                If GridView1.FocusedColumn.FieldName = "No Nota" Then
                    e.Handled = False
                    e.SuppressKeyPress = True
                    Call REBEdit_Click(sender, e)
                ElseIf GridView1.FocusedColumn.FieldName = "Disc Satuan" Then
                    If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                        If Len(GridView1.GetFocusedRow("Kode Barang").ToString.Trim) > 0 Then

                        End If
                    End If
                End If
            Case Asc("A") To Asc("Z"), Asc("a") To Asc("z"), Asc("0") To Asc("9"), Asc(","), Asc("."), System.Windows.Forms.Keys.Back
                e.Handled = False
        End Select
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        SetDataTable(GridView1, e)
        GridView1.RefreshData()
    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        On Error Resume Next
        AllowEditColumn(GridView1, "No Nota", "Nama Customer")
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        On Error Resume Next
        AllowEditColumn(GridView1, "No Nota", "Nama Customer")
    End Sub

    Private Sub GridView1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyUp
        If e.KeyCode = 46 Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            GridView1.FocusedColumn = GridView1.Columns("No Nota")
            If GridView1.RowCount = 0 Then
                AddRow(dt)
                GridView1.FocusedColumn = GridView1.Columns("No Nota")
            End If
            Urutan()
            Hitung()
        End If
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.ItemClick
        Me.Close()
    End Sub

    'ReBEdit
    Private Sub REBEdit_Click(sender As Object, e As System.EventArgs)
        If GridView1.FocusedColumn.FieldName = "No Nota" Then
            If TxtKodeGudang.Text = "" Then
                MsgBox("Kolom Gudang Masih Kosong !!")
                TxtKodeGudang.Focus()
                Exit Sub
            End If
            Dim col As DataRow = GridView1.GetFocusedDataRow()
            'CEK DATA ADA / TIDAK 
            Using dt_cari = SelectCon.execute("SELECT TOP 1 A.*, B.KODE_APPROVE, B.NAMA FROM V_NOTA_T_PENGIRIMAN A WITH (NOLOCK) JOIN CUSTOMER B WITH (NOLOCK) ON A.KODE_CUSTOMER=B.ID WHERE (A.ID_TRANSAKSI='" & col("No Nota") & "' OR A.NO_NOTA='" & col("No Nota") & "') " & " AND A.ST=0  AND A.GUDANG='" & TxtKodeGudang.EditValue & "' ORDER BY A.TGL_PENGAKUAN DESC")
                If dt_cari.Rows.Count > 0 Then
                    If dt.Select("[ID Nota]='" & col("No Nota") & "' OR [No Nota]='" & col("No Nota") & "'").Length > 1 Then
                        MsgBox("Nota Sudah Ada !!")
                        col("No Nota") = ""
                        GridView1.FocusedColumn = GridView1.Columns("No Nota")
                        Exit Sub
                    End If
                    col("No.") = GridView1.FocusedRowHandle + 1
                    col("ID Nota") = dt_cari.Rows(0).Item("ID_TRANSAKSI")
                    col("No Nota") = dt_cari.Rows(0).Item("NO_NOTA")
                    GridView1.EditingValue = dt_cari.Rows(0).Item("NO_NOTA")
                    col("Tgl Pengakuan") = dt_cari.Rows(0).Item("TGL_PENGAKUAN")
                    col("ID Customer") = dt_cari.Rows(0).Item("KODE_CUSTOMER")
                    col("Kode Customer") = dt_cari.Rows(0).Item("KODE_APPROVE")
                    col("Nama Customer") = dt_cari.Rows(0).Item("NAMA")
                    col("Total Nota") = dt_cari.Rows(0).Item("DPP") + dt_cari.Rows(0).Item("PPN")

                    AddRow(dt)
                    Urutan()
                    GridView1.FocusedColumn = GridView1.Columns("No Nota")
                    Hitung()
                    Exit Sub
                Else
                    MessageBox.Show("Nota tidak ditemukan, pastikan gudang dipilih sesuai nota dan silahkan coba lagi!", "Informasi !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End If
    End Sub

#Region "Declare"
    Protected Sub Urutan()
        For i = 0 To GridView1.RowCount - 1
            GridView1.GetDataRow(i)(0) = i + 1
        Next
    End Sub

    Private Sub AllowEditColumn(ByRef Gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal EditColumn As String, ByVal CheckColumn As String)
        On Error Resume Next
        If Len(Gridview.GetFocusedRow(CheckColumn).ToString.Trim) > 0 Then
            Gridview.Columns(EditColumn).OptionsColumn.AllowEdit = False
        Else
            Gridview.Columns(EditColumn).OptionsColumn.AllowEdit = True
        End If
    End Sub

    Protected Sub Hitung()
        On Error Resume Next
        Dim TempTotalDiskon As Double = 0
        Dim Total As Double = 0
        For Each col As DataRow In dt.Rows
            Total = Total + col("Total Nota")
            TxtSubTotal.Text = Math.Round(Total)
        Next
    End Sub
#End Region

    Private Sub TxtKodeGudang_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtKodeGudang.ButtonClick
        TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang)
    End Sub

    Private Sub TxtKodeGudang_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeGudang.EditValueChanged
        SetData("SELECT NAMA_GUDANG FROM GUDANG WITH (NOLOCK) WHERE KODE ='" & TxtKodeGudang.Text & "'", {TxtNamaGudang})
    End Sub

    Private Sub TxtKodeGudang_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeGudang.KeyPress
        If CharKeypress(TxtKodeGudang, e) Then TxtKodeGudang.Text = Search(FrmPencarian.KeyPencarian.Gudang)
    End Sub

    Private Sub TxtKodeDriver_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtKodeDriver.ButtonClick
        TxtKodeDriver.Text = Search(FrmPencarian.KeyPencarian.Karyawan)
    End Sub

    Private Sub TxtKodeDriver_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeDriver.EditValueChanged
        SetData("SELECT NAMA_USER FROM USERS WITH (NOLOCK) WHERE ID_USER ='" & TxtKodeDriver.Text & "'", {TxtNamaDriver})
    End Sub

    Private Sub TxtKodeDriver_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeDriver.KeyPress
        If CharKeypress(TxtKodeDriver, e) Then TxtKodeDriver.Text = Search(FrmPencarian.KeyPencarian.Karyawan)
    End Sub

    Private Sub TxtKodeKendaraan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles TxtKodeKendaraan.ButtonClick
        TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)
    End Sub

    Private Sub TxtKodeKendaraan_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtKodeKendaraan.EditValueChanged
        SetData("SELECT NOPOL+' ('+TIPE+', '+MODEL+')' AS NAMA,DRIVER FROM KENDARAAN WITH (NOLOCK) WHERE KODE_KENDARAAN ='" & TxtKodeKendaraan.Text & "'", {TxtNamaKendaraan, TxtKodeDriver})
    End Sub

    Private Sub TxtKodeKendaraan_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKodeKendaraan.KeyPress
        If CharKeypress(TxtKodeKendaraan, e) Then TxtKodeKendaraan.Text = Search(FrmPencarian.KeyPencarian.Kendaraan)
    End Sub

End Class