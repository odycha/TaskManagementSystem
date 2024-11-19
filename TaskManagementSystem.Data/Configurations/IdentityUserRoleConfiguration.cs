using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementSystem.Data.Configurations;
//Here we also have to specify the type of the key
//set admin user to role admin
public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e15ce2eb-3781-4351-a205-dc133f889d57",
                    UserId = "384df32d-2a7c-4147-baf1-152db746565b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "335f4107-9914-4d65-9542-92db92194c0b",
                    UserId = "16914ec6-4686-4c2c-ba58-5a9c3c15f404"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "4c5d1a8e-4f28-4ed5-8427-b72f0df86619"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "68ed7806-e19b-4610-8146-e999b0732379"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "4d7b0c08-5565-420b-854e-10e8b3ea69d6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "06827f01-662b-4641-abce-b1c496f28660"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "fd65ce29-7600-446a-a89f-f3422bead07e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "37bded91-485a-44b5-bbc7-53e5be7c3d0b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "873d2b23-002a-477f-856e-5ed602b5405c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "336722d0-5991-49a5-ab55-d7414b598c63"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "d15c6625-2ded-49e4-b8b9-1f1738a696e3"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                    UserId = "102075be-a710-4035-87e0-25f7295074e6"
                });
    }

}

