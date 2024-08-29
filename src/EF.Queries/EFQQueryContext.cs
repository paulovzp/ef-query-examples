using Microsoft.EntityFrameworkCore;

namespace EF.Queries;

public class EFQQueryContext : DbContext
{
    public EFQQueryContext(DbContextOptions options)
        : base(options)
    {
    }
    public EFQQueryContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Data Source=172.20.0.2;Initial Catalog=EFQueryDB;Persist Security Info=True;User ID=sa;Password=@PWD_DATABASE;Connection Timeout=10000");
        optionsBuilder.UseSqlServer("Server=localhost;Database=EFQueryDB;User Id=sa;Password=@PWD-DATABASE!9;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(EFQQueryContext).Assembly);

        base.OnModelCreating(builder);
    }
}
