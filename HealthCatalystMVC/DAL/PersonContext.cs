using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCatalystMVC.Models;

namespace HealthCatalystMVC
{
    public class PersonContext : DbContext
    {
        public PersonContext()
            : base("PersonContext")
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonInterest> Interests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Person>().HasKey(b => b.PersonID);

            modelBuilder.Entity<PersonInterest>().ToTable("Interest");
            modelBuilder.Entity<PersonInterest>().HasKey(b => b.InterestId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
