using lab7.Models;
using System.Data.Entity;

public class SchoolContext : DbContext
{
    public DbSet<UniversityCampus> UniversityCampuses { get; set; }
    public DbSet<Student> Students { get; set; }

    // 配置连接字符串
    public SchoolContext()
        : base("SchoolContext")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // 配置一对多关系
        modelBuilder.Entity<Student>()
            .HasRequired(s => s.UniversityCampus)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.UniversityCampusID);
    }
}
