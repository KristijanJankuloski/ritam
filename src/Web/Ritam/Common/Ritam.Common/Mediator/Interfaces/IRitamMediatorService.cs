using Ritam.Common.Mediator.Contracts;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator.Interfaces;
public interface IRitamMediatorService
{
    Task<TResponse> Send<TResponse>(ICommand<TResponse> request)
        where TResponse : ResultCommon;
    
    Task<TResponse> Send<TResponse>(IQuery<TResponse> request)
        where TResponse : ResultCommon;

    Task<TResponse> Send<TResponse>(ICommand<TResponse> request, CancellationToken cancellationToken)
        where TResponse : ResultCommon;
    
    Task<TResponse> Send<TResponse>(IQuery<TResponse> request, CancellationToken cancellationToken)
        where TResponse : ResultCommon;
}
