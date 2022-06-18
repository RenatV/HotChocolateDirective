using HotchocolateExample.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddType<UserType>()
    .AddQueryType<QueryType>()
    .AddDirectiveType<TestDirective>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});


app.Run();