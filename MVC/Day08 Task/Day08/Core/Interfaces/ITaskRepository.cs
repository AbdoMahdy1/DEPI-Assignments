
using Core.Models;

namespace Core.Interfaces
{
    public interface ITaskRepository
    {
        void Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(TaskItem task);
        List<TaskItem> GetAll();
        TaskItem? GetById(int id);
        void Save();

    }
}
