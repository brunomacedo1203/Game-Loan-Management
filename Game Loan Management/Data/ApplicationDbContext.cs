using Game_Loan_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Game_Loan_Management.Data
{
    public class ApplicationDbContext : DbContext
    {   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<LoanModel> Loans { get; set; }
    }
}
