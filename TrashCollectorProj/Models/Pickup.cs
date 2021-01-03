using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProj.Models
{
    public class Pickup
    {
        [Key]
        public int Id { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        [ForeignKey("IdentityUser")]
        public int IdentityUser { get; set; }
    }
}
