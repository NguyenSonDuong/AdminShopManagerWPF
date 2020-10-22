
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AdminApplication
{
    /// <summary>
    /// Interaction logic for UpdateImages.xaml
    /// </summary>
    public partial class UpdateImages : Window
    {
        private string id;
        private String token;
        public bool status = false;
        public UpdateImages()
        {
            InitializeComponent();
        }
        public UpdateInfor update;
        public UpdateImages(String id, String token,UpdateInfor update1)
        {
            this.token = token;
            this.id = id;
            this.update = update1;
            InitializeComponent();
        }
        String[] files;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Multiselect = true;
            if(openFileDlg.ShowDialog() == true)
            {
                files = openFileDlg.FileNames;
                foreach(String item in files)
                {
                    tbFiles.AppendText(item+"|");
                }

            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                String output = await Controller.Controller.UpdateImages(id, files, token);
                status = true;
                this.Close();
            }catch(Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
    }
}
