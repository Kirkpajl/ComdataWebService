using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekdox.Prime.Data.Entities
{
    public class ApplicationUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Comdata Codeword")]
        public string ComdataCodeword { get; set; }



        [Display(Name = "Full Name")]
        public string FullName => string.Format("{0}, {1}", LastName, FirstName);

        public string Initials => string.Format("{0}{1}", FirstName.ToUpper().ToCharArray().FirstOrDefault(), LastName.ToUpper().ToCharArray().FirstOrDefault());
    }
}
