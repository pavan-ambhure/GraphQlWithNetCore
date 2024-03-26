using GraphQLWithNetCore.Schema;
using GraphQLWithNetCore.Schema.Queries;
using GraphQLWithNetCore.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddDbContext<GraphQLWithNetCore.Services.MyDbContext>(options =>
          options.UseSqlServer(MyDbContext.DbConnectionString));


builder.Services.AddGraphQLServer()
    .AddQueryType<LocationQueryType>()
    .AddMutationType<GraphQLWithNetCore.Schema.Mutations.Mutation>();
    


var app = builder.Build();
app.MapGraphQL();


app.Run();

