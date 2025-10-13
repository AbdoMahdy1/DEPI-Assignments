using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        AssessmentDbContext _Context;

        public TaskRepository()
        {
            _Context = new AssessmentDbContext();
            _Context.Database.EnsureCreated();
        }
        public void Add(TaskItem NewTask)
        {
            _Context.Add(NewTask);
        }

        public void Delete(TaskItem Tsak)
        {
            _Context.Remove(Tsak);
        }

        public List<TaskItem> GetAll()
        {
            return _Context.Tasks.ToList();
        }

        public TaskItem GetById(int id)
        {
            return _Context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(TaskItem Task)
        {
            _Context.Update(Task);
        }
    }
}
