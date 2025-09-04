using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Mediator: IMediator
    {
        private readonly IServiceProvider _provider;

        public Mediator(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task<TResponse> Send<TRequest,TResponse>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest<TResponse>, new()
        {
            var handler = _provider.GetService<IRequestHandler<TRequest, TResponse>>()
                      ?? throw new InvalidOperationException($"Handler for {request.GetType().Name} not registered.");
            return await handler.Handle(request, cancellationToken);
        }
    }
}
