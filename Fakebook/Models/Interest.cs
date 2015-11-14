using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fakebook.Models
{
    public class Interest
    {
        [Required]
        public int InterestID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}