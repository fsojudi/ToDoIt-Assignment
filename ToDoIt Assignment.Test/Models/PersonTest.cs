using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Person_Assignment.Models;


namespace Person_Assignment.Test.Models
{
    public class PersonTest
    {

        [Fact]
        public void Test1()

        {
            string firsName = "Alexi";
            string lastName = "Albani";

            Person result = new person(firstName, lastName);

            Assert.NotNull(result);
            Assert.Equal(firsName, result.Firstname);
            Assert.Equal(lastName, result.Lastname);
        }
    }
}
