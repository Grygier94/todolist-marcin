using Assignment.Api.Core.Models;

namespace Assignment.Api.Persistence.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskEntity() { }
        public TaskEntity(TaskModel model)
        {
            Title = model.Title;
            Description = model.Description;
            IsCompleted = model.IsCompleted;
        }
    }
}
