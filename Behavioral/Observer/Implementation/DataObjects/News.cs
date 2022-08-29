namespace Implementation.DataObjects
{
    public class Bulletin
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Content { get; set; }

        public Bulletin(string title, string content)
        {
            Title = title;

            Content = content;
        }
    }
}