using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProj.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name ="Last Name")]
        public string lastName { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        [Display(Name ="Customer ID")]
        public IdentityUser IdentityUser { get; set; }
    }
}
