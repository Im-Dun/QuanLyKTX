using QuanLyKTX.Models;
using Microsoft.EntityFrameworkCore;

namespace QuanLyKTX.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Room> Rooms { get; set; }

    public DbSet<Student> Students { get; set; }

    public DbSet<Registration> Registrations { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<User> Users { get; set; }
}