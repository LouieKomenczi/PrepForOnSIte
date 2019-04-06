using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepForOnSite.Models
{
    public class PrepForOnSiteContext:DbContext
    {
        public PrepForOnSiteContext(DbContextOptions<PrepForOnSiteContext> options): base(options)
        {        }

        public DbSet<Person> Person { get; set; }
    }
}
