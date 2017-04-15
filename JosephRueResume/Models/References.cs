using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JosephRueResume.Models
{
    public class References
    {
        public int ID  { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        [Display(Name ="Email Address")]
        public string Emailaddress { get; set; }

    }
}
