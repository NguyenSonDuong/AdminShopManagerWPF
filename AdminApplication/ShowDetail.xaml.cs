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
using xNet;

namespace AdminApplication
{
    /// <summary>
    /// Interaction logic for UpdateDetail.xaml
    /// </summary>
    public partial class UpdateDetail : Window
    {
        public UpdateDetail()
        {
            HttpRequest http = RequestControl.GetRequest("SIDCC=AJi4QfGdQXwRyPlX0lpInsMIaZmDwW1JpURwFSTChHm6HMI3jpsvg6tY9FcftGOxZEtZeYKu; __utma=245730968.235269561.1601973794.1601973794.1601973794.1; __utmb=245730968.1.10.1601973794; __utmc=245730968; __utmz=245730968.1601973794.1.1.utmcsr=OGB|utmccn=(not%20set)|utmcmd=act|utmctr=(not%20provided); OTZ=5661163_28_28__28_; __utmt_t0=1; SID=1wekzkMC4FTa8ch3tqf20iCujqbv_KLcAnqBqMDC7W9t-v3rpQ_kUYo6jCYRN_4eD79s5g.; APISID=mYmS3YZ0SujqD4R4/A2Gv37TuJ5BSuB-Mr; SAPISID=fP7x-sdJJDqtz3dp/Ay34Du1vgPdXeaalv; __Secure-3PAPISID=fP7x-sdJJDqtz3dp/Ay34Du1vgPdXeaalv; CONSENT=YES+VN.en+20180325-05-0", "");
            String a = http.Get("https://accounts.google.com/").ToString();
            MessageBox.Show("");
            InitializeComponent();
        }
    }
}
