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
				LastName = "admin",
                DepartmentName = "IT Support",
				SkillLevel = 10
            },
            new ApplicationUser
            {
                Id = "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                UserName = "taskManager@localhost.com",
                NormalizedUserName = "TASKMANAGER@LOCALHOST.COM",
                Email = "taskManager@localhost.com",
                NormalizedEmail = "TASKMANAGER@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(2024, 11, 15),
                FirstName = "taskManager",
                LastName = "taskManager",
                DepartmentName = "IT Support",
                SkillLevel = 10
            },
            new ApplicationUser
            {
                Id = "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                UserName = "empl1@localhost.com",
                NormalizedUserName = "EMPL1@LOCALHOST.COM",
                Email = "empl1@localhost.com",
                NormalizedEmail = "EMPL1@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1998, 11, 20),
                FirstName = "empl1",
                LastName = "empl1",
                DepartmentName = "IT Support",
                SkillLevel = 7
            },
            new ApplicationUser
            {
                Id = "68ed7806-e19b-4610-8146-e999b0732379",
                UserName = "empl2@localhost.com",
                NormalizedUserName = "EMPL2@LOCALHOST.COM",
                Email = "empl2@localhost.com",
                NormalizedEmail = "EMPL2@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1990, 11, 15),
                FirstName = "empl2",
                LastName = "empl2",
                DepartmentName = "IT Support",
                SkillLevel = 9
            },
            new ApplicationUser
            {
                Id = "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                UserName = "empl3@localhost.com",
                NormalizedUserName = "EMPL3@LOCALHOST.COM",
                Email = "empl3@localhost.com",
                NormalizedEmail = "EMPL3@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1995, 01, 15),
                FirstName = "empl3",
                LastName = "empl3",
                DepartmentName = "IT Support",
                SkillLevel = 6
            },
            new ApplicationUser
            {
                Id = "06827f01-662b-4641-abce-b1c496f28660",
                UserName = "empl4@localhost.com",
                NormalizedUserName = "EMPL4@LOCALHOST.COM",
                Email = "empl4@localhost.com",
                NormalizedEmail = "EMPL4@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1999, 11, 15),
                FirstName = "empl4",
                LastName = "empl4",
                DepartmentName = "Development",
                SkillLevel = 10
            },
            new ApplicationUser
            {
                Id = "fd65ce29-7600-446a-a89f-f3422bead07e",
                UserName = "empl5@localhost.com",
                NormalizedUserName = "EMPL5@LOCALHOST.COM",
                Email = "empl5@localhost.com",
                NormalizedEmail = "EMPL5@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(2000, 11, 15),
                FirstName = "empl5",
                LastName = "empl5",
                DepartmentName = "Development",
                SkillLevel = 6
            },
            new ApplicationUser
            {
                Id = "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                UserName = "empl6@localhost.com",
                NormalizedUserName = "EMPL6@LOCALHOST.COM",
                Email = "empl6@localhost.com",
                NormalizedEmail = "EMPL6@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1999, 03, 22),
                FirstName = "empl6",
                LastName = "empl6",
                DepartmentName = "Development",
                SkillLevel = 7
            },
            new ApplicationUser
            {
                Id = "873d2b23-002a-477f-856e-5ed602b5405c",
                UserName = "empl7@localhost.com",
                NormalizedUserName = "EMPL7@LOCALHOST.COM",
                Email = "empl7@localhost.com",
                NormalizedEmail = "EMPL7@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1980, 10, 20),
                FirstName = "empl7",
                LastName = "empl7",
                DepartmentName = "Development",
                SkillLevel = 7
            },
            new ApplicationUser
            {
                Id = "336722d0-5991-49a5-ab55-d7414b598c63",
                UserName = "empl8@localhost.com",
                NormalizedUserName = "EMPL8@LOCALHOST.COM",
                Email = "empl8@localhost.com",
                NormalizedEmail = "EMPL8@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1997, 08, 08),
                FirstName = "empl8",
                LastName = "empl8",
                DepartmentName = "Marketing",
                SkillLevel = 10
            },
            new ApplicationUser
            {
                Id = "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                UserName = "empl9@localhost.com",
                NormalizedUserName = "EMPL9@LOCALHOST.COM",
                Email = "empl9@localhost.com",
                NormalizedEmail = "EMPL9@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1989, 11, 15),
                FirstName = "empl9",
                LastName = "empl9",
                DepartmentName = "Marketing",
                SkillLevel = 7
            },
            new ApplicationUser
            {
                Id = "102075be-a710-4035-87e0-25f7295074e6",
                UserName = "empl10@localhost.com",
                NormalizedUserName = "EMPL10@LOCALHOST.COM",
                Email = "empl10@localhost.com",
                NormalizedEmail = "EMPL10@LOCALHOST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                DateOfBirth = new DateOnly(1999, 07, 22),
                FirstName = "empl10",
                LastName = "empl10",
                DepartmentName = "Marketing",
                SkillLevel = 6
            });
    }





}
