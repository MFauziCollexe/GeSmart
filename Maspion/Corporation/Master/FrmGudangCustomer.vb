Imports DevExpress.XtraEditors.Controls

Public MustInherit Class FrmGudangCustomer

    Private Sub InputGudang_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim KeyCode As Integer = e.KeyCode
        Dim Shift As Integer = e.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F2
                _Toolbar1_Button1.PerformClick()
            Case System.Windows.Forms.Keys.F3
                _Toolbar1_Button2.PerformClick()
            Case System.Windows.Forms.Keys.F4
                _Toolbar1_Button3.PerformClick()
            Case System.Windows.Forms.Keys.F5
                _Toolbar1_Button4.PerformClick()
        End Select
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TxtKodeCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles TxtKodeCustomer.EditValueChanged
        SetData("SELECT NAMA FROM CUSTOMER WITH(NOLOCK) WHERE ID ='" & TxtKodeCustomer.Text & "'", {TxtNamaCustomer})
    End Sub


    Private Sub TxtKodeCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeCustomer.KeyPress
        If CharKeypress(TxtKodeCustomer, e) Then TxtKodeCustomer.Text = Search(FrmPencarian.KeyPencarian.CustomerGudang, , , , , "Customer")
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As Object, e As EventArgs) Handles _Toolbar1_Button1.Click

    End Sub
End Class

Public Class InputGudangCustomer
    Inherits FrmGudangCustomer

    Private Sub Batal()
        Clean(Me)
        Generate()
    End Sub

    Private Sub Generate()
        Dim urut As Integer
        Using dt = SelectCon.execute("SELECT KODE_GUDANG_CUSTOMER FROM GUDANG_CUSTOMER WITH(NOLOCK) WHERE KODE_GUDANG_CUSTOMER LIKE '%GDC%' ORDER BY KODE_GUDANG_CUSTOMER DESC")
            If dt.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Mid(dt.Rows(0).Item(0), 5, 3) + 1
            End If
        End Using
        TxtKode.Text = "GDC" & Format(urut, "000")
    End Sub

    Private Sub InputGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Name = "InputGudangCustomer"
        Text = "Input Gudang Customer"
        Generate()
        _Toolbar1_Button4.Visible = False
        CekStatusAktif.Visible = False
        AddHandler _Toolbar1_Button2.Click, AddressOf Batal
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button1.Click
        If Empty(TxtKode) Then Exit Sub
        If Empty(TxtNama) Then Exit Sub
        If Empty(TxtAlamat) Then Exit Sub
        If Empty(txtKota) Then Exit Sub
        If Empty(TxtKodeCustomer) Then Exit Sub

        If MsgBox("Apakah anda ingin menyimpan data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.No Then
            Exit Sub
        End If

        con.begin_exec()

        SQl = "INSERT INTO GUDANG_CUSTOMER VALUES ('" & TxtKode.Text & "','" & Replace(TxtNama.Text, "'", "`") & "','" & Replace(TxtAlamat.Text, "'", "`") & "','" & txtKota.Text & "','" & TxtTelp.Text & "','" & TxtPenanggungJawab.Text & "',1,'" & UserID & "','" & Format(Now, "MM/dd/yyyy HH:mm:ss") & "',null,null,'" & TxtKodeCustomer.Text & "')"

        If con.exec(SQl) Then
            con.end_exec(True)

            MessageBox.Show("Data Baru telah disimpan..!!",
                            "Penyimpanan Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Batal()
        Else
            GoTo keluar
        End If
        Exit Sub
keluar:
        con.end_exec(False)
        MsgBox(SQl)
        MessageBox.Show("Data gagal tersimpan..!!",
                        "Penyimpanan Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class

Public Class EditGudangCustomer
    Inherits FrmGudangCustomer

    Private Sub GetData()
        LoadData.GetData("SELECT NAMA_GUDANG,ALAMAT_GUDANG,KOTA_GUDANG,TELP_GUDANG,PENANGGUNG_JAWAB,STATUS_AKTIF,KODE_CUSTOMER FROM GUDANG_CUSTOMER WITH(NOLOCK) WHERE KODE_GUDANG_CUSTOMER='" & TxtKode.Text & "'")
        LoadData.SetData({TxtNama, TxtAlamat, txtKota, TxtTelp, TxtPenanggungJawab, CekStatusAktif, TxtKodeCustomer})
    End Sub

    Private Sub EditGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Name = "EditGudangCustomer"
        Text = "Edit Gudang Customer"
        AddHandler _Toolbar1_Button2.Click, AddressOf GetData
        AddHandler TxtKode.EditValueChanged, AddressOf GetData
        HakForm("", "Master", "Gudang Customer", CekStatusAktif, _Toolbar1_Button4, _Toolbar1_Button4)
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button1.Click
        If MsgBox("Apakah anda ingin mengubah data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.No Then
            Exit Sub
        End If

        con.begin_exec()

        SQl = "UPDATE GUDANG_CUSTOMER SET KODE_CUSTOMER='" & TxtKodeCustomer.Text & "' ,NAMA_GUDANG='" & Replace(TxtNama.Text, "'", "`") & "',KOTA_GUDANG='" & Replace(txtKota.Text, "'", "`") & "',ALAMAT_GUDANG='" & Replace(TxtAlamat.Text, "'", "`") & "',PENANGGUNG_JAWAB='" & Replace(TxtPenanggungJawab.Text, "'", "`") & "',TELP_GUDANG='" & TxtTelp.Text & "',MDUSER='" & UserID & "',MDTIME='" & Format(Now, "MM/dd/yyyy HH:mm:ss") & "',STATUS_AKTIF='" & CekStatusAktif.CheckState & "' WHERE KODE_GUDANG_CUSTOMER='" & TxtKode.Text & "'"

        If con.exec(SQl) Then
            con.end_exec(True)
            MessageBox.Show("Data sudah dirubah..!!",
                            "Rubah Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Me.Close()
        Else
            GoTo keluar
        End If
        Exit Sub
keluar:
        con.end_exec(False)
        MsgBox(SQl)
        MessageBox.Show("Data gagal terubah..!!",
                        "Penyimpanan Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub _Toolbar1_Button4_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button4.Click
        If _Toolbar1_Button4.Visible = False Then Exit Sub
        If MsgBox("Apakah anda ingin menghapus data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.No Then
            Exit Sub
        End If

        con.begin_exec()

        SQl = "DELETE FROM GUDANG_CUSTOMER WHERE KODE_GUDANG_CUSTOMER='" & TxtKode.Text & "'"

        If con.exec(SQl) Then
            con.end_exec(True)
            MessageBox.Show("Data sudah terhapus..!!",
                            "Hapus Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Me.Close()
        Else
            GoTo keluar
        End If
        Exit Sub
keluar:
        con.end_exec(False)
        MsgBox(SQl)
        MessageBox.Show("Data gagal terhapus..!!",
                        "Hapus Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class