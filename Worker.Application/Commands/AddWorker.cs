using System;

namespace Worker.Application.Commands
{
    public class AddWorker
    {
        public AddWorker(Guid id, string firstName, string lastName, string age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Guid Id { get; }
        public string FirstName { get;  }
        public string LastName { get; }
        public string Age { get; }
        
        
        
    }
}