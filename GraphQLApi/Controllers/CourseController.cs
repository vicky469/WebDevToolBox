using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;
using GraphQLApi.Data;
using GraphQLApi.Queries;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLApi.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ISchema _schema;

        public CourseController(ILogger<CourseController> logger, ISchema schema)
        {
            _logger = logger;
            _schema = schema;
        }

        // Schema-first approach
        [HttpGet]
        [Route("getcourses")]
        public async Task<string> GetCourses([FromQuery] string query)
        {

            var schema = GraphQL.Types.Schema.For(@"
                    type Query {
                                   courses : [Course!]  
                                   course (id : ID!) : Course
                                                                                                            
                                 }
                    enum PaymentType {
                                        FREE ,
                                        PAID
                                  }
                    type Course {
                                    title: String!
                                    duration: Int
                                    level : String!
                                    instructor: String
                                    paymentType : PaymentType
                                    ratings : [Rating]
                                }
                    type Rating
                                {   
                                    studentName : String
                                    stars : Int
                                    review : String
                                }", builder =>
            {
                builder.Types.Include<Course>();
                builder.Types.Include<Query>();

            });

            var json = await schema.ExecuteAsync(options =>
            {
                options.Query = query;
            });

            return json;
        }
        
        // Code-first approach
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var result = await new DocumentExecuter().ExecuteAsync(executionOptions =>
            {
                executionOptions.Schema = _schema; // when schema is initialized, it scans the Query and the Mutation types and adds all required instances for execution at runtime.
                executionOptions.Query = query.Query;
            });


            if (result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }
            return Ok(result);
        }
    }
}
