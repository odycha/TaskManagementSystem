using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementSystem.Data.Configurations;
//Here we also have to specify the type of the key
//set admin user to role admin
public class TaskTypeConfiguration : IEntityTypeConfiguration<TaskType>
{
    public void Configure(EntityTypeBuilder<TaskType> builder)
    {
        builder.HasData(
                // Tasks for January 31
                new TaskType { Id = 1, Name = "Develop the banking app", StartDate = new DateOnly(2025, 01, 31), Department = "Development", Description = "You must complete the classes", Allocated = false, SkillLevel = 10, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 2, Name = "Fix database issues", StartDate = new DateOnly(2025, 01, 31), Department = "Development", Description = "Fix all reported database errors", Allocated = false, SkillLevel = 6, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 3, Name = "Enhance security measures", StartDate = new DateOnly(2025, 01, 31), Department = "IT Support", Description = "Implement additional firewalls", Allocated = false, SkillLevel = 8, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 4, Name = "Design new campaign materials", StartDate = new DateOnly(2025, 01, 31), Department = "Marketing", Description = "Prepare new posters and flyers", Allocated = false, SkillLevel = 5, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 5, Name = "Improve code quality", StartDate = new DateOnly(2025, 01, 31), Department = "Development", Description = "Refactor legacy code", Allocated = false, SkillLevel = 7, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                // Tasks for February 3
                new TaskType { Id = 6, Name = "Implement API integration", StartDate = new DateOnly(2025, 02, 03), Department = "Development", Description = "Integrate with external APIs", Allocated = false, SkillLevel = 9, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 7, Name = "Network diagnostics", StartDate = new DateOnly(2025, 02, 03), Department = "IT Support", Description = "Run diagnostics on the company network", Allocated = false, SkillLevel = 7, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 8, Name = "Social media strategy", StartDate = new DateOnly(2025, 02, 03), Department = "Marketing", Description = "Plan next month’s social media campaigns", Allocated = false, SkillLevel = 6, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 9, Name = "Resolve customer tickets", StartDate = new DateOnly(2025, 02, 03), Department = "IT Support", Description = "Close all pending customer tickets", Allocated = false, SkillLevel = 5, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 10, Name = "Create landing page", StartDate = new DateOnly(2025, 02, 03), Department = "Development", Description = "Design and code a new landing page", Allocated = false, SkillLevel = 8, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                // Tasks for February 4
                new TaskType { Id = 11, Name = "Bug fixes in existing app", StartDate = new DateOnly(2025, 02, 04), Department = "Development", Description = "Resolve reported bugs in production", Allocated = false, SkillLevel = 8, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 12, Name = "Upgrade system hardware", StartDate = new DateOnly(2025, 02, 04), Department = "IT Support", Description = "Install new servers", Allocated = false, SkillLevel = 10, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 13, Name = "Prepare press release", StartDate = new DateOnly(2025, 02, 04), Department = "Marketing", Description = "Draft and finalize press release for new product launch", Allocated = false, SkillLevel = 7, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 14, Name = "Test new features", StartDate = new DateOnly(2025, 02, 04), Department = "Development", Description = "Perform QA testing on new features", Allocated = false, SkillLevel = 6, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 15, Name = "SEO optimization", StartDate = new DateOnly(2025, 02, 04), Department = "Marketing", Description = "Optimize website for search engines", Allocated = false, SkillLevel = 9, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 16, Name = "Data backup", StartDate = new DateOnly(2025, 02, 04), Department = "IT Support", Description = "Create a backup of all systems", Allocated = false, SkillLevel = 6, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 17, Name = "Develop test cases", StartDate = new DateOnly(2025, 02, 04), Department = "Development", Description = "Create test cases for upcoming releases", Allocated = false, SkillLevel = 7, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 18, Name = "Manage email campaigns", StartDate = new DateOnly(2025, 02, 04), Department = "Marketing", Description = "Prepare and send out promotional emails", Allocated = false, SkillLevel = 5, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(11, 30, 00), Completed = false },
                new TaskType { Id = 19, Name = "Software patch update", StartDate = new DateOnly(2025, 02, 04), Department = "IT Support", Description = "Deploy patches to all systems", Allocated = false, SkillLevel = 8, StartTime = new TimeOnly(11, 30, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false },
                new TaskType { Id = 20, Name = "Create client presentation", StartDate = new DateOnly(2025, 02, 04), Department = "Marketing", Description = "Prepare a presentation for clients", Allocated = false, SkillLevel = 7, StartTime = new TimeOnly(09, 00, 00), EndTime = new TimeOnly(17, 00, 00), Completed = false }
        );
    }

}

