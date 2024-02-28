namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }

    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
