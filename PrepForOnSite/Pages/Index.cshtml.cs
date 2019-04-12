using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrepForOnSite.Pages
{
    public class IndexModel : PageModel
    {
        public string Message = "Welcome to home page";

        public void OnGet()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(1);

            Response.Cookies.Append("TestCookie", "Welcome back to home page", options); //write cookie

            if(Request.Cookies["TestCookie"]!=null) //retreive cookie
            {
                Message = Request.Cookies["TestCookie"];
            }

        }
    }
}