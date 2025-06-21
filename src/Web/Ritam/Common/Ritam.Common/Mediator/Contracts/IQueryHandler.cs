using MediatR;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator.Contracts;
public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
    where TResult : ResultCommon
{
}
