namespace TaskTracker.WebAPI.Models
{
    public class CreateTaskRequest
    {
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
