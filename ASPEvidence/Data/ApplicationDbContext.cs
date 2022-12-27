using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPEvidence.Models;

namespace ASPEvidence.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPEvidence.Models.Users> Users { get; set; }
        public DbSet<ASPEvidence.Models.Insurance> Insurance { get; set; }
    }
}