using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Application.Common
{
    public interface IMediator
    {
        public Task<TResponse> Send<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest<TResponse>, new();
    }
}
