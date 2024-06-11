using GraphQL.Types;
using GraphQLApi.Data;

namespace GraphQLApi.Types
{
    public class CourseType : ObjectGraphType<Course>
	{
        public CourseType()
		{
            Name = "Course"; // Name of the Type, which will be used in the GraphQL Schema
			Description = "Represents Course Object/Data";
			
			Field(x => x.Id, type: typeof(IdGraphType)).Description("Course ID.");
			Field(x => x.Title).Description("Course Title.");
			Field(x => x.Duration).Description("Course Duration.");
			Field(x => x.Level);
			Field(x => x.Instructor);
			Field(x => x.PaymentType, type: typeof(PaymentTypeEnum));
            Field<ListGraphType<RatingType>>("ratings");
        }



    }
}
