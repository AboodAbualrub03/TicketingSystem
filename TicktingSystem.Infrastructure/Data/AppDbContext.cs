using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TicktingSystem.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace TicktingSystem.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int, int>>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
