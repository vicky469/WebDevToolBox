namespace GraphQLApi.Data
{


    public class Section
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int SeqNo { get; set; }
        public string Title { get; set; }
        public List<Lecture> Lectures { get; set; }

    }



    public abstract class Lecture
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int SectionId { get; set; }
        public int SeqNo { get; set; }
        public String Name { get; set; }

    }



    public class Subject : Lecture
    {
        public string MediaUrl { get; set; }

    }


    public class Assignment : Lecture
    {
        public String Instructions { get; set; }
        public String Questions { get; set; }

    }


}
