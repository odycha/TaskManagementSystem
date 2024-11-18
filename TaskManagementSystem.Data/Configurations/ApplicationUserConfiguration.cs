using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementSystem.Data.Configurations;

public class ApplicationUserConfiguration :IEntityTypeConfiguration<ApplicationUser>
{
	public void Configure(EntityTypeBuilder<ApplicationUser> builder)
	{
		var hasher = new PasswordHasher<ApplicationUser>();
		builder.HasData(
			new ApplicationUser
			{
				Id = "384df32d-2a7c-4147-baf1-152db746565b",
				UserName = "admin@localhost.com",
				NormalizedUserName = "ADMIN@LOCALHOST.COM",
				Email = "admin@localhost.com",
				NormalizedEmail = "ADMIN@LOCALHOST.COM",
				EmailConfirmed = true,
				PasswordHash = hasher.HashPassword(null, "P@ssword1"),
				DateOfBirth = new DateOnly(2024,11,15),
				FirstName = "admin",
				LastName = "admin"
			});
	}





}
