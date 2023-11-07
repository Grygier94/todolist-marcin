using Assignment.Api.Persistence.Repositories;

namespace Assignment.Api.Persistence
{
    public interface IUnitOfWork
    {
        ITasksRepository Tasks { get; }
        public void Complete();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public ITasksRepository Tasks { get; }

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            Tasks = new TasksRepository(dbContext);
        }

        public void Complete()
        {
            dbContext.SaveChanges();
        }
    }
}
