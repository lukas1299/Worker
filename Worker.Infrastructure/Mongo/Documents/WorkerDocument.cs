using System;

namespace Worker.Infrastructure.Mongo.Documents
{
    public class WorkerDocument
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Age { get; set; }
        public Guid Id { get; set; }
        
        
        
    }
}