Imports DevExpress.XtraEditors.Controls

Public MustInherit Class FrmKendaraan

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

    Private Sub FrmKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtKodeDriver_EditValueChanged(sender As Object, e As EventArgs) Handles TxtKodeDriver.EditValueChanged
        SetData("SELECT NAMA_USER FROM USERS WITH (NOLOCK) WHERE ID_USER ='" & TxtKodeDriver.Text & "'", {TxtNamaDriver})
    End Sub

    Private Sub TxtKodeDriver_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtKodeDriver.ButtonClick
        TxtKodeDriver.Text = Search(FrmPencarian.KeyPencarian.Karyawan_driver)
    End Sub
End Class

Public Class InputKendaraan
    Inherits FrmKendaraan

    Private Sub Batal()
        Clean(Me)
        Generate()
    End Sub

    Private Sub Generate()
        Dim urut As Integer
        Using dt = SelectCon.execute("SELECT KODE_KENDARAAN FROM KENDARAAN WITH (NOLOCK) WHERE KODE_KENDARAAN LIKE '%KEN%' ORDER BY KODE_KENDARAAN DESC")
            If dt.Rows.Count = 0 Then
                urut = 1
            Else
                urut = Mid(dt.Rows(0).Item(0), 5, 3) + 1
            End If
        End Using
        TxtKode.Text = "KEN" & Format(urut, "000")
    End Sub

    Private Sub InputGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Name = "InputKendaraan"
        Text = "Input Kendaraan"
        Generate()
        _Toolbar1_Button4.Visible = False
        CekStatusAktif.Visible = False
        AddHandler _Toolbar1_Button2.Click, AddressOf Batal
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button1.Click
        If Empty({TxtKode, TxtNopol, TxtJenis, TxtMerk, TxtTipe, TxtModel}) Then Exit Sub

        If MsgBox("Apakah anda ingin menyimpan data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.No Then
            Exit Sub
        End If

        con.begin_exec()
        SQl = "INSERT INTO KENDARAAN VALUES ('" & TxtKode.Text & "','" & TxtNopol.Text & "','" & TxtJenis.Text & "','" & TxtMerk.Text & "','" & TxtTipe.Text & "','" & TxtModel.Text & "','" & TxtTahun.Text & "','" & TxtWarna.Text & "','" & TxtNoRangka.Text & "','" & TxtNoMesin.Text & "','" & TxtBahanBakar.Text & "','" & Format(TxtBerlaku.EditValue, "MM/dd/yyyy") & "','" & UserID & "','" & Format(Now, "MM/dd/yyyy HH:mm:ss") & "',null,null,1,'" & Replace(MemoEditLokasi.Text, "'", "`") & "','" & TxtKodeDriver.Text & "')"

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

Public Class EditKendaraan
    Inherits FrmKendaraan

    Private Sub GetData()
        LoadData.GetData("SELECT NOPOL, JENIS, MERK, TIPE, MODEL, TAHUN_PEMBUATAN, WARNA, NO_RANGKA, NO_MESIN, BAHAN_BAKAR, BERLAKU_STNK, STATUS_AKTIF,LOKASI,DRIVER FROM KENDARAAN WITH (NOLOCK) WHERE KODE_KENDARAAN='" & TxtKode.Text & "'")
        LoadData.SetData({TxtNopol, TxtJenis, TxtMerk, TxtTipe, TxtModel, TxtTahun, TxtWarna, TxtNoRangka, TxtNoMesin, TxtBahanBakar, TxtBerlaku, CekStatusAktif, MemoEditLokasi, TxtKodeDriver})
    End Sub

    Private Sub EditGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Name = "EditKendaraan"
        Text = "Edit Kendaraan"
        AddHandler _Toolbar1_Button2.Click, AddressOf GetData
        AddHandler TxtKode.EditValueChanged, AddressOf GetData
        HakForm("", "Master", "Kendaraan", CekStatusAktif, _Toolbar1_Button4, _Toolbar1_Button4)
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button1.Click
        If MsgBox("Apakah anda ingin mengubah data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pertanyaan") = MsgBoxResult.No Then
            Exit Sub
        End If

        con.begin_exec()
        SQl = "UPDATE KENDARAAN SET NOPOL='" & TxtNopol.Text & "', JENIS='" & TxtJenis.Text & "', MERK='" & TxtMerk.Text & "', TIPE='" & TxtTipe.Text & "',MODEL='" & TxtModel.Text & "',TAHUN_PEMBUATAN='" & TxtTahun.Text & "', WARNA='" & TxtWarna.Text & "', NO_RANGKA='" & TxtNoRangka.Text & "', NO_MESIN='" & TxtNoMesin.Text & "', BAHAN_BAKAR='" & TxtBahanBakar.Text & "', BERLAKU_STNK='" & Format(TxtBerlaku.EditValue, "MM/dd/yyyy") & "', MDUSER='" & UserID & "', MDTIME='" & Format(Now, "MM/dd/yyyy HH:mm:ss") & "', STATUS_AKTIF='" & CekStatusAktif.CheckState & "',LOKASI = '" & Replace(MemoEditLokasi.Text, "'", "`") & "',DRIVER = '" & TxtKodeDriver.Text & "' WHERE KODE_KENDARAAN='" & TxtKode.Text & "'"

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

        SQl = "DELETE FROM KENDARAAN WHERE KODE_KENDARAAN='" & TxtKode.Text & "'"

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