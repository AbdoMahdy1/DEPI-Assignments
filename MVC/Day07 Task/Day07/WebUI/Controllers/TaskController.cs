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
        public IActionResult Index()
        {   
            return View(TaskRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            TaskItem Task = TaskRepo.GetById(id);
            if (Task == null)
            {
                return NotFound();
            }
            return View(Task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem Task)
        {
            if (ModelState.IsValid)
            {
                TaskRepo.Add(Task);
                TaskRepo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(Task);
        }

        public IActionResult Edit(int id)
        {
            var Task = TaskRepo.GetById(id);
            if (Task == null)
            {
                return NotFound();
            }
            return View(Task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem Task)
        {
            if (id != Task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                TaskRepo.Update(Task);
                TaskRepo.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(Task);
        }


        public IActionResult Delete(int id)
        {

            var Task = TaskRepo.GetById(id);
            if (Task == null)
            {
                return NotFound();
            }

            return View(Task);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var Task = TaskRepo.GetById(id);
            if (Task != null)
            {
                TaskRepo.Delete(Task);
                TaskRepo.Save();
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
