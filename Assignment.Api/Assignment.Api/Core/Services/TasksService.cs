using Assignment.Api.Core.Models;
using Assignment.Api.Persistence;
using Assignment.Api.Persistence.Entities;

namespace Assignment.Api.Core.Services
{
    public interface ITasksService
    {
        List<TaskModel> GetTasks();
        void AddTask(TaskModel task);
        void UpdateTask(TaskModel task);
        void DeleteTask(int taskId);
    }

    public class TasksService : ITasksService
    {
        private readonly IUnitOfWork unitOfWork;

        public TasksService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<TaskModel> GetTasks()
        {
            return unitOfWork.Tasks.GetTasks().Select(task => new TaskModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                IsCompleted = task.IsCompleted
            }).ToList();
        }

        public void AddTask(TaskModel task)
        {
            var entity = new TaskEntity(task);
            unitOfWork.Tasks.AddTask(entity);
            unitOfWork.Complete();
        }

        public void UpdateTask(TaskModel task)
        {
            var entity = unitOfWork.Tasks.GetTask(task.Id);
            entity.Title = task.Title;
            entity.Description = task.Description;
            entity.IsCompleted = task.IsCompleted;

            unitOfWork.Tasks.UpdateTask(entity);
            unitOfWork.Complete();
        }

        public void DeleteTask(int taskId)
        {
            var entity = unitOfWork.Tasks.GetTask(taskId);
            unitOfWork.Tasks.DeleteTask(entity);
            unitOfWork.Complete();
        }
    }
}
