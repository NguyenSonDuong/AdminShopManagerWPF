using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace AdminApplication
{
    public class RequestControl
    {
        public static String HOST = "http://192.168.100.21:8181/";

        public static HttpRequest GetRequest(String cookie, String token)
        {
            HttpRequest http = new HttpRequest();
            http.Cookies = new CookieDictionary();
            if (!String.IsNullOrEmpty(cookie))
                AddCookie(http, cookie);
            if (!String.IsNullOrEmpty(token))
                http.AddHeader("Authorization", "Bearer " + token);
            return http;
        }

        public static void AddCookie(HttpRequest http, string cookie)
        {
            var temp = cookie.Split(';');
            foreach (var item in temp)
            {
                var temp2 = item.Split('=');
                if (temp2.Count() > 1)
                {
                    http.Cookies.Add(temp2[0], temp2[1]);
                }
            }
        }

        public static String POST(String para, String body, String content_type)
        {
            try
            {
                HttpRequest http = GetRequest("", "");
                String data = http.Post(HOST + para, body, content_type).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GET(String para)
        {
            try
            {
                HttpRequest http = GetRequest("", "");
                String data = http.Get(HOST + para).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GET(String token,String para)
        {
            try
            {
                HttpRequest http = GetRequest("", token);
                String data = http.Post(HOST + para).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String POST(String token, String para, Object body, String content_type)
        {
            try
            {
                HttpRequest http = GetRequest("", token);
                String data = http.Post(HOST + para, JsonConvert.SerializeObject(body), content_type).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String UploadFile(String token, String[] path, String para)
        {
            HttpRequest http = GetRequest("", token);
            MultipartContent munti = new MultipartContent()
            {
            };
            foreach (String item in path)
            {
                munti.Add(new FileContent(item), "files", Path.GetFileName(item));
            }
            try
            {
                String data = http.Post(HOST + para, munti).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
public class ProductOutput
{

    public class Rootobject
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string company { get; set; }
        public string product_country { get; set; }
        public string amount { get; set; }
        public Detail detail { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public DateTime ngay_san_xuat { get; set; }
        public DateTime han_su_dung { get; set; }
        public string note { get; set; }
        public object[] images { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
    }

    public class Detail
    {
        public int id { get; set; }
        public string cong_nghe_man_hinh { get; set; }
        public string do_phan_giai { get; set; }
        public string kich_thuoc_man { get; set; }
        public object camera_back { get; set; }
        public object camera_front { get; set; }
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
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
    }

}
public class Producet
{
    public class Class1
    {
        public string product_name { get; set; }
        public String company { get; set; }
        public String product_country { get; set; }
        public int amount { get; set; }
        public Detail detail { get; set; }
        public long price { get; set; }
        public String description { get; set; }
        public DateTime ngay_san_xuat { get; set; }
        public DateTime han_su_dung { get; set; }
        public object note { get; set; }

    }

    public class Detail
    {
        public object cong_nghe_man_hinh { get; set; }
        public object do_phan_giai { get; set; }
        public string kich_thuoc_man { get; set; }
        public Camera_Back camera_back { get; set; }
        public Camera_Front camera_front { get; set; }
        public object os { get; set; }
        public object cpu { get; set; }
        public object ram { get; set; }
        public object rom { get; set; }
        public object sim_card { get; set; }
        public object wifi { get; set; }
        public object gps { get; set; }
        public object bluetooth { get; set; }
        public object battery_adapter { get; set; }
        public object headphone { get; set; }
        public object weight { get; set; }
        public object pin_name { get; set; }
        public object dung_luong_pin { get; set; }
        public object cong_nghe_pin { get; set; }
        public object more_info { get; set; }
    }

    public class Camera_Back
    {
        public string do_phan_giai { get; set; }
        public string quay_phim { get; set; }
        public bool flash { get; set; }
        public object tinh_nang { get; set; }
    }

    public class Camera_Front
    {
        public string do_phan_giai { get; set; }
        public string quay_phim { get; set; }
        public bool flash { get; set; }
        public object tinh_nang { get; set; }
    }

}
public class User
{

    public class Rootobject
    {
        public bool status { get; set; }
        public string message { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public object phoneNumber { get; set; }
        public object email { get; set; }
        public object address { get; set; }
        public string permission { get; set; }
        public object avatar { get; set; }
        public object createAt { get; set; }
        public object updateAt { get; set; }
    }

}

#region Upfile cacsh khacs
//HttpClient httpClient = new HttpClient();
//MultipartFormDataContent form = new MultipartFormDataContent();
//byte[] bt = File.ReadAllBytes(@"C:\Users\NguyenSonDuong\Documents\WinformProject\MemoryChange\AdminApplication\AdminApplication\bin\Debug\Pixiv_84678015.png");
//form.Add(new StringContent("1"), "id");
//form.Add(new ByteArrayContent(bt, 0, bt.Length), "file", "hello1.jpg");
//HttpResponseMessage response = await  httpClient.PostAsync("http://192.168.1.69:8080/admin/post-images", form);
//response.EnsureSuccessStatusCode();
//httpClient.Dispose();
//string sd = response.Content.ReadAsStringAsync().Result;
#endregion