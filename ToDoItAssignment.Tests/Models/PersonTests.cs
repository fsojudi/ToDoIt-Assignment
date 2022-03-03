using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Person_Assignment.Models;


namespace ToDoItAssignment.Tests.Models
{
     public  class PersonTests
    {
        [Fact]
        public void PersonTest()
        {
            int ID = 1;
            string firstname = "Alexi";
            string lastname = "Albani";
            Person result = new Person(ID, firstname, lastname);

            Assert.Equal(ID, result.Id);
            Assert.NotNull(result);
            Assert.Equal(firstname, result.Firstname);
            Assert.Equal(lastname, result.Lastname);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void IsNullOrEmptyTest(string emptyFirstName)
        {

            int Id = 3;
            string lastName = "svensson";
            Person person = new Person(Id, "safeFirstName", lastName);


            Assert.Throws<ArgumentException>(() => person.Firstname = emptyFirstName);


        }
    }
}
