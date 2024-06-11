using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQLApiClient.Data;

namespace GraphQLApiClient
{
    public class GraphQLCourseClient
    {
		private readonly IGraphQLClient _client;

		public GraphQLCourseClient(IGraphQLClient client)
		{
			_client = client;
		}

		// schema first
		public static async Task GetCoursesViaHttpGet()
		{
			var graphQLClient = new GraphQLHttpClient (new Uri("http://localhost:5006/graphql/getcourses"), new NewtonsoftJsonSerializer());

			//mutiple courses
			var query = "{ courses { title, level, instructor, ratings { studentName , review } } }";

			//single course
			//var qString = "{ course (id:1) { title, level, instructor } }";

			var response = await graphQLClient.HttpClient.GetAsync(@"http://localhost:5006/graphql/getcourses?query= " + query);
			var result = response.Content.ReadAsStringAsync();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(result.Result);
		}
		
		// code first
		public static async Task GetCoursesViaHttpPost()
		{
			var graphQLEndpoint = "http://localhost:5006/graphql";
			using var graphQLClient = new GraphQLHttpClient(graphQLEndpoint, new NewtonsoftJsonSerializer());
			var query = "{ courses { title, level, instructor, ratings { studentName , review } } }";
			var postRequest = new GraphQLRequest
			{
				Query = query
			};
			var response = await graphQLClient.SendQueryAsync<CourseResponse>(postRequest);
			var result = response.Data.Courses;
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(result);
		}
	}
}
