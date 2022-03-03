using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt_Assignment.Models;
using Person_Assignment.Models;


namespace ToDoIt_Assignment.Tests.Models
{
   public  class ToDoTests
    {
        [Fact]
        public void ToDoConstructorTest()
        {
            int id = 2;
            string discription = "Good";
            ToDo result = new ToDo(id,discription );
            
            Assert.Equal(id, result.Id);
            Assert.Equal(discription, result.Description);

        }

        [Fact]
        public void GoodDiscriptionTest()
        {
            int id=1;
            String discription="GoodDiscriptionWorks";

            ToDo result=new ToDo (id,discription );

            Assert .Equal (discription , result .Description );


        }

        [Theory ]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void BadDiscriptionTest(string badDicription)
        {
            int id = 3;
            ToDo todo = new ToDo (id,badDicription );

            Assert.Throws<ArgumentException>(() => todo.Description = badDicription);


        }

        [Fact]
        public void GoodIdTest()
        {
            int id = 1;
            String discription = "Good";

            ToDo result = new ToDo(id, discription);

            Assert.Equal(id, result.Id);


        }

        [Fact]
        public void GoodAssigneeTest()
        {
            int id = 1;
            string firstName = "Fatemeh";
            string lastName = "Sojudi";
            string description = "Good";
            Person GoodAssigneeWorks = new  Person (id,firstName ,lastName );
            
            ToDo result = new ToDo(id, description);

            Assert.Equal(GoodAssigneeWorks, result.Assignee);

        }
        [Fact]
        public void GoodDoneTest()
        {
            int id = 1;
            String discription = "Good";
            bool DoneWorks = false ;

            ToDo result = new ToDo(id, discription);

            Assert.Equal(DoneWorks, result.Done);


        }







    }
}
