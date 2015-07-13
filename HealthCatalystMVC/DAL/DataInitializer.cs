using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HealthCatalystMVC.Models;

namespace HealthCatalystMVC.DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            base.Seed(context);

            var persons = new List<Person>
            {
                new Person{FirstName = "Niyati", LastName ="Acharya", Age =25, Address="2230, 4th Ave"},
                new Person{FirstName = "Hiral", LastName ="Jhaveri", Age =12, Address="2230, 5th Ave"},
                new Person{FirstName = "Gina", LastName ="Takasugi", Age =35, Address="700, Westlake Ave"},
                new Person{FirstName = "Gulbin", LastName ="Yasar", Age =20, Address="101, Minor Ave"},

            };

            persons.ForEach(p => context.Person.Add(p));
            context.SaveChanges();

            var interests = new List<PersonInterest>
            {
                new PersonInterest{PersonId = 1, Interest="Reading"},
                new PersonInterest{PersonId = 1, Interest="Cooking"},
                new PersonInterest{PersonId = 2, Interest="Internet surfing"},
                new PersonInterest{PersonId = 2, Interest="Kayaking"},
                new PersonInterest{PersonId = 2, Interest="Horse Riding"},
                new PersonInterest{PersonId = 3, Interest="Painting"},
                new PersonInterest{PersonId = 4, Interest="Hiking"},
                new PersonInterest{PersonId = 4, Interest="Sky Diving"},
                new PersonInterest{PersonId = 3, Interest="Reading"},
                new PersonInterest{PersonId = 1, Interest="Singing"},
            };

            interests.ForEach(i => context.Interests.Add(i));
            context.SaveChanges();
        }
    }
}