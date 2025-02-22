using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options) { }

    // DbSet for each table
    [Comment("Welcome table")]
    public virtual DbSet<Welcome> Welcomes { get; set; }

    [Comment("About table")]
    public virtual DbSet<About> Abouts { get; set; }

    [Comment("Front-end skills table")]
    public virtual DbSet<SkillsF> SkillsFs { get; set; }

    [Comment("Back-end skills table")]
    public virtual DbSet<SkillsB> SkillsBs { get; set; }

    [Comment("General skills table")]
    public virtual DbSet<SkillsG> SkillsGs { get; set; }

    [Comment("React TypeScript Projects table")]
    public virtual DbSet<ReactTsProject> ReactTsProjects { get; set; }

    [Comment("PHP Projects table")]
    public virtual DbSet<PhpProject> PhpProjects { get; set; }

    [Comment(".NET API Projects table")]
    public virtual DbSet<NetApiProject> NetApiProjects { get; set; }

    [Comment("Socials table")]
    public virtual DbSet<Social> Socials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configurations
    }
}
