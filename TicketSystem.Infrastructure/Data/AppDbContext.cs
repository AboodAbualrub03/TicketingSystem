using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicktingSystem.Domain.Models;

public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Ticket>()
            .HasOne(t=>t.Customer)
            .WithMany(u=>u.CustomerTickets)
            .HasForeignKey(u=>u.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Agent)
            .WithMany(a => a.AgentTickets)
            .HasForeignKey(a => a.AgentId)
            .OnDelete(DeleteBehavior.Restrict);
        
    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketComment> TicketComments { get; set; }
    public DbSet<Category> Categories { get; set; }
}