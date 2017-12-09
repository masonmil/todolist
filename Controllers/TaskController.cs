using ToDoListProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace ToDoListProj.Controllers
{

    public class ProductsController : ApiController
    {
        Task[] tasks = new Task[]
        {
            new Task { Id = 1, Name = "Data 01", Category = "Category 01" },
            new Task { Id = 2, Name = "Data 02", Category = "Category 02" },
            new Task { Id = 3, Name = "Data 03", Category = "Category 03" }
        };

        public IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }

        public IHttpActionResult GetTask(int id)
        {
            var task = tasks.FirstOrDefault((p) => p.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }
    }

}
