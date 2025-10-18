using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AssessmentDbContext _context;

        public TaskRepository(AssessmentDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Synchronous Methods
        public void Add(TaskItem task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));
            _context.Tasks.Add(task);
        }

        public void Update(TaskItem task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));
            _context.Tasks.Update(task);
        }

        public void Delete(TaskItem task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));
            _context.Tasks.Remove(task);
        }

        public List<TaskItem> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public TaskItem? GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        #endregion

        
    }
}
