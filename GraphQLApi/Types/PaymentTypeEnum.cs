using GraphQL.Types;
// https://graphql-dotnet.github.io/docs/getting-started/schema-types/#:~:text=methods%20of%20defining-,graphql
namespace GraphQLApi.Types
{
    public class PaymentTypeEnum : EnumerationGraphType
    {
        public PaymentTypeEnum()
        {
            Name = "PaymentType";
            Description = "Payment Type for the Course.";
            Add("FREE", 0,"Free Course");
            Add("PAID", 1, "Paid Course");

        }



    }


    //public class PaymentTypeEnum : EnumerationGraphType<PaymentType>
    //{
    //}
}
