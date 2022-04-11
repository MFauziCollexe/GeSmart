Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Public Class FrmMDI

#Region "HakAkses"
    Private Sub AksesItem(ByVal GroupMenu As String, ByVal Menu As String, ByVal ItemName As String)
        Dim Akses(3) As Boolean
        Dim dr As DataRow = dtHakAkses.Select("GROUP_HEADER='" & GroupMenu & "' AND HEADER='" & Menu & "' AND ITEM='" & ItemName & "' ")(0)
        Akses(0) = IIf(IsDBNull(dr("HAK_GH")), True, dr("HAK_GH"))
        Akses(1) = dr("HAK_H")
        Akses(2) = dr("LIHAT")
        Dim AksesItem As DevExpress.XtraBars.BarItemVisibility
        If Akses(2) Then AksesItem = BarItemVisibility.Always Else AksesItem = BarItemVisibility.Never

        Select Case GroupMenu
            Case ""
                Select Case Menu
                    Case "Master" : PageMaster.Visible = Akses(1)
                        Select Case ItemName
                            Case "Barang" : BtnBarang.Visibility = AksesItem
                            Case "Corporation" : BtnCorporation.Visibility = AksesItem
                            Case "Customer" : BtnCustomer.Visibility = AksesItem
                            Case "Divisi" : BtnDivisi.Visibility = AksesItem
                            Case "Ekspedisi" : BtnEkspedisi.Visibility = AksesItem
                            Case "Kendaraan" : BtnKendaraan.Visibility = AksesItem
                            Case "Gudang" : BtnGudang.Visibility = AksesItem
                            Case "Karyawan" : BtnKaryawan.Visibility = AksesItem
                            Case "Price List" : BtnPriceList.Visibility = AksesItem
                            Case "SBU" : BtnSBU.Visibility = AksesItem
                            Case "PT" : BtnPT.Visibility = AksesItem
                            Case "Gudang Customer" : BtnGudangCustomer.Visibility = AksesItem
                        End Select
                    Case "Penitipan Barang" : PagePenitipanBarang.Visible = Akses(1)
                        Select Case ItemName
                            Case "Surat Jalan Penitipan Barang" : BtnSJPenitipanBarang.Visibility = AksesItem
                            Case "Titip Barang" : BtnPenitipanBarang.Visibility = AksesItem
                        End Select
                    Case "Retur" : PageRetur.Visible = Akses(1)
                        Select Case ItemName
                            Case "Transfer Barang Retur" : BtnTransferBarangRetur.Visibility = AksesItem
                            Case "Penerimaan Transfer Barang Retur" : BtnPenerimaanTransferBarangRetur.Visibility = AksesItem
                            Case "Nota Retur Penjualan" : BtnReturPenjualan.Visibility = AksesItem
                            Case "Retur Pembelian" : BtnReturPembelian.Visibility = AksesItem
                            Case "Retur Pembellian Tanpa TTB" : BtnReturPembelianTanpaTTB.Visibility = AksesItem
                            Case "Tanda Terima Barang" : BtnTTB.Visibility = AksesItem
                        End Select
                    Case "Persediaan" : PagePersediaan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Mapping Barang" : BtnMappingBarang.Visibility = AksesItem
                            Case "Penerimaan Transfer" : BtnPenerimaanTransfer.Visibility = AksesItem
                            Case "Transfer Barang" : BtnTransferBarang.Visibility = AksesItem
                            Case "Saldo Awal Barang" : BtnSaldoAwalBarang.Visibility = AksesItem
                            Case "Adjusment Stok" : BtnAdjusmentStok.Visibility = AksesItem
                            Case "Posting Periode" : BtnPostingPeriode.Visibility = AksesItem
                        End Select
                    Case "Monitoring" : PageMonitoring.Visible = Akses(1)
                        Select Case ItemName
                            Case "Monitoring  Customer" : BtnMonitoringCustomer.Visibility = AksesItem
                            Case "Monitoring  Stok" : BtnMonitoringStok.Visibility = AksesItem
                        End Select
                    Case "Kredit Debit Note" : PageDebitKreditNote.Visible = Akses(1)
                        Select Case ItemName
                            Case "Debit Note" : BtnDebitNote.Visibility = AksesItem
                            Case "Kredit Note" : BtnKreditNote.Visibility = AksesItem
                        End Select
                    Case "Laporan" : PageLaporan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Daily Sales Report" : BtnDailySalesReport.Visibility = AksesItem
                            Case "Kartu Stok" : BtnKartuStok.Visibility = AksesItem
                            Case "Laporan Delivery Order" : BtnLaporanDO.Visibility = AksesItem
                            Case "Laporan Nota / SJ" : BtnLaporanNotaSJ.Visibility = AksesItem
                            Case "Laporan Pembelian" : BtnLaporanPembelian.Visibility = AksesItem
                            Case "Laporan Price List" : BtnLaporanPriceList.Visibility = AksesItem
                            Case "Laporan Penjualan" : BtnLaporanPenjualan.Visibility = AksesItem
                            Case "Laporan Penerimaan Barang Langganan" : BtnLPBL.Visibility = AksesItem
                            Case "Laporan LPBH" : BtnLPBH.Visibility = AksesItem
                            Case "Laporan Transfer Gudang" : BtnLaporantransferGudang.Visibility = AksesItem
                            Case "Laporan Summary Finish Goods" : BtnSummaryFinishGoods.Visibility = AksesItem
                            Case "Laporan Control Summary" : BtnControlSummary.Visibility = AksesItem
                            Case "Laporan Adjusment Stok" : BtnLaporanAdjusmentStok.Visibility = AksesItem
                            Case "Laporan Retur Penjualan" : BtnLaporanReturPenjualan.Visibility = AksesItem
                        End Select
                    Case "Sistem" : PageSistem.Visible = Akses(1)
                        Select Case ItemName
                            Case "Perusahaan" : BtnPerusahaan.Visibility = AksesItem
                            Case "Group User" : BtnGroupUser.Visibility = AksesItem
                        End Select
                End Select
            Case "Pembelian" : RibbonPageCategoryPembelian.Visible = Akses(0)
                Select Case Menu
                    Case "Supermarket" : PagePembelianSupermarket.Visible = Akses(1)
                        Select Case ItemName
                            Case "Claim Pembelian" : BtnClaimPembelianSupermarket.Visibility = AksesItem
                            Case "Nota Pembelian" : BtnPembelianSupermarket.Visibility = AksesItem
                            Case "Purchase Order" : BtnPurchaseOrderSupermarket.Visibility = AksesItem
                        End Select
                    Case "Langganan" : PagePembelianLangganan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Claim Pembelian" : BtnClaimPembelianLangganan.Visibility = AksesItem
                            Case "Nota Pembelian" : BtnPembelianLangganan.Visibility = AksesItem
                            Case "Purchase Order" : BtnPurchaseOrderLangganan.Visibility = AksesItem
                        End Select
                End Select
            Case "Penjualan Langganan" : RibbonPageCategoryPenjualanLangganan.Visible = Akses(0)
                Select Case Menu
                    Case "Perwakilan" : PagePenjualanLanggananPerwakilan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjLanggananPerwTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjLanggananPerwakilanBarangDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjLanggananPerwTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjLanggananPerwMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjLanggananPerwNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditLanggananPerwakilan.Visibility = AksesItem
                            Case "Stuffing" : BtnPjLanggananStuffing.Visibility = AksesItem
                            Case "Surat Jalan Tanpa Harga" : BtnSuratJalanTanpaHarga.Visibility = AksesItem
                            Case "Pengiriman" : BtnLanggananPengiriman.Visibility = AksesItem
                        End Select
                    Case "Pusat" : PagePenjualanLanggananPusat.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjLanggananPusatTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjLanggananPusatBarangDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjLanggananPusatTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjLanggananPusatMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjLanggananPusatNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditLanggananPusat.Visibility = AksesItem
                        End Select
                End Select
            Case "Penjualan Lain - lain" : RibbonPageCategoryPenjualanLain.Visible = Akses(0)
                Select Case Menu
                    Case "Perwakilan" : PagePenjualanLainPerwakilan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjLainPerwTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjLainPerwakilanBarangDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjLainPerwTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjLainPerwMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjLainPerwNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditLainPerwakilan.Visibility = AksesItem
                            Case "Stuffing" : BtnPjLainStuffing.Visibility = AksesItem
                            Case "Surat Jalan Tanpa Harga" : BtnSuratJalanTanpaHargaLain.Visibility = AksesItem
                        End Select
                    Case "Pusat" : PagePenjualanLainPusat.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjLainPusatTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjLainPusatBarangDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjLainPusatTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjLainPusatMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjLainPusatNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditLainPusat.Visibility = AksesItem
                        End Select
                End Select
            Case "Penjualan Supermarket" : RibbonPageCategoryPenjualanSupermarket.Visible = Akses(0)
                Select Case Menu
                    Case "Perwakilan" : PagePenjualanSupermarketPerwakilan.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjSupermarketPerwTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjSupermarketPerwakilanDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjSupermarketPerwTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjSupermarketPerwMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjSupermarketPerwNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditSupermarketPerwakilan.Visibility = AksesItem
                            Case "Refund" : BtnPjSupermarketPerwRefund.Visibility = AksesItem
                            Case "Stuffing" : BtnPjSupermarketStuffing.Visibility = AksesItem
                        End Select
                    Case "Pusat" : PagePenjualanSupermarketPusat.Visible = Akses(1)
                        Select Case ItemName
                            Case "Bon Pesanan (Titipan)" : BtnPjSupermarketPusatTBarangBonPesananTitipan.Visibility = AksesItem
                            Case "Delivery Order" : BtnPjSupermarketPusatBarangDO.Visibility = AksesItem
                            Case "DO Titipan" : BtnPjSupermarketPusatTBarangTitipan.Visibility = AksesItem
                            Case "Monitoring Payment" : BtnPjSupermarketPusatMonPay.Visibility = AksesItem
                            Case "Nota / Surat Jalan" : BtnPjSupermarketPusatNota.Visibility = AksesItem
                            Case "Payment Kredit" : BtnPaymentKreditSupermarketPusat.Visibility = AksesItem
                        End Select
                End Select
        End Select
    End Sub
