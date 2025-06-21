using MediatR;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator.Contracts;
public interface IQuery<out TResult> : IRequest<TResult> where TResult : ResultCommon
{
}
