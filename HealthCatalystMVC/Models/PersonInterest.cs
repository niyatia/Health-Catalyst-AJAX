using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalystMVC.Models
{
    public class PersonInterest
    {       
        public int InterestId { get; set; }
        public string Interest { get; set; }
        public int PersonId { get; set; }
        public virtual Person person { get; set; }
    }
}
