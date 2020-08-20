namespace StarwarsStuff.Ui.Models
{
    public class TodoItem : IPageable
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    public interface IPageable
    {
    }
}