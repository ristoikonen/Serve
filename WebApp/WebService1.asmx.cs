using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        // https://localhost:44392/WebService1.asmx/HelloWorld
        [WebMethod]
        public UserModel NewUser(string userName)
        {
            UserModel user = new UserModel();
            user.Name = userName;
            user.Email = user.Name + "_initial@company.com";
            return user;
        }


        [WebMethod]
        public List<UserModel> NewUsers()
        {
            List<UserModel> l = new List<UserModel>() {
                new UserModel() { Name = "Joenne Lloyd", Email = "joennel_init@company.com"} ,
                new UserModel() { Name = "Kieran Albeni", Email = "kierana_init@company.com"} ,
                new UserModel() { Name = "Vernon Tompson", Email = "vernont_init@company.com"} ,
            };
            return l;
        }

        [WebMethod]
        public List<string> HelloArray()
        {
            string[] strings = new string[3];
            strings[0] = "Hello";
            strings[1] = "d";
            strings[2] = "dd";

            return strings.ToList<string>();
        }


        //public ResponseModel<string> login(string email, string password)
        //{
        //    ResponseModel<string> response = new ResponseModel<string>();
        //    if (email == "admin" && password == "admin")
        //    {
        //        response.ResultCode = 1;
        //        response.Message = "Login Success";
        //        response.Data = "Welcome Admin";
        //    }
        //    else
        //    {
        //        response.ResultCode = 0;
        //        response.Message = "Login Failed";
        //        response.Data = "Invalid Email or Password";
        //    }
        //}



        public class ResponseModel<T>
        {
            public T Data { get; set; }
            public int ResultCode { get; set; }
            public string Message { get; set; }
        }
        public class UserModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
