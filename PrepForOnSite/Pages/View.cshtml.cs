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
    public class ViewModel : PageModel
    {
        private readonly PrepForOnSiteContext _db;

        public ViewModel(PrepForOnSiteContext db)
        {
            _db = db;
        }

        public IList<Person> People { get; private set; }

        [BindProperty]
        public string SearchName { get; set; }

        [TempData]
        public string SearchBy { get; set; }        //tempData 

        public async Task OnGetAsync()
        {
            People = await _db.Person.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            SearchBy = SearchName;              // alocating value to tempData -> goes to Search page
            return RedirectToPage("/Search");
        }
    }
}