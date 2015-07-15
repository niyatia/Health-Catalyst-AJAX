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

        static PersonContext()
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PersonContext>());
        }

        public DbSet<Person> Person { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Person>().HasKey(b => b.PersonID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
