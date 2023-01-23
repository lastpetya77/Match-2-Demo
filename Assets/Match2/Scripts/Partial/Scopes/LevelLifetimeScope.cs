using Match2.Partial.Gameplay;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Scopes
{
    public class LevelLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<TestEntry>(Lifetime.Singleton);

        }
    }
}