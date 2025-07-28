using Microsoft.AspNetCore.Mvc;
using TaskTracker.WebAPI.Models;
using TaskTracker.WebAPI.Services;

namespace TaskTracker.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskTrackerController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TaskTrackerController> _logger;

        public TaskTrackerController(ILogger<TaskTrackerController> logger, ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;
        }

        [HttpGet(Name = "TaskTracker")]
        public ActionResult<IEnumerable<TaskItem>> GetTaskTraker()
        {
            var tasks = _taskService.GetTask();
            return Ok(tasks);
        }

        [HttpPost]
        public ActionResult<TaskItem> Post([FromBody] CreateTaskRequest task)
        {
            var createdTask =  _taskService.AddTask(task);
            return Ok(createdTask);
        }
    }
}
