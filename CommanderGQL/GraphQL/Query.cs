using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection] // Get Platforms and their Commands
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection] // Get Commands and their Platforms
        public IQueryable<Command> GetCommands([ScopedService] AppDbContext context)
        {
            return context.Commands;
        }
    }
}