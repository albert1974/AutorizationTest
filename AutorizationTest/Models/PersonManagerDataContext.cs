using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutorizationTest.Models
{
    public class PersonManagerDataContext : DbContext
    {
        public PersonManagerDataContext()
            : base("name=SqlConnection")
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}