using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Assignment.Models
{
   public class Person

    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this. id = id ;
            
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public int Id
        { get { return id; }
            set { id = (value); }

        }


        public String Firstname
        { get { return Firstname; }

          set
            {
                if (string .IsNullOrEmpty (value)) 
                {
                    throw new ArgumentException ("Firstname must contains at least one letter");

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
                    throw new ArgumentException ("Lastname  must contains at least one letter");

                }
            }
        }


    }

    
}
