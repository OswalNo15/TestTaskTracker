using TaskTracker.WebAPI.Models;

namespace TaskTracker.WebAPI.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetTask();
        TaskItem AddTask(CreateTaskRequest task);
    }
}
