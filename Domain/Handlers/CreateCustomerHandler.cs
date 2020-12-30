using System;
using System.Threading;
using System.Threading.Tasks;
using Academy.Domain.Commands.Responses;
using Academy.Domain.Commands.Resquests;
using MediatR;

namespace Academy.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = 1,
                Name = "Fabio Muniz",
                Email = "fabio.muniz@outlook.com",
                Age = 41,
                CreationDate = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}