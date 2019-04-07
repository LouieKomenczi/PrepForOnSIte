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
        public Person Person { get; set; } = new Person();          //creating our person object

        public IList<Person> People { get; private set; }           

        [BindProperty]
        [Required]
        public bool[] DriverLicenceSelected { get; set; } = { false, false, false, false, false};   //arrya of bools checking for textbox selected 
        public string[] DriversLicenceOptions { get; set; } = { "A", "B", "C", "D", "E" };          //array of string holding the values for textbox


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            for (int i = 0; i < 5; i++)
                if (DriverLicenceSelected[i]) Person.DriversLicence += DriversLicenceOptions[i] + " "; //retreiving texbox input 

            if (ModelState.IsValid)
            {
                _db.Person.Add(Person);
                await _db.SaveChangesAsync();
                return RedirectToPage("./Result", new { id = Person.ID}); /*route parameter set here, go to result page*/
            }
            else
            {
                return Page();
            }

        }
    }
}