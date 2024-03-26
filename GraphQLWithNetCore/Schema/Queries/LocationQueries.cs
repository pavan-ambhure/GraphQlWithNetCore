using System;
using GraphQLWithNetCore.Models;
using GraphQLWithNetCore.Services;
using Microsoft.EntityFrameworkCore;

namespace GraphQLWithNetCore.Schema.Queries
{
    public class LocationQueries
    {
        // GetLocations: Return a list of all locations
        // Notice the [Service]. It's an auto hook up from HotChocolate
        public async Task<List<Locations>> GetLocations([Service] MyDbContext dbContext) =>
          await dbContext
            .Location
            .AsNoTracking()
            .OrderBy(o => o.Name)
            .ToListAsync();

        // GetLocation: Return a list of locations by location code
        public async Task<List<Locations>> GetLocation([Service] MyDbContext dbContext, string code) =>
          await dbContext
            .Location
            .AsNoTracking()
            .Where(w => w.Code == code)
            .OrderBy(o => o.Name)
            .ToListAsync();
    }
}

