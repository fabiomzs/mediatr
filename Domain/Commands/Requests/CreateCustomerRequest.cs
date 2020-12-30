using Academy.Domain.Commands.Responses;
using MediatR;

namespace Academy.Domain.Commands.Resquests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}