using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class TaskItemController : Controller
    {
        ITaskRepository TaskRepo;

        public TaskItemController(ITaskRepository taskRepo)
        {
            TaskRepo = taskRepo;
        }

        // GET: List all tasks
        public IActionResult Index()
        {
            var tasks = TaskRepo.GetAll();
            return View(tasks);
        }

        // GET: Show create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create new task
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                TaskRepo.Add(task);
                TaskRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Show task details
        public IActionResult Details(int id)
        {
            var task = TaskRepo.GetById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // GET: Show edit form
        public IActionResult Edit(int id)
        {
            var task = TaskRepo.GetById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Update task
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaskItem task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                TaskRepo.Update(task);
                TaskRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Show delete confirmation
        public IActionResult Delete(int id)
        {
            var task = TaskRepo.GetById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Delete task
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var task = TaskRepo.GetById(id);
            if (task != null)
            {
                TaskRepo.Delete(task);
                TaskRepo.Save();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
