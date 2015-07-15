using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HealthCatalystMVC.Models
{
    public class Person
    {
        [DisplayName("PersonID")]
        public int PersonID { get; set; }

        [DisplayName("FirstName")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DisplayName("LastName")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Age")]
        public int? Age { get; set; }
        [DisplayName("Photo")]
        public string Photo { get; set; }
        [DisplayName("Interests")]
        public string Interests { get; set; }

    }
}
