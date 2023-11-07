using Assignment.Api.Core.Models;
using Assignment.Api.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {

        private readonly ITasksService taskService;

        public TasksController(ITasksService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public IEnumerable<TaskModel> Get()
        {
            return taskService.GetTasks();
        }

        [HttpPost]
        public void Add(TaskModel task)
        {
            taskService.AddTask(task);
        }

        [HttpPut]
        public void Update(TaskModel task)
        {
            taskService.UpdateTask(task);
        }

        [HttpDelete]
        public void Delete(int taskId)
        {
            taskService.DeleteTask(taskId);
        }
    }
}