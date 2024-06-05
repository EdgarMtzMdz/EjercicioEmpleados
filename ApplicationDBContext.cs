using Microsoft.EntityFrameworkCore;

namespace EmpleadosEj;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Empleados> Empleados { get; set; }
}

