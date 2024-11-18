using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementSystem.Data.Configurations;

public class IdentityRolesConfiguration : IEntityTypeConfiguration<IdentityRole>
{
	public void Configure(EntityTypeBuilder<IdentityRole> builder)
	{
		//HasData() adds seed data
		builder.HasData(
			new IdentityRole
			{
				Id = "e15ce2eb-3781-4351-a205-dc133f889d57",
				Name = "Administrator",
				NormalizedName = "ADMINISTRATOR"
				
			},
			new IdentityRole
			{
				Id = "335f4107-9914-4d65-9542-92db92194c0b",
				Name = "TaskManager",
				NormalizedName = "TASKMANAGER"

			},
			new IdentityRole
			{
				Id = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
				Name = "Employee",
				NormalizedName = "EMPLOYEE"

			}
			);
	}
}
