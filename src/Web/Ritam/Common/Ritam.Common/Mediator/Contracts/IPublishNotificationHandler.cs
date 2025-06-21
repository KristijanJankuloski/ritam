using MediatR;

namespace Ritam.Common.Mediator.Contracts;
public interface IPublishNotificationHandler<T> : INotificationHandler<T>
    where T : INotification
{
}
