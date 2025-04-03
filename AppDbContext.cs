using Microsoft.EntityFrameworkCore;
using OTPProject;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Otp> Otp { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}