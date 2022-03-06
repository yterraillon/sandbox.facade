using MediatR;

namespace Application;

public interface IEventBus
{
    Task Publish<T>(T @event) where T : INotification;
}

public class InMemoryEventBus : IEventBus
{
    private readonly IMediator _mediator;

    public InMemoryEventBus(IMediator mediator) => _mediator = mediator;

    public Task Publish<T>(T @event) where T : INotification
    {
        _mediator.Publish(@event);
        return Task.CompletedTask;
    }
}