using AdminApplication.Controller;
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
using xNet;
namespace AdminApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            String username = tbTenDN.Text;
            String password = tbPass.Password;
            try
            {
                string data = await Controller.Controller.Login(username, password);
                if (!String.IsNullOrEmpty(data))
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    return;
                }

                File.WriteAllText("Token.init", data);
                QuanLySanPham main = new QuanLySanPham();
                main.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới server");
                return;
            }
            
        }

        private void btnDangNhap_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Token.init"))
            {
                //QuanLySanPham main2 = new QuanLySanPham();
                //main2.Show();
                //this.Hide();
            }
        }
    }


}

