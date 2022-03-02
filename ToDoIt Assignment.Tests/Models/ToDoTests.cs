using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt_Assignment.Models;


namespace ToDoIt_Assignment.Tests.Models
{
   public  class ToDoTests
    {
        [Fact]
        public void IDandDiscriptionTest()
        {
            int id = 2;
            string discription = "Good";
            ToDo result = new ToDo(id,discription );
            
            Assert.Equal(id, result.Id);
            Assert.Equal(discription, result.Description);

        }
        

    }
}
