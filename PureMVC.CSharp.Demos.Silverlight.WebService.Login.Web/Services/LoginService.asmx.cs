/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿using System;
using System.Web.Services;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Web.Model.Dto;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Web.Services
{
    [WebService(Namespace = "http://www.puremvc.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {
        [WebMethod]
        public LoginDto DoLogin(LoginDto loginDto)
        {
            if (loginDto.Username != "admin" || loginDto.Password != "admin")
                throw new ApplicationException("Invalid Username and/or Password");

            loginDto.LoginDate = DateTime.Now;

            return loginDto;
        }
    }
}
