using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JosephRueResume.Models
{
    public class ContactInfo
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Street Address")]
        public string StreetAddress { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
