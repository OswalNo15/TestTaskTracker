namespace TaskTracker.WebAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
