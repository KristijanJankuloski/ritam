using MediatR;
using Ritam.Common.Result;

namespace Ritam.Common.Mediator.Contracts;
public interface ICommand<out T> : IRequest<T> where T : ResultCommon
{
}
