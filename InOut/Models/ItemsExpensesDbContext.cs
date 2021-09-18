using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InOut.Models
{
    public class ItemsExpensesDbContext:DbContext
    {
        
        public ItemsExpensesDbContext(DbContextOptions<ItemsExpensesDbContext> opt):base(opt)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
    }
}
