using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Assignment.Models
{
   public class Person

    {
        private int ID;
        private string firstName;
        private string lastName;

        public Person(int ID, string firstName, string lastName)
        {
            this. ID = ID ;
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public String Firstname
        { get { return Firstname; }

          set
            {
                if (string .IsNullOrEmpty (value)) 
                {
                    throw new AggregateException("Firstname must contains at least one letter");

                }
            }

        }
        public string Lastname
        {
            get { return Lastname; }
            set
            {
                if (string .IsNullOrEmpty (value ))
                {
                    throw new AggregateException("Lastname  must contains at least one letter");

                }
            }
        }


    }

    
}
