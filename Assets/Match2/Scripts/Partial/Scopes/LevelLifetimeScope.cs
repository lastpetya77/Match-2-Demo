using Match2.Partial.Gameplay;
using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Gameplay.Level;
using Match2.Partial.Gameplay.Utils;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Scopes
{
    public class LevelLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ICellPositionCalculator, CellPositionCalculator>(Lifetime.Scoped);
            builder.Register<ICellFactory, CellFactory>(Lifetime.Scoped);
            builder.Register<ICellViewFactory, CellViewFactory>(Lifetime.Scoped);
            builder.Register<IFieldFactory, FieldFactory>(Lifetime.Scoped);
            builder.RegisterEntryPoint<LevelEntry>();
        }
    }
}