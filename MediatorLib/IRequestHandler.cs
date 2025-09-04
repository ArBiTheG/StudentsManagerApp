using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public interface IRequestHandler<TRequest,TResponse> where TRequest : IRequest<TResponse>, new()
    {
        Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
