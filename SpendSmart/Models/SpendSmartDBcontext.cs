using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SpendSmart.Models
{
    public class SpendSmartDBcontext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDBcontext(DbContextOptions<SpendSmartDBcontext> options) 
            : base(options)
        {
            
        }
    }
}