#End Region

    Private Sub FrmMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Benar mau menutup aplikasi ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RibbonPageCategoryAR.Visible = False
        FrmIntro.MdiParent = Me
        FrmIntro.Show()
        Dim reg As Object = CreateObject("WScript.Shell")
        Dim s As String = Globalization.CultureInfo.CurrentCulture.EnglishName
        LblKeyboard.Caption = "Format Keyboard : " & s & " || "
        LblVersion.Caption = "Version " & My.Application.Info.Version.ToString & " || Server : " & Split(TxtServer, ";")(0) & " || Database : " & Split(TxtServer, ";")(1)
        For Each r As DataRow In dtHakAkses.Rows
            AksesItem(r("GROUP_HEADER"), r("HEADER"), r("ITEM"))
        Next

        Me.SuspendLayout()
        For Each pp As RibbonPage In RibbonControl.Pages
            For Each gp As RibbonPageGroup In pp.Groups
                Dim st As Boolean = False
                For Each i As DevExpress.XtraBars.BarItemLink In gp.ItemLinks
                    If i.Item.Visibility = BarItemVisibility.Always Then st = True : Exit For
                Next
                If st = False Then gp.Visible = False
            Next
        Next
        For Each pc As RibbonPageCategory In RibbonControl.PageCategories
            For Each ppp As RibbonPage In pc.Pages
                For Each gp As RibbonPageGroup In ppp.Groups
                    Dim st As Boolean = False
                    For Each i As DevExpress.XtraBars.BarItemLink In gp.ItemLinks
                        If i.Item.Visibility = BarItemVisibility.Always Then st = True : Exit For
                    Next
                    If st = False Then gp.Visible = False
                Next
            Next
        Next
        Me.ResumeLayout(False)
    End Sub

    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal v As IntPtr, ByVal s As Integer, ByVal l As Integer) As Integer
    Public Sub CloseObj(ByVal e As Form)
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess.Handle, -1, -1)
                Dim smart As Process() = Process.GetProcessesByName(e.ProductName)
                Dim start As Process
                For Each start In smart
                    SetProcessWorkingSetSize(start.Handle, -1, -1)
                Next start
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub FrmMDI_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CloseObj(Me)
    End Sub

    Private Sub FrmMDI_MdiChildActivate(sender As Object, e As System.EventArgs) Handles Me.MdiChildActivate
        'CloseObj(ActiveMdiChild)
    End Sub

    Private Sub FrmMDI_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Normal Then
            If Width < 800 Then
                Width = 800
            End If
            If Height < 600 Then
                Height = 600
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Caption = Format(Now, "hh:mm:ss") & " ||"
        LblTanggal.Caption = "Tanggal : " & Format(Now, "dd/MM/yyyy")
        LblUser.Caption = "Nama User : " & UserName & " ||  Periode : " & periode & "  || "
    End Sub

    Private Sub BtnUbahPassword_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnUbahPassword.ItemClick
        UbahPassword.MdiParent = Me
        UbahPassword.Show()
        UbahPassword.Focus()
    End Sub

    Private Sub BtnSwitchPeriode_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnSwitchPeriode.ItemClick
        Dispose()
        FrmSwitchPeriode.TxtID.Text = UserID
        FrmSwitchPeriode.TxtUsername.Text = UserName
        FrmSwitchPeriode.TxtPassword.Text = passwd
        FrmSwitchPeriode.Show()
        FrmSwitchPeriode.TglPeriode.Focus()
    End Sub

    Private Sub BtnLogOut_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnLogOut.ItemClick
        Dispose()
        FrmLogin.Show()
    End Sub

    Private Sub BtnExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnExit.ItemClick
        tutup_db()
        End
    End Sub

    Private Sub BtnKaryawan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnKaryawan.ItemClick
        MenuKaryawan.MdiParent = Me
        MenuKaryawan.Show()
        MenuKaryawan.Focus()
    End Sub

    Private Sub BtnSupplier_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSupplier.ItemClick
        'MenuSupplier.MdiParent = Me
        'MenuSupplier.Show()
        'MenuSupplier.Focus()
    End Sub

    Private Sub BtnCustomer_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCustomer.ItemClick
        MenuCustomer.MdiParent = Me
        MenuCustomer.Show()
        MenuCustomer.Focus()
    End Sub

    Private Sub BtnDivisi_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDivisi.ItemClick
        MenuDivisi.MdiParent = Me
        MenuDivisi.Show()
        MenuDivisi.Focus()
    End Sub

    Private Sub BtnSBU_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSBU.ItemClick
        MenuSBU.MdiParent = Me
        MenuSBU.Show()
        MenuSBU.Focus()
    End Sub

    Private Sub BtnGudang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnGudang.ItemClick
        MenuGudang.MdiParent = Me
        MenuGudang.Show()
        MenuGudang.Focus()
    End Sub

    Private Sub BtnPurchaseOrderLangganan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPurchaseOrderLangganan.ItemClick
        MenuPOLangganan.MdiParent = Me
        MenuPOLangganan.Show()
        MenuPOLangganan.Focus()
    End Sub

    Private Sub BtnPembelianLangganan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPembelianLangganan.ItemClick
        MenuNotaPembelianLangganan.MdiParent = Me
        MenuNotaPembelianLangganan.Show()
        MenuNotaPembelianLangganan.Focus()
    End Sub

    Private Sub BtnClaimPembelian_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClaimPembelianLangganan.ItemClick
        MenuNotaClaimLangganan.MdiParent = Me
        MenuNotaClaimLangganan.Show()
        MenuNotaClaimLangganan.Focus()
    End Sub

    Private Sub BtnReturPembelian_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnReturPembelian.ItemClick
        MenuNotaReturPembelian.MdiParent = Me
        MenuNotaReturPembelian.Show()
        MenuNotaReturPembelian.Focus()
    End Sub

    Private Sub BtnBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnBarang.ItemClick
        MenuBarang.MdiParent = Me
        MenuBarang.Show()
        MenuBarang.Focus()
    End Sub

    Private Sub BtnPjLanggananPusatBarangDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPusatBarangDO.ItemClick
        MenuDeliveryOrderLanggananPusat.MdiParent = Me
        MenuDeliveryOrderLanggananPusat.Show()
        MenuDeliveryOrderLanggananPusat.Focus()
    End Sub

    Private Sub BtnPjLanggananPusatTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPusatTBarangTitipan.ItemClick
        MenuDOTitipanLanggananPusat.MdiParent = Me
        MenuDOTitipanLanggananPusat.Show()
        MenuDOTitipanLanggananPusat.Focus()
    End Sub

    Private Sub BtnMonitoringCustomer_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMonitoringCustomer.ItemClick
        FrmMonitoringCustomer.MdiParent = Me
        FrmMonitoringCustomer.Show()
        FrmMonitoringCustomer.Focus()
    End Sub

    Private Sub BtnPjLanggananPerwakilanBarangDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPerwakilanBarangDO.ItemClick
        MenuDeliveryOrderLanggananPerwakilan.MdiParent = Me
        MenuDeliveryOrderLanggananPerwakilan.Show()
        MenuDeliveryOrderLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananPusatTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPusatTBarangBonPesananTitipan.ItemClick
        MenuBonPesananLanggananPusat.MdiParent = Me
        MenuBonPesananLanggananPusat.Show()
        MenuBonPesananLanggananPusat.Focus()
    End Sub

    Private Sub BtnPjLanggananPusatMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPusatMonPay.ItemClick
        MonitoringPaymentLanggananPusat.MdiParent = Me
        MonitoringPaymentLanggananPusat.Show()
        MonitoringPaymentLanggananPusat.Focus()
    End Sub

    Private Sub BtnPjLanggananPusatNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPusatNota.ItemClick
        MenuNotaSJLanggananPusat.MdiParent = Me
        MenuNotaSJLanggananPusat.Show()
        MenuNotaSJLanggananPusat.Focus()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSuratJalanTanpaHarga.ItemClick
        MenuSJLanggananPerwakilan.MdiParent = Me
        MenuSJLanggananPerwakilan.Show()
        MenuSJLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananPerwTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPerwTBarangTitipan.ItemClick
        MenuDOTitipanLanggananPerwakilan.MdiParent = Me
        MenuDOTitipanLanggananPerwakilan.Show()
        MenuDOTitipanLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananPerwTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPerwTBarangBonPesananTitipan.ItemClick
        MenuBonPesananLanggananPerwakilan.MdiParent = Me
        MenuBonPesananLanggananPerwakilan.Show()
        MenuBonPesananLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananPerwMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPerwMonPay.ItemClick
        MonitoringPaymentLanggananPerwakilan.MdiParent = Me
        MonitoringPaymentLanggananPerwakilan.Show()
        MonitoringPaymentLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananStuffing_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananStuffing.ItemClick
        MenuStuffingLanggananPerwakilan.MdiParent = Me
        MenuStuffingLanggananPerwakilan.Show()
        MenuStuffingLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLanggananPerwNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLanggananPerwNota.ItemClick
        MenuNotaSJLanggananPerwakilan.MdiParent = Me
        MenuNotaSJLanggananPerwakilan.Show()
        MenuNotaSJLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPriceList_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPriceList.ItemClick
        MenuPriceList.MdiParent = Me
        MenuPriceList.Show()
        MenuPriceList.Focus()
    End Sub

    Private Sub BtnTTB_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTTB.ItemClick
        MenuTTB.MdiParent = Me
        MenuTTB.Show()
        MenuTTB.Focus()
    End Sub

    Private Sub BtnRetur_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnReturPenjualan.ItemClick
        MenuNotaReturPenjualan.MdiParent = Me
        MenuNotaReturPenjualan.Show()
        MenuNotaReturPenjualan.Focus()
    End Sub

    Private Sub BtnCorporation_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCorporation.ItemClick
        MenuCorporation.MdiParent = Me
        MenuCorporation.Show()
        MenuCorporation.Focus()
    End Sub

    Private Sub BtnEkspedisi_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEkspedisi.ItemClick
        MenuEkspedisi.MdiParent = Me
        MenuEkspedisi.Show()
        MenuEkspedisi.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwakilanDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwakilanDO.ItemClick
        MenuDeliveryOrderSupermarketPerwakilan.MdiParent = Me
        MenuDeliveryOrderSupermarketPerwakilan.Show()
        MenuDeliveryOrderSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwTBarangTitipan.ItemClick
        MenuDOTitipanSupermarketPerwakilan.MdiParent = Me
        MenuDOTitipanSupermarketPerwakilan.Show()
        MenuDOTitipanSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwTBarangBonPesananTitipan.ItemClick
        MenuBonPesananSupermarketPerwakilan.MdiParent = Me
        MenuBonPesananSupermarketPerwakilan.Show()
        MenuBonPesananSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwMonPay.ItemClick
        MonitoringPaymentSupermarketPerwakilan.MdiParent = Me
        MonitoringPaymentSupermarketPerwakilan.Show()
        MonitoringPaymentSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketStuffing_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketStuffing.ItemClick
        MenuStuffingSupermarketPerwakilan.MdiParent = Me
        MenuStuffingSupermarketPerwakilan.Show()
        MenuStuffingSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwNota.ItemClick
        MenuNotaSJSupermarketPerwakilan.MdiParent = Me
        MenuNotaSJSupermarketPerwakilan.Show()
        MenuNotaSJSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPjSupermarketPerwRefund_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPerwRefund.ItemClick
        MenuRefundSupermarketPerwakilan.MdiParent = Me
        MenuRefundSupermarketPerwakilan.Show()
        MenuRefundSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnMonitoringStok_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMonitoringStok.ItemClick
        FrmMonitoringStok.MdiParent = Me
        FrmMonitoringStok.Show()
        FrmMonitoringStok.Focus()
    End Sub

    Private Sub BtnPjSupermarketPusatBarangDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPusatBarangDO.ItemClick
        MenuDeliveryOrderSupermarketPusat.MdiParent = Me
        MenuDeliveryOrderSupermarketPusat.Show()
        MenuDeliveryOrderSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPjSupermarketPusatTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPusatTBarangTitipan.ItemClick
        MenuDOTitipanSupermarketPusat.MdiParent = Me
        MenuDOTitipanSupermarketPusat.Show()
        MenuDOTitipanSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPjSupermarketPusatTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPusatTBarangBonPesananTitipan.ItemClick
        MenuBonPesananSupermarketPusat.MdiParent = Me
        MenuBonPesananSupermarketPusat.Show()
        MenuBonPesananSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPjSupermarketPusatMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPusatMonPay.ItemClick
        MonitoringPaymentSupermarketPusat.MdiParent = Me
        MonitoringPaymentSupermarketPusat.Show()
        MonitoringPaymentSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPjSupermarketPusatNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjSupermarketPusatNota.ItemClick
        MenuNotaSJSupermarketPusat.MdiParent = Me
        MenuNotaSJSupermarketPusat.Show()
        MenuNotaSJSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPjLainPerwakilanBarangDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPerwakilanBarangDO.ItemClick
        MenuDeliveryOrderLainPerwakilan.MdiParent = Me
        MenuDeliveryOrderLainPerwakilan.Show()
        MenuDeliveryOrderLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainPerwTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPerwTBarangTitipan.ItemClick
        MenuDOTitipanLainPerwakilan.MdiParent = Me
        MenuDOTitipanLainPerwakilan.Show()
        MenuDOTitipanLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainPerwTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPerwTBarangBonPesananTitipan.ItemClick
        MenuBonPesananLainPerwakilan.MdiParent = Me
        MenuBonPesananLainPerwakilan.Show()
        MenuBonPesananLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainPerwMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPerwMonPay.ItemClick
        MonitoringPaymentLainPerwakilan.MdiParent = Me
        MonitoringPaymentLainPerwakilan.Show()
        MonitoringPaymentLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainStuffing_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainStuffing.ItemClick
        MenuStuffingLainPerwakilan.MdiParent = Me
        MenuStuffingLainPerwakilan.Show()
        MenuStuffingLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainPerwNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPerwNota.ItemClick
        MenuNotaSJLainPerwakilan.MdiParent = Me
        MenuNotaSJLainPerwakilan.Show()
        MenuNotaSJLainPerwakilan.Focus()
    End Sub

    Private Sub BtnSuratJalanTanpaHargaLain_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSuratJalanTanpaHargaLain.ItemClick
        MenuSJLainPerwakilan.MdiParent = Me
        MenuSJLainPerwakilan.Show()
        MenuSJLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPjLainPusatBarangDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPusatBarangDO.ItemClick
        MenuDeliveryOrderLainPusat.MdiParent = Me
        MenuDeliveryOrderLainPusat.Show()
        MenuDeliveryOrderLainPusat.Focus()
    End Sub

    Private Sub BtnPjLainPusatTBarangTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPusatTBarangTitipan.ItemClick
        MenuDOTitipanLainPusat.MdiParent = Me
        MenuDOTitipanLainPusat.Show()
        MenuDOTitipanLainPusat.Focus()
    End Sub

    Private Sub BtnPjLainPusatTBarangBonPesananTitipan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPusatTBarangBonPesananTitipan.ItemClick
        MenuBonPesananLainPusat.MdiParent = Me
        MenuBonPesananLainPusat.Show()
        MenuBonPesananLainPusat.Focus()
    End Sub

    Private Sub BtnPjLainPusatMonPay_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPusatMonPay.ItemClick
        MonitoringPaymentLainPusat.MdiParent = Me
        MonitoringPaymentLainPusat.Show()
        MonitoringPaymentLainPusat.Focus()
    End Sub

    Private Sub BtnPjLainPusatNota_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPjLainPusatNota.ItemClick
        MenuNotaSJLainPusat.MdiParent = Me
        MenuNotaSJLainPusat.Show()
        MenuNotaSJLainPusat.Focus()
    End Sub

    Private Sub BtnPenitipanBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPenitipanBarang.ItemClick
        MenuTitipBarang.MdiParent = Me
        MenuTitipBarang.Show()
        MenuTitipBarang.Focus()
    End Sub

    Private Sub BtnSJPenitipanBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSJPenitipanBarang.ItemClick
        MenuSJTitipBarang.MdiParent = Me
        MenuSJTitipBarang.Show()
        MenuSJTitipBarang.Focus()
    End Sub

    Private Sub BtnPaymentKreditLanggananPerwakilan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditLanggananPerwakilan.ItemClick
        PaymentKreditLanggananPerwakilan.MdiParent = Me
        PaymentKreditLanggananPerwakilan.Show()
        PaymentKreditLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnPaymentKreditLanggananPusat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditLanggananPusat.ItemClick
        PaymentKreditLanggananPusat.MdiParent = Me
        PaymentKreditLanggananPusat.Show()
        PaymentKreditLanggananPusat.Focus()
    End Sub

    Private Sub BtnPaymentKreditSupermarketPerwakilan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditSupermarketPerwakilan.ItemClick
        PaymentKreditSupermarketPerwakilan.MdiParent = Me
        PaymentKreditSupermarketPerwakilan.Show()
        PaymentKreditSupermarketPerwakilan.Focus()
    End Sub

    Private Sub BtnPaymentKreditSupermarketPusat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditSupermarketPusat.ItemClick
        PaymentKreditSupermarketPusat.MdiParent = Me
        PaymentKreditSupermarketPusat.Show()
        PaymentKreditSupermarketPusat.Focus()
    End Sub

    Private Sub BtnPaymentKreditLainPerwakilan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditLainPerwakilan.ItemClick
        PaymentKreditLainPerwakilan.MdiParent = Me
        PaymentKreditLainPerwakilan.Show()
        PaymentKreditLainPerwakilan.Focus()
    End Sub

    Private Sub BtnPaymentKreditLainPusat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPaymentKreditLainPusat.ItemClick
        PaymentKreditLainPusat.MdiParent = Me
        PaymentKreditLainPusat.Show()
        PaymentKreditLainPusat.Focus()
    End Sub

    Private Sub BtnDebitNote_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDebitNote.ItemClick
        MenuDebitNote.MdiParent = Me
        MenuDebitNote.Show()
        MenuDebitNote.Focus()
    End Sub

    Private Sub BtnKreditNote_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnKreditNote.ItemClick
        MenuKreditNote.MdiParent = Me
        MenuKreditNote.Show()
        MenuKreditNote.Focus()
    End Sub

    Private Sub BtnDailySalesReport_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDailySalesReport.ItemClick
        DailySalesReport.MdiParent = Me
        DailySalesReport.Show()
        DailySalesReport.Focus()
    End Sub

    Private Sub BtnSaldoStok_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnKartuStok.ItemClick
        KartuStok.MdiParent = Me
        KartuStok.Show()
        KartuStok.Focus()
    End Sub

    Private Sub BtnTransferBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTransferBarang.ItemClick
        MenuTransferGudang.MdiParent = Me
        MenuTransferGudang.Show()
        MenuTransferGudang.Focus()
    End Sub

    Private Sub BtnPenerimaanTransfer_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPenerimaanTransfer.ItemClick
        MenuPenerimaanTransfer.MdiParent = Me
        MenuPenerimaanTransfer.Show()
        MenuPenerimaanTransfer.Focus()
    End Sub

    Private Sub BtnPurchaseOrderSupermarket_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPurchaseOrderSupermarket.ItemClick
        MenuPOSupermarket.MdiParent = Me
        MenuPOSupermarket.Show()
        MenuPOSupermarket.Focus()
    End Sub

    Private Sub BtnPembelianSupermarket_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPembelianSupermarket.ItemClick
        MenuNotaPembelianSupermarket.MdiParent = Me
        MenuNotaPembelianSupermarket.Show()
        MenuNotaPembelianSupermarket.Focus()
    End Sub

    Private Sub BtnClaimPembelianSupermarket_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClaimPembelianSupermarket.ItemClick
        MenuNotaClaimSupermarket.MdiParent = Me
        MenuNotaClaimSupermarket.Show()
        MenuNotaClaimSupermarket.Focus()
    End Sub

    Private Sub BtnPerusahaan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPerusahaan.ItemClick
        FrmPerusahaan.MdiParent = Me
        FrmPerusahaan.Show()
        FrmPerusahaan.Focus()
    End Sub

    Private Sub BtnMappingBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMappingBarang.ItemClick
        FrmMappingBarang.MdiParent = Me
        FrmMappingBarang.Show()
        FrmMappingBarang.Focus()
    End Sub

    Private Sub BtnGroupUser_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnGroupUser.ItemClick
        MenuGroupUser.MdiParent = Me
        MenuGroupUser.Show()
        MenuGroupUser.Focus()
    End Sub

    Private Sub BtnPT_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPT.ItemClick
        MenuPT.MdiParent = Me
        MenuPT.Show()
        MenuPT.Focus()
    End Sub

    Private Sub BtnLaporanPembelian_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanPembelian.ItemClick
        LaporanPembelian.MdiParent = Me
        LaporanPembelian.Show()
        LaporanPembelian.Focus()
    End Sub

    Private Sub BtnLaporanDO_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanDO.ItemClick
        LaporanDO.MdiParent = Me
        LaporanDO.Show()
        LaporanDO.Focus()
    End Sub

    Private Sub BtnLaporanNotaSJ_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanNotaSJ.ItemClick
        LaporanNotaSJ.MdiParent = Me
        LaporanNotaSJ.Show()
        LaporanNotaSJ.Focus()
    End Sub

    Private Sub BtnLaporanPriceList_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanPriceList.ItemClick
        LaporanPriceList.MdiParent = Me
        LaporanPriceList.Show()
        LaporanPriceList.Focus()
    End Sub

    Private Sub BtnLaporanPenjualan_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanPenjualan.ItemClick
        LaporanPenjualan.MdiParent = Me
        LaporanPenjualan.Show()
        LaporanPenjualan.Focus()
    End Sub

    Private Sub BtnSaldoAwalBarang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSaldoAwalBarang.ItemClick
        MenuSaldoAwal.MdiParent = Me
        MenuSaldoAwal.Show()
        MenuSaldoAwal.Focus()
    End Sub

    Private Sub BtnTransferBarangRetur_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTransferBarangRetur.ItemClick
        MenuTransferBarangRetur.MdiParent = Me
        MenuTransferBarangRetur.Show()
        MenuTransferBarangRetur.Focus()
    End Sub

    Private Sub BtnLPBL_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLPBL.ItemClick
        LaporanLPBL.MdiParent = Me
        LaporanLPBL.Show()
        LaporanLPBL.Focus()
    End Sub

    Private Sub BtnAdjusmentStok_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAdjusmentStok.ItemClick
        MenuAdjusmentStok.MdiParent = Me
        MenuAdjusmentStok.Show()
        MenuAdjusmentStok.Focus()
    End Sub

    Private Sub BtnLPBH_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLPBH.ItemClick
        LaporanLPBH.MdiParent = Me
        LaporanLPBH.Show()
        LaporanLPBH.Focus()
    End Sub

    Private Sub BtnReturPembelianTanpaTTB_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnReturPembelianTanpaTTB.ItemClick
        MenuNotaReturPembelianTanpaTTB.MdiParent = Me
        MenuNotaReturPembelianTanpaTTB.Show()
        MenuNotaReturPembelianTanpaTTB.Focus()
    End Sub

    Private Sub BtnPostingPeriode_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPostingPeriode.ItemClick
        FrmPostingPeriode.MdiParent = Me
        FrmPostingPeriode.Show()
        FrmPostingPeriode.Focus()
    End Sub

    Private Sub BtnPenerimaanTransferBarangRetur_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPenerimaanTransferBarangRetur.ItemClick
        MenuPenerimaanTransferBarangRetur.MdiParent = Me
        MenuPenerimaanTransferBarangRetur.Show()
        MenuPenerimaanTransferBarangRetur.Focus()
    End Sub

    Private Sub BtnLaporantransferGudang_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporantransferGudang.ItemClick
        LaporanTransferGudang.MdiParent = Me
        LaporanTransferGudang.Show()
        LaporanTransferGudang.Focus()
    End Sub

    Private Sub BtnMoDOOuts_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMoDOOuts.ItemClick
        FrmMonitoringDOOutstanding.MdiParent = Me
        FrmMonitoringDOOutstanding.Show()
        FrmMonitoringDOOutstanding.Focus()
    End Sub

    Private Sub BtnSummaryFinishGoods_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSummaryFinishGoods.ItemClick
        LaporanSummaryFinishGoods.MdiParent = Me
        LaporanSummaryFinishGoods.Show()
        LaporanSummaryFinishGoods.Focus()
    End Sub

    Private Sub BtnControlSummary_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnControlSummary.ItemClick
        LaporanControlSummary.MdiParent = Me
        LaporanControlSummary.Show()
        LaporanControlSummary.Focus()
    End Sub

    Private Sub BtnLaporanAdjusmentStok_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanAdjusmentStok.ItemClick
        LaporanAdjusmentStok.MdiParent = Me
        LaporanAdjusmentStok.Show()
        LaporanAdjusmentStok.Focus()
    End Sub

    Private Sub BtnLaporanReturPenjualan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnLaporanReturPenjualan.ItemClick
        LaporanReturPenjualan.MdiParent = Me
        LaporanReturPenjualan.Show()
        LaporanReturPenjualan.Focus()
    End Sub

    Private Sub BtnCreateDSR_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnCreateDSRPrw.ItemClick
        MenuCreateDSRPrw.MdiParent = Me
        MenuCreateDSRPrw.Show()
        MenuCreateDSRPrw.Focus()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnValidasiPrw.ItemClick
        MenuValidasiDSRPrw.MdiParent = Me
        MenuValidasiDSRPrw.Show()
        MenuValidasiDSRPrw.Focus()
    End Sub

    Private Sub BtnKodePerkiraan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnKodePerkiraan.ItemClick
        MenuKodePerkiraan.MdiParent = Me
        MenuKodePerkiraan.Show()
        MenuKodePerkiraan.Focus()
    End Sub

    Private Sub BtnJurnal_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnJurnal.ItemClick
        MenuJurnal.MdiParent = Me
        MenuJurnal.Show()
        MenuJurnal.Focus()
    End Sub

    Private Sub BtnKasMasuk_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnKasMasuk.ItemClick
        MenuKasMasuk.MdiParent = Me
        MenuKasMasuk.Show()
        MenuKasMasuk.Focus()
    End Sub

    Private Sub BtnKasKeluar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnKasKeluar.ItemClick
        MenuKasKeluar.MdiParent = Me
        MenuKasKeluar.Show()
        MenuKasKeluar.Focus()
    End Sub

    Private Sub BtnBankMasuk_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnBankMasuk.ItemClick
        MenuBankMasuk.MdiParent = Me
        MenuBankMasuk.Show()
        MenuBankMasuk.Focus()
    End Sub

    Private Sub BtnBankKeluar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnBankKeluar.ItemClick
        MenuBankKeluar.MdiParent = Me
        MenuBankKeluar.Show()
        MenuBankKeluar.Focus()
    End Sub

    Private Sub BtnSetupAkuntansi_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnSetupAkuntansi.ItemClick
        FrmSetupAkuntansi.MdiParent = Me
        FrmSetupAkuntansi.Show()
        FrmSetupAkuntansi.Focus()
    End Sub

    Private Sub BtnCreateDSRPus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnCreateDSRPus.ItemClick
        MenuCreateDSRPus.MdiParent = Me
        MenuCreateDSRPus.Show()
        MenuCreateDSRPus.Focus()
    End Sub

    Private Sub BtnValidasiPus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnValidasiPus.ItemClick
        MenuValidasiDSRPus.MdiParent = Me
        MenuValidasiDSRPus.Show()
        MenuValidasiDSRPus.Focus()
    End Sub

    Private Sub BtnHargaPromo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnHargaPromo.ItemClick
        MenuHargaPromo.MdiParent = Me
        MenuHargaPromo.Show()
        MenuHargaPromo.Focus()
    End Sub

    Private Sub BtnKendaraan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnKendaraan.ItemClick
        MenuKendaraan.MdiParent = Me
        MenuKendaraan.Show()
        MenuKendaraan.Focus()
    End Sub

    Private Sub BtnLanggananPengiriman_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnLanggananPengiriman.ItemClick
        MenuPengirimanLanggananPerwakilan.MdiParent = Me
        MenuPengirimanLanggananPerwakilan.Show()
        MenuPengirimanLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnLanggananCheckOffice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnLanggananCheckOffice.ItemClick
        MenuCheckOfficeLanggananPerwakilan.MdiParent = Me
        MenuCheckOfficeLanggananPerwakilan.Show()
        MenuCheckOfficeLanggananPerwakilan.Focus()
    End Sub

    Private Sub BtnLaporanCheckOffice_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnLaporanCheckOffice.ItemClick
        LaporanCheckOffice.MdiParent = Me
        LaporanCheckOffice.Show()
        LaporanCheckOffice.Focus()
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        MenuSalesReportJakarta.MdiParent = Me
        MenuSalesReportJakarta.Show()
        MenuSalesReportJakarta.Focus()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        SalesReportJakarta.MdiParent = Me
        SalesReportJakarta.Show()
        SalesReportJakarta.Focus()
    End Sub

    Private Sub BtnGudangCustomer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnGudangCustomer.ItemClick
        MenuGudangCustomer.MdiParent = Me
        MenuGudangCustomer.Show()
        MenuGudangCustomer.Focus()
    End Sub
End Class