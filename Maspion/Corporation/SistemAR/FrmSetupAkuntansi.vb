Imports DevExpress.XtraEditors

Public Class FrmSetupAkuntansi

    Private Sub InputGudang_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim KeyCode As Integer = e.KeyCode
        Dim Shift As Integer = e.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F2
                _Toolbar1_Button1.PerformClick()
            Case System.Windows.Forms.Keys.F4
                _Toolbar1_Button3.PerformClick()
        End Select
    End Sub

    Private Sub _Toolbar1_Button3_Click(sender As System.Object, e As System.EventArgs) Handles _Toolbar1_Button3.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TxtKode_Click(sender As ButtonEdit, e As System.EventArgs)
        sender.Text = Search(FrmPencarian.KeyPencarian.Kode_Perkiraan)
    End Sub
    Private Sub TxtKode_EditValueChanged(sender As ButtonEdit, e As System.EventArgs)
        On Error Resume Next
        Dim NamaTxt = Replace(sender.Name, "Kode", "Nama")
        Dim info As System.Reflection.FieldInfo =
            Me.GetType().GetField("_" & NamaTxt,
                System.Reflection.BindingFlags.NonPublic Or
                System.Reflection.BindingFlags.Instance Or
                System.Reflection.BindingFlags.Public Or
                System.Reflection.BindingFlags.IgnoreCase)
        Dim TxtNama = CType(info.GetValue(Me), Control)

        SetData("SELECT NAMA_PERKIRAAN FROM AR_KODE_PERKIRAAN WHERE KODE_PERKIRAAN='" & sender.Text & "'", {TxtNama})
    End Sub

    Private Sub BindHandler(ByRef TxtKode() As ButtonEdit)
        For Each Txt In TxtKode
            AddHandler Txt.Click, AddressOf TxtKode_Click
            AddHandler Txt.EditValueChanged, AddressOf TxtKode_EditValueChanged
        Next
    End Sub

    Private Sub _Toolbar1_Button1_Click(sender As Object, e As EventArgs) Handles _Toolbar1_Button1.Click
        If QuestionInput() = False Then Exit Sub

        Using SQLServer As New SQLServerTransaction
            SQLServer.InitTransaction()
            If SQLServer.Delete("AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"PIUTANG_PERWAKILAN", TxtKodePiutangPerw}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CASH_PERWAKILAN", TxtKodeCashPerw}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CADANGAN_PERWAKILAN", TxtKodeCadanganPerw}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"UCF_PERWAKILAN", TxtKodeUCFPerw}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"PERSEDIAAN_PERWAKILAN", TxtKodePersediaanPerw}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub

            If SQLServer.InsertHeader({"PIUTANG_PUSKON", TxtKodePiutangPusKon}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CASH_PUSKON", TxtKodeCashPusKon}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CADANGAN_PUSKON", TxtKodeCadanganPusKon}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"UCF_PUSKON", TxtKodeUCFPusKon}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"PERSEDIAAN_PUSKON", TxtKodePersediaanPusKon}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub

            If SQLServer.InsertHeader({"PIUTANG_PUSKRE", TxtKodePiutangPusKre}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CASH_PUSKRE", TxtKodeCashPusKre}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"CADANGAN_PUSKRE", TxtKodeCadanganPusKre}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"UCF_PUSKRE", TxtKodeUCFPusKre}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            If SQLServer.InsertHeader({"PERSEDIAAN_PUSKRE", TxtKodePersediaanPusKre}, "AR_SETUP_AKUNTANSI") = False Then Exit Sub
            SQLServer.EndTransaction()
        End Using

    End Sub

    Private Sub FrmSetupAkuntansi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindHandler({TxtKodePiutangPerw, TxtKodeCashPerw, TxtKodeCadanganPerw, TxtKodeUCFPerw, TxtKodePersediaanPerw,
                    TxtKodePiutangPusKon, TxtKodeCashPusKon, TxtKodeCadanganPusKon, TxtKodeUCFPusKon, TxtKodePersediaanPusKon,
                    TxtKodePiutangPusKre, TxtKodeCashPusKre, TxtKodeCadanganPusKre, TxtKodeUCFPusKre, TxtKodePersediaanPusKre})

        Using dt As DataTable = SelectCon.execute("SELECT * FROM AR_SETUP_AKUNTANSI")
            If dt.Rows.Count > 0 Then
                TxtKodePiutangPerw.Text = dt.Select("NAMA='PIUTANG_PERWAKILAN'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCashPerw.Text = dt.Select("NAMA='CASH_PERWAKILAN'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCadanganPerw.Text = dt.Select("NAMA='CADANGAN_PERWAKILAN'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeUCFPerw.Text = dt.Select("NAMA='UCF_PERWAKILAN'").CopyToDataTable().Rows(0).Item(1)
                TxtKodePersediaanPerw.Text = dt.Select("NAMA='PERSEDIAAN_PERWAKILAN'").CopyToDataTable().Rows(0).Item(1)

                TxtKodePiutangPusKon.Text = dt.Select("NAMA='PIUTANG_PUSKON'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCashPusKon.Text = dt.Select("NAMA='CASH_PUSKON'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCadanganPusKon.Text = dt.Select("NAMA='CADANGAN_PUSKON'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeUCFPusKon.Text = dt.Select("NAMA='UCF_PUSKON'").CopyToDataTable().Rows(0).Item(1)
                TxtKodePersediaanPusKon.Text = dt.Select("NAMA='PERSEDIAAN_PUSKON'").CopyToDataTable().Rows(0).Item(1)

                TxtKodePiutangPusKre.Text = dt.Select("NAMA='PIUTANG_PUSKRE'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCashPusKre.Text = dt.Select("NAMA='CASH_PUSKRE'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeCadanganPusKre.Text = dt.Select("NAMA='CADANGAN_PUSKRE'").CopyToDataTable().Rows(0).Item(1)
                TxtKodeUCFPusKre.Text = dt.Select("NAMA='UCF_PUSKRE'").CopyToDataTable().Rows(0).Item(1)
                TxtKodePersediaanPusKre.Text = dt.Select("NAMA='PERSEDIAAN_PUSKRE'").CopyToDataTable().Rows(0).Item(1)
            End If
        End Using
    End Sub
End Class
