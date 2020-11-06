using System;

namespace Worker.Core.Entities
{
    public class WorkerEntity
    {
        private WorkerEntity(Guid id, string firstName, string lastName, string age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public static WorkerEntity Create(Guid id, string firstName, string lastName, string age)
        {
           return new WorkerEntity(id , firstName, lastName, age);
        }
        public Guid Id { get; } 
        public string FirstName { get; } 
        public string LastName { get; } 
        public string Age { get; }
        
    }
}