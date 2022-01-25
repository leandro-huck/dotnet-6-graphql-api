using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatforms([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}