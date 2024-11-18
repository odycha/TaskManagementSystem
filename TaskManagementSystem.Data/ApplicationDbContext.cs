using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TaskManagementSystem.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	//Apply configuration for Data seeding
	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
		//instead of listing all confifurations apply from assembly - will scan for anything of type IEntityTypeConfiguration
		builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}



	public DbSet<TaskType> TaskTypes { get; set; }
}
