using GraphQLApi.Queries;

namespace GraphQLApi.Schemas
{
    public class CourseSchema : GraphQL.Types.Schema
    {
        public CourseSchema(ProQuery proQuery, IServiceProvider services) : base(services)
        {
            // query
            Query = proQuery;
            // mutation
        }

    }
}
