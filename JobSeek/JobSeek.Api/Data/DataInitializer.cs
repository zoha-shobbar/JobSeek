using Microsoft.EntityFrameworkCore;

namespace JobSeek.Api.Data
{
    public class DataInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.Migrate();
        }
    }
}
