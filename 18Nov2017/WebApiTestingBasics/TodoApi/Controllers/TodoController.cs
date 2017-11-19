using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TodoApi.Controllers
{

    [Route("api/[controller]")]
    public class TodoController : Controller
    {

        private List<TodoItem> _todoItems;

        public TodoController()
        {
            _todoItems = new List<TodoItem>()
            {
                new TodoItem() {Id=1, Name="Task 1", IsComplete=false},
                new TodoItem() {Id=2, Name="Task 2", IsComplete=false},
                new TodoItem() {Id=3, Name="Task 3", IsComplete=false},
                new TodoItem() {Id=4, Name="Task 4", IsComplete=false},
            };
        }

        public IActionResult Get()
        {
            return Json(_todoItems);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if ((id < 0) || (id > 3))
            {
                return BadRequest($"Invalid request for id {id}");
            }

            return Json(_todoItems[id]);
        }

        [HttpPost("StoreTask")]
        public IActionResult StoreTask(TodoItem todoItem)
        {
            //Data base activity...

            return Ok("Task Stored");
        }

    }

}