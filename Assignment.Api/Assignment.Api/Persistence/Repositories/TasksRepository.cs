using Assignment.Api.Persistence.Entities;

namespace Assignment.Api.Persistence.Repositories
{
    public interface ITasksRepository
    {
        IEnumerable<TaskEntity> GetTasks();
        TaskEntity GetTask(int taskId);
        void AddTask(TaskEntity task);
        void UpdateTask(TaskEntity task);
        void DeleteTask(TaskEntity task);
    }

    public class TasksRepository : ITasksRepository
    {
        protected readonly IAppDbContext dbContext;

        public TasksRepository(IAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TaskEntity> GetTasks()
        {
            return dbContext.Tasks.ToList();
        }

        public TaskEntity GetTask(int taskId)
        {
            return dbContext.Tasks.SingleOrDefault(task => task.Id == taskId);
        }

        public void AddTask(TaskEntity task)
        {
            dbContext.Tasks.Add(task);
        }

        public void UpdateTask(TaskEntity task)
        {
            dbContext.Tasks.Update(task);
        }

        public void DeleteTask(TaskEntity task)
        {
            dbContext.Tasks.Remove(task);
        }
    }
}
