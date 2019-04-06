using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrepForOnSite.Models;

namespace PrepForOnSite.Pages
{
    public class ResultModel : PageModel
    {
        public Person Person { get; set; } = new Person();

        private readonly PrepForOnSiteContext _db;

        public ResultModel(PrepForOnSiteContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Person = await _db.Person.FindAsync(id); //find in db the record with id
            return Page();
        }
    }
}