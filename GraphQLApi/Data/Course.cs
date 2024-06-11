namespace GraphQLApi.Data
{
    public enum PaymentType
    { 
      FREE=0,
      PAID=1,
    }


    public class Course

    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int Duration { get; set; }
        public String Level { get; set; }
        public PaymentType PaymentType { get; set; }
        public String Instructor { get; set; }

       // public List<Section> Sections { get; set; }
        public List<Rating> Ratings { get; set; }




    }

    public class Rating

    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public String StudentName { get; set; }
        public String Review { get; set; }
        public int StarValue { get; set; }


    }


    
}
