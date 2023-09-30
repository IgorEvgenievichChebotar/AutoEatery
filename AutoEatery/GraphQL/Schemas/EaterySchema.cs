using AutoEatery.Data;
using AutoEatery.GraphQL.Mutations;
using AutoEatery.GraphQL.Queries;
using GraphQL.Types;

namespace AutoEatery.GraphQL.Schemas;

public class EaterySchema : Schema
{
    public EaterySchema(EateryDbContext dbContext)
    {
        Query = new EateryQuery(dbContext);
        Mutation = new EateryMutation(dbContext);
    }
}