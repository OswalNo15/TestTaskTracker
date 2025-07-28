using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System.Threading.Tasks;
using TaskTracker.WebAPI.Models;

namespace TaskTracker.WebAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _task = new();
        private int _nextid = 1;
        public TaskItem AddTask(CreateTaskRequest task)
        {
            TaskItem objtask = new();
            objtask.Id = _nextid++;
            objtask.name = task.name;
            objtask.description = task.description; 
            _task.Add(objtask);
            return objtask;
        }

        public IEnumerable<TaskItem> GetTask()
        {
            return _task;
        }
    }
}
