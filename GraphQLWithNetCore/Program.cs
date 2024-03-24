using GraphQLWithNetCore.Schema;
using GraphQLWithNetCore.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<GraphQLWithNetCore.Schema.Mutations.Mutation>();



var app = builder.Build();
app.MapGraphQL();


app.Run();

