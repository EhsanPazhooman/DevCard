namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Project(long id, string title, string description,string image, string client)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Client = client;
        }
    }

    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
