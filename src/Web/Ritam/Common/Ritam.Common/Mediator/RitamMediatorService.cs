using MediatR;
using Ritam.Common.Mediator.Contracts;
using Ritam.Common.Mediator.Interfaces;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator;
public class RitamMediatorService : IRitamMediatorService
{
    private readonly IMediator mediator;

    public RitamMediatorService(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public async Task<TResponse> Send<TResponse>(ICommand<TResponse> request) where TResponse : ResultCommon
    {
        return await Send(request, default);
    }

    public async Task<TResponse> Send<TResponse>(IQuery<TResponse> request) where TResponse : ResultCommon
    {
        return await Send(request, default);
    }

    public async Task<TResponse> Send<TResponse>(ICommand<TResponse> request, CancellationToken cancellationToken) where TResponse : ResultCommon
    {
        return await mediator.Send(request, cancellationToken);
    }

    public async Task<TResponse> Send<TResponse>(IQuery<TResponse> request, CancellationToken cancellationToken) where TResponse : ResultCommon
    {
        return await mediator.Send(request, cancellationToken);
    }
}
