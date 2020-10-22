using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.Controller
{
    public class Controller
    {
        public static async Task<String> Login(String username,String password)
        {
            try
            {
                return await Task.Run<String>(() => {
                    try
                    {
                        return RequestControl.POST("api/auth/login", "username=" + username + "&password=" + password, "application/x-www-form-urlencoded");
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }
                    
                });
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static async Task<String> UpdateProduct(Producet.Class1 pro,String token)
        {
            try
            {
                return await Task.Run<String>(() => { return RequestControl.POST(token, "api/products", pro, "application/json"); });
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static async Task<String> UpdateImages(String id,String[] imgs, String token)
        {
            try
            {
                return await Task.Run<String>(() => { return RequestControl.UploadFile(token, imgs, "api/products/"+id+"/images"); });
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static async Task<String> GetAllProduct()
        {
            try
            {
                return await Task.Run<String>(() => { return RequestControl.GET("api/products"); });
            }catch(Exception ex)
            {
                return "";
            }
        }
    }
}
