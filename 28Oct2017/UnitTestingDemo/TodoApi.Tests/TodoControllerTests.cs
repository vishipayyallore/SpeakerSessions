using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Controllers;
using Xunit;

namespace TodoApi.Tests
{
    public class TodoControllerTests
    {

        private readonly TodoController _todoController;

        public TodoControllerTests()
        {
            _todoController = new TodoController();
        }

        [Fact]
        public void ShouldReturn_MultipleValues()
        {
            var results = (JsonResult)_todoController.Get();
            var todoItems = results.Value as List<TodoItem>;
            Assert.IsType<TodoItem>(todoItems.FirstOrDefault());
        }

    }
}
