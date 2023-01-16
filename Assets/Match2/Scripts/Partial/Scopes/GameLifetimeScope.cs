using MessagePipe;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        // RegisterMessagePipe returns options.
        var options = builder.RegisterMessagePipe(/* configure option */);
        
        // Setup GlobalMessagePipe to enable diagnostics window and global function
        builder.RegisterBuildCallback(c => GlobalMessagePipe.SetProvider(c.AsServiceProvider()));

        // RegisterMessageBroker: Register for IPublisher<T>/ISubscriber<T>, includes async and buffered.
        builder.RegisterMessageBroker<int>(options);

        // also exists RegisterMessageBroker<TKey, TMessage>, RegisterRequestHandler, RegisterAsyncRequestHandler

        // RegisterMessageHandlerFilter: Register for filter, also exists RegisterAsyncMessageHandlerFilter, Register(Async)RequestHandlerFilter
        //builder.RegisterMessageHandlerFilter<MyFilter<int>>();

        builder.RegisterEntryPoint<MessagePipeDemo>(Lifetime.Singleton);
    }
}
