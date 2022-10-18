using Microsoft.EntityFrameworkCore;

namespace MvcLabManager.Models;

public class LabManagerContext : DbContext 
{
    public DbSet<Computer> Computers { get; set; }
    
    public LabManagerContext(DbContextOptions<LabManagerContext> options) : base(options) {
        // chama o construtor da classe que está sendo herdada - base ( é equivalante ao super em Java)

    }
}
