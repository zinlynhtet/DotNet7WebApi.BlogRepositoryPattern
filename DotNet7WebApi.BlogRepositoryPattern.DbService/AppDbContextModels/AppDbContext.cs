using Microsoft.EntityFrameworkCore;

namespace DotNet7WebApi.BlogRepositoryPattern.DbService.AppDbContextModels;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BlogDataModel> TblBlogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogDataModel>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("Tbl_Blogs");

            entity.Property(e => e.BlogAuthor).HasMaxLength(50);
            entity.Property(e => e.BlogContent).HasMaxLength(50);
            entity.Property(e => e.BlogTitle).HasMaxLength(50);
            entity.Property(e => e.Id).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
