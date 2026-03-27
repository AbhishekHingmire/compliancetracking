using Microsoft.EntityFrameworkCore;
using RegWatch.Web.Models.Entities;

namespace RegWatch.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<User> Users => Set<User>();
    public DbSet<RegulatoryBody> RegulatoryBodies => Set<RegulatoryBody>();
    public DbSet<Regulation> Regulations => Set<Regulation>();
    public DbSet<Alert> Alerts => Set<Alert>();
    public DbSet<Deadline> Deadlines => Set<Deadline>();
    public DbSet<NotificationPreference> NotificationPreferences => Set<NotificationPreference>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<ScrapeLog> ScrapeLogs => Set<ScrapeLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User unique email
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique()
            .HasDatabaseName("users_email");

        // Alert unique constraint on (TenantId, RegulationId)
        modelBuilder.Entity<Alert>()
            .HasIndex(a => new { a.TenantId, a.RegulationId })
            .IsUnique()
            .HasDatabaseName("alerts_tenant_regulation_unique");

        // Alert indexes
        modelBuilder.Entity<Alert>()
            .HasIndex(a => new { a.TenantId, a.Status })
            .HasDatabaseName("alerts_tenant_status");

        modelBuilder.Entity<Alert>()
            .HasIndex(a => a.CreatedAt)
            .HasDatabaseName("alerts_created");

        // Regulation indexes
        modelBuilder.Entity<Regulation>()
            .HasIndex(r => r.PublishedAt)
            .HasDatabaseName("regulations_published");

        modelBuilder.Entity<Regulation>()
            .HasIndex(r => r.RegulatoryBodyId)
            .HasDatabaseName("regulations_body");

        // Deadline index
        modelBuilder.Entity<Deadline>()
            .HasIndex(d => new { d.TenantId, d.DueDate })
            .HasDatabaseName("deadlines_tenant_due");

        // RegulatoryBody unique code
        modelBuilder.Entity<RegulatoryBody>()
            .HasIndex(r => r.Code)
            .IsUnique();

        // Relationships
        modelBuilder.Entity<User>()
            .HasOne(u => u.NotificationPreference)
            .WithOne(n => n.User)
            .HasForeignKey<NotificationPreference>(n => n.UserId);

        modelBuilder.Entity<Alert>()
            .HasOne(a => a.Tenant)
            .WithMany(t => t.Alerts)
            .HasForeignKey(a => a.TenantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Alert>()
            .HasOne(a => a.Regulation)
            .WithMany(r => r.Alerts)
            .HasForeignKey(a => a.RegulationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Deadline>()
            .HasOne(d => d.Tenant)
            .WithMany(t => t.Deadlines)
            .HasForeignKey(d => d.TenantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Tenant)
            .WithMany(t => t.Invoices)
            .HasForeignKey(i => i.TenantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Subscription)
            .WithMany()
            .HasForeignKey(i => i.SubscriptionId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Subscription>()
            .HasOne(s => s.Tenant)
            .WithMany(t => t.Subscriptions)
            .HasForeignKey(s => s.TenantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Regulation>()
            .HasOne(r => r.RegulatoryBody)
            .WithMany(b => b.Regulations)
            .HasForeignKey(r => r.RegulatoryBodyId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ScrapeLog>()
            .HasOne(s => s.RegulatoryBody)
            .WithMany(b => b.ScrapeLogs)
            .HasForeignKey(s => s.RegulatoryBodyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
