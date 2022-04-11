Public Class InputCheckOfficeLanggananPerwakilan
    Inherits FrmCheckOffice

    Private Sub InputPreDOSuper_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Text = "Input Check Office Langganan Perwakilan"
        LblTitle.Caption = "Check Office Langganan Perwakilan"
        _Toolbar1_Button4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        _Toolbar1_Button6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Bagian = EBagian.Langganan_Perwakilan
        AddHandler _Toolbar1_Button2.ItemClick, AddressOf Batal
        AddHandler _Toolbar1_Button1.ItemClick, AddressOf Simpan
    End Sub
End Class

Public Class EditCheckOfficeLanggananPerwakilan
    Inherits FrmCheckOffice

    Private Sub EditDeliveryOrderLanggananPusat_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Text = "Edit Check Office Langganan Perwakilan"
        LblTitle.Caption = "Check Office Langganan Perwakilan"
        Status_Edit = True
        Bagian = EBagian.Langganan_Perwakilan
        AddHandler _Toolbar1_Button2.ItemClick, AddressOf GetData
        AddHandler TxtIDTransaksi.EditValueChanged, AddressOf GetData
        AddHandler _Toolbar1_Button4.ItemClick, AddressOf BatalTransaksi
        AddHandler _Toolbar1_Button5.ItemClick, AddressOf Hapus
        HakForm("Penjualan Langganan", "Perwakilan", "Check Office", _Toolbar1_Button4, _Toolbar1_Button5, _Toolbar1_Button6)
    End Sub
End Class
