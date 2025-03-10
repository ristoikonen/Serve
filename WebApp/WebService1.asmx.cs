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


        [WebMethod]
        public UserModel NewUser(string userName)
        {
            UserModel user = new UserModel();
            user.Name = userName;
            user.Email = user.Name + "_initial@company.com";
            return user;
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
