using Core.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Configure Entity Framework
builder.Services.AddDbContext<AssessmentDbContext>(options =>
    options.UseSqlServer("Data Source=.;Initial Catalog=Assessment;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"));

// Register Repository Pattern
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Custom Routes for Task Management
app.MapControllerRoute(
    name: "task-list",
    pattern: "tasks",
    defaults: new { controller = "TaskItem", action = "Index" });

app.MapControllerRoute(
    name: "task-create",
    pattern: "tasks/create",
    defaults: new { controller = "TaskItem", action = "Create" });

app.MapControllerRoute(
    name: "task-details",
    pattern: "tasks/{id:int}",
    defaults: new { controller = "TaskItem", action = "Details" });

app.MapControllerRoute(
    name: "task-edit",
    pattern: "tasks/{id:int}/edit",
    defaults: new { controller = "TaskItem", action = "Edit" });

app.MapControllerRoute(
    name: "task-delete",
    pattern: "tasks/{id:int}/delete",
    defaults: new { controller = "TaskItem", action = "Delete" });

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
