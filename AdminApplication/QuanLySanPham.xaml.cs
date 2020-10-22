using AdminApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdminApplication
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public delegate void UpdateInfor();
    public partial class QuanLySanPham : Window
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }
        List<ListProduct.Class1> test = new List<ListProduct.Class1>();


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Producet.Class1 pro = new Producet.Class1();
            //pro.product_name = uscThemSanPham.tbTenSanPham.Text;
            //pro.product_country = uscThemSanPham.tbNoiSanXuat.Text;
            //pro.company = uscThemSanPham.tbCongTySanXuat.Text;
            //pro.amount = Int32.Parse(uscThemSanPham.tbSoLuong.Text);
            //pro.price = Int32.Parse(uscThemSanPham.tbGiaSanPham.Text);
            //pro.description = uscThemSanPham.tbMoTa.Text;
            //pro.ngay_san_xuat = uscThemSanPham.dpNgaySanXuat.SelectedDate.Value;
            //pro.han_su_dung = uscThemSanPham.dpHanSuDung.SelectedDate.Value;
            //pro.note = "";
            //Producet.Detail detail = new Producet.Detail();
            //detail.cong_nghe_man_hinh = uscThemSanPham.tbCongNgheManHinh.Text;
            //detail.do_phan_giai = uscThemSanPham.tbDoPhanGiai.Text;
            //detail.kich_thuoc_man = uscThemSanPham.tbKichCoMan.Text;
            //detail.os = uscThemSanPham.tbHeDieuHanh.Text;
            //detail.cpu = uscThemSanPham.tbCPU.Text;
            //detail.ram = uscThemSanPham.tbRam.Text;
            //detail.rom = uscThemSanPham.tbRom.Text;
            //detail.sim_card = uscThemSanPham.tbSim.Text;
            //detail.wifi = uscThemSanPham.tbWifi.Text;
            //detail.gps = uscThemSanPham.tbGPS.Text;
            //detail.bluetooth = uscThemSanPham.tbBluetooth.Text;
            //detail.battery_adapter = uscThemSanPham.tbSac.Text;
            //detail.headphone = uscThemSanPham.tbTaiNghe.Text;
            //detail.weight = uscThemSanPham.tbTrongLuong.Text;
            //detail.pin_name = uscThemSanPham.tbTenPin.Text;
            //detail.dung_luong_pin = uscThemSanPham.tbDungLuongPin.Text;
            //detail.cong_nghe_pin = uscThemSanPham.tbCongNghePin.Text;
            //detail.more_info = uscThemSanPham.tbThongTinThem.Text;
            //pro.detail = detail;
            //String token = File.ReadAllText("Token.init");
            //try
            //{
            //    String output = await Controller.Controller.UpdateProduct(pro, token);
            //    ProductOutput.Rootobject user = JsonConvert.DeserializeObject<ProductOutput.Rootobject>(output);
            //    UpdateImages update = new UpdateImages(user.id + "", token, Update);
            //    update.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                String output = await Controller.Controller.GetAllProduct();
                File.WriteAllText("out.txt", output);
                List<ListProduct.Class1> list = JsonConvert.DeserializeObject<List<ListProduct.Class1>>(output);
                test.AddRange(list);
                dgSanPham.ItemsSource = test;
                uscThemSanPham.update = UpdateInfor;
                this.uscThemSanPham.btnSend.IsDefault = true;
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void Update()
        {
            UpdateInfor();
        }

        private async void UpdateInfor()
        {
            try
            {
                String output = await Controller.Controller.GetAllProduct();
                File.WriteAllText("out.txt", output);
                List<ListProduct.Class1> list = JsonConvert.DeserializeObject<List<ListProduct.Class1>>(output);
                test.Clear();
                test.AddRange(list);
                dgSanPham.Dispatcher.Invoke(() => {
                    dgSanPham.Items.Clear();
                    dgSanPham.Items.Add(list);
                    dgSanPham.Items.Refresh();
                });
                
                
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
