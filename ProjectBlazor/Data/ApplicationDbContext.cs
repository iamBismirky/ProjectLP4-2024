using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectBlazor.Entities;

namespace ProjectBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
		public DbSet<Vehiculo> Vehiculos { get; set; }
		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
