using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.Model
{
    class ListProduct
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int id { get; set; }
            public string product_name { get; set; }
            public string company { get; set; }
            public string product_country { get; set; }
            public int? amount { get; set; }
            public Detail detail { get; set; }
            public float? price { get; set; }
            public string description { get; set; }
            public DateTime? ngay_san_xuat { get; set; }
            public DateTime? han_su_dung { get; set; }
            public string note { get; set; }
            public Image[] images { get; set; }
            public DateTime? createAt { get; set; }
            public DateTime? updateAt { get; set; }
        }

        public class Detail
        {
            public int id { get; set; }
            public string cong_nghe_man_hinh { get; set; }
            public string do_phan_giai { get; set; }
            public string kich_thuoc_man { get; set; }
            public Camera_Back camera_back { get; set; }
            public Camera_Front camera_front { get; set; }
            public string os { get; set; }
            public string cpu { get; set; }
            public string ram { get; set; }
            public string rom { get; set; }
            public string sim_card { get; set; }
            public string wifi { get; set; }
            public string gps { get; set; }
            public string bluetooth { get; set; }
            public string battery_adapter { get; set; }
            public string headphone { get; set; }
            public string weight { get; set; }
            public string pin_name { get; set; }
            public string dung_luong_pin { get; set; }
            public string cong_nghe_pin { get; set; }
            public string more_info { get; set; }
            public DateTime? createAt { get; set; }
            public DateTime? updateAt { get; set; }
        }

        public class Camera_Back
        {
            public int id { get; set; }
            public string do_phan_giai { get; set; }
            public string quay_phim { get; set; }
            public string flash { get; set; }
            public object tinh_nang { get; set; }
            public object createAt { get; set; }
            public object updateAt { get; set; }
        }

        public class Camera_Front
        {
            public int id { get; set; }
            public string do_phan_giai { get; set; }
            public string quay_phim { get; set; }
            public string flash { get; set; }
            public object tinh_nang { get; set; }
            public object createAt { get; set; }
            public object updateAt { get; set; }
        }

        public class Image
        {
            public int id { get; set; }
            public string url { get; set; }
            public object createAt { get; set; }
            public object updateAt { get; set; }
        }

    }
}
