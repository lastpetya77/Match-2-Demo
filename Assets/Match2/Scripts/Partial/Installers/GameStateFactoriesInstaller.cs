using Match2.Partial.Gameplay.GameStates;
using Match2.Partial.Gameplay.GameStates.Factories;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Installers
{
    public class GameStateFactoriesInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<GameStateMachine>(Lifetime.Singleton);
            builder.Register<GameIdleStateFactory>(Lifetime.Scoped);
        }
    }
}
