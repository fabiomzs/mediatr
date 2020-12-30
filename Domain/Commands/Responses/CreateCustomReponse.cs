using System;

namespace Academy.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime CreationDate { get; set; }
    }
}