using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        // have to tell EF explicitly the name of the conn string b/c it is different than the context
        public PlutoContext()
            : base("name=DefaultConnection")
        {

        }
    }
}
