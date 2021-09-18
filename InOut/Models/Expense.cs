using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InOut.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Expense Name")]
        public string ExpenseName { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
