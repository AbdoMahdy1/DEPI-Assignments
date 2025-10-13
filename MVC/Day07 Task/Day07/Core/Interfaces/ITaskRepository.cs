
using Core.Models;

namespace Core.Interfaces
{
    public interface ITaskRepository
    {
        public void Add(TaskItem department);
        public void Update(TaskItem department);
        public void Delete(TaskItem department);

        public List<TaskItem> GetAll();
        public TaskItem GetById(int id);

        public void Save();
    }
}
