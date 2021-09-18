using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Item name")]
        public string ItemName { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }
    }
}
