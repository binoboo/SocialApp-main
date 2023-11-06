using Domain.Model;
namespace Persistance
{
    public class Seed
    {
        
        public async static Task SeedData(DataContext dataContext)  
        {
             if (dataContext.Activities.Any()) return;
           var ans =  dataContext.Activities;

            List<Activity> a = new ()
            {
               new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                }
            };
           await dataContext.AddRangeAsync(a);
           await dataContext.SaveChangesAsync();
            
           }
        
        }
    }
