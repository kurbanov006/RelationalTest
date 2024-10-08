using MainApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MainApp.AddDbContext;

public class AppDbContext : DbContext
{
    // one to one
    // public DbSet<User> Users { get; set; }
    // public DbSet<Profile> Profiles { get; set; }
    
    // // one to many
    // public DbSet<Author> Authors { get; set; }
    // public DbSet<Book> Books { get; set; }
    
    // many to many
    public DbSet<Group> Groups { get; set; }
    public DbSet<Mentor> Mentors { get; set; }
    public DbSet<MentorGroup> MentorGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=relational_db; Username=postgres; Password=12345");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // one to one
        // modelBuilder.Entity<User>().HasOne(u => u.Profile)
        //     .WithOne(p => p.User)
        //     .HasForeignKey<Profile>(p => p.UserId);
        
        
        // one to many
        // modelBuilder.Entity<Author>()
        //     .HasMany(a => a.Book)
        //     .WithOne(b => b.Author)
        //     .HasForeignKey(x => x.AuthorId);
        
        
        
        // many to many
        modelBuilder.Entity<Mentor>()
            .HasMany(x => x.MentorGroups)
            .WithOne(x => x.Mentor)
            .HasForeignKey(x => x.MentorId)
            .IsRequired();

        modelBuilder.Entity<Group>()
            .HasMany(x => x.MentorGroups)
            .WithOne(x => x.Group)
            .HasForeignKey(x => x.GroupId)
            .IsRequired();
    }
}