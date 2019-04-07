using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrepForOnSite.Pages
{
    public class IndexModel : PageModel
    {
        public string Message = "Welcome to home page";

        public void OnGet()
        {
            Response.Cookies.Append("TestCookie", "Welcome back to home page"); //write cookie

            if(Request.Cookies["TestCookie"]!=null) //retreive cookie
            {
                Message = Request.Cookies["TestCookie"];
            }

        }
    }
}