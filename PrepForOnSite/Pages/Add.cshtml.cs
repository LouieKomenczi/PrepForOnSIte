using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrepForOnSite.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PrepForOnSite.Pages
{
    public class AddModel : PageModel
    {
        private readonly PrepForOnSiteContext _db;

        public AddModel(PrepForOnSiteContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Person Person { get; set; } = new Person();

        public IList<Person> People { get; private set; }




        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Person.Add(Person);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Result");
            }
            else
            {
                return Page();
            }

        }
    }
}