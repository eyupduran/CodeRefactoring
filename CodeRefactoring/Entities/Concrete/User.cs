using CodeRefactoring.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Entities.Concrete
{
   public class User:IEntity
    {
    
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

    }
}
