using MediatR;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator.Contracts;
public interface ICommandHandler<TCommand, TResult> : IRequestHandler<TCommand, TResult>
    where TCommand : ICommand<TResult>
    where TResult : ResultCommon
{
}
