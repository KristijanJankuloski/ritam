using MediatR;

namespace Ritam.Common.Mediator.Contracts;
public interface IPublishNotification : INotification
{
    public DateTime ProcessedOn { get; set; }

    public Guid? CreatedBy { get; set; }
}
