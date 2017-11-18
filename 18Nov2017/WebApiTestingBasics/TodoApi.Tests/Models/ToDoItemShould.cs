using System;
using Xunit;

namespace TodoApi.Tests.Models
{
    public class ToDoItemShould
    {
        TodoItem todoItem = new TodoItem();

        [Theory]
        [InlineData("012345-H")]
        [InlineData("224466-M")]
        [InlineData("234567-L")]
        [Trait("ToDoItem", "ModelClass")]
        public void AcceptValidHighCategory(string category)
        {
            todoItem = new TodoItem { TaskPriority = category };
            Assert.True(todoItem.IsValid());
        }

        [Fact]
        [Trait("ToDoItem", "ModelClass")]
        public void ThrowExceptionWhenCategoryIsNull()
        {
            todoItem = new TodoItem { TaskPriority = null };

            Assert.Throws<ArgumentNullException>(() => todoItem.IsValid());
        }

        [Theory]
        [InlineData("01234512-1")]
        [InlineData("01234523-B")]
        [Trait("ToDoItem", "ModelClass")]
        [Trait("ToDoItem", "ModelClass-InvalidLength")]
        public void RejectInvalidLength(string category)
        {
            todoItem = new TodoItem { TaskPriority = category };
            Assert.False(todoItem.IsValid());
        }

        [Theory]
        [InlineData("012345-h")]
        [InlineData("224466-K")]
        [InlineData("234567-A")]
        [Trait("ToDoItem", "ModelClass")]
        [Trait("ToDoItem", "ModelClass-InvalidCategory")]
        public void RejectInvalidCategory(string category)
        {
            todoItem = new TodoItem { TaskPriority = category };
            Assert.False(todoItem.IsValid());
        }

        [Theory]
        [InlineData("123N63-H")]
        [InlineData("X12345-M")]
        [InlineData("01234X-L")]
        [Trait("ToDoItem", "ModelClass")]
        [Trait("ToDoItem", "ModelClass-InvalidNumberPart")]
        public void RejectInvalidNumberPart(string category)
        {
            todoItem = new TodoItem { TaskPriority = category };
            Assert.False(todoItem.IsValid());
        }
    }
}
