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
    public class SearchModel : PageModel
    {
        private readonly PrepForOnSiteContext _db;

        public SearchModel(PrepForOnSiteContext db)
        {
            _db = db;
        }

        public IList<Person> People { get; private set; }

        [TempData]
        public string SearchBy { get; set; }        //tempData 

        public async Task OnGetAsync()
        {
            People = await _db.Person.AsNoTracking().ToListAsync();
        }
    }
}