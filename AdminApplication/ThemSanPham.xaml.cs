using AdminApplication.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminApplication
{
    /// <summary>
    /// Interaction logic for ThemSanPham.xaml
    /// </summary>
    public partial class ThemSanPham : UserControl
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }
        private bool isShow = false;
        private bool isShow2 = false;
        public  UpdateInfor update;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            Producet.Class1 pro = new Producet.Class1();
            pro.product_name = tbTenSanPham.Text;
            pro.product_country = tbNoiSanXuat.Text;
            pro.company = tbCongTySanXuat.Text;
            try
            {
                pro.amount = Int32.Parse(tbSoLuong.Text);
                pro.price = Int32.Parse(tbGiaSanPham.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu vui lòng nhập số");
                return;
            }
            pro.description = tbMoTa.Text;
            pro.ngay_san_xuat = dpNgaySanXuat.SelectedDate.Value;
            pro.han_su_dung = dpHanSuDung.SelectedDate.Value;
            pro.note = "";
            Producet.Detail detail = new Producet.Detail();
            detail.cong_nghe_man_hinh = tbCongNgheManHinh.Text;
            detail.do_phan_giai = tbDoPhanGiai.Text;
            detail.kich_thuoc_man = tbKichCoMan.Text;
            detail.os = tbHeDieuHanh.Text;
            detail.cpu = tbCPU.Text;
            detail.ram = tbRam.Text;
            detail.rom = tbRom.Text;
            detail.sim_card = tbSim.Text;
            detail.wifi = tbWifi.Text;
            detail.gps = tbGPS.Text;
            detail.bluetooth = tbBluetooth.Text;
            detail.battery_adapter = tbSac.Text;
            detail.headphone = tbTaiNghe.Text;
            detail.weight = tbTrongLuong.Text;
            detail.pin_name = tbTenPin.Text;
            detail.dung_luong_pin = tbDungLuongPin.Text;
            detail.cong_nghe_pin = tbCongNghePin.Text;
            detail.more_info = tbThongTinThem.Text;
            pro.detail = detail;
            Producet.Camera_Back back = new Producet.Camera_Back();
            back.do_phan_giai = tbBackDoPhanGiai.Text;
            back.flash = tbBackFlash.IsChecked.Value;
            back.quay_phim = tbBackQuayPhim.Text;
            back.tinh_nang = tbBackTinhNang.Text;
            Producet.Camera_Front front = new Producet.Camera_Front();
            front.do_phan_giai = tbFrontDoPhanGiai.Text;
            front.flash = tbFrontFlash.IsChecked.Value;
            front.quay_phim = tbFrontQuayPhim.Text;
            front.tinh_nang = tbFrontTinhNang.Text;
            detail.camera_back = back;
            detail.camera_front = front;

            String token = File.ReadAllText("Token.init");
            try
            {
                String output = await Controller.Controller.UpdateProduct(pro, token);
                ProductOutput.Rootobject user = JsonConvert.DeserializeObject<ProductOutput.Rootobject>(output);
                UpdateImages update = new UpdateImages(user.id + "", token, Update);
                update.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        private void Update()
        {
            update();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isShow)
            {
                stackTTChung.Visibility = Visibility.Collapsed;
                isShow = true;
            }
            else
            {
                stackTTChung.Visibility = Visibility.Visible;
                isShow = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isShow2)
            {
                stackCTSP.Visibility = Visibility.Collapsed;
                isShow2 = true;
            }
            else
            {
                stackCTSP.Visibility = Visibility.Visible;
                isShow2 = false;
            }
            
        }
    }
}
