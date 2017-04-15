using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using JosephRueResume.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace JosephRueResume.ViewModels
{
    [NotMapped]
    public class Resume
    {
        public int ID { get; set; }
        public List<ContactInfo> ContactInfo { get; set; }
        public List<jobs> jobs { get; set; }
        public List<References> References { get; set; }
    }
}
