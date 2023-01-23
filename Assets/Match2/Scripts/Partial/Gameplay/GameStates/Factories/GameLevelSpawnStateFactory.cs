using Match2.Common.UI.Windows;
using Match2.Partial.Gameplay.GameStates.States;
using Match2.Partial.Loading;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameLevelSpawnStateFactory
    {
        private SceneLoader sceneLoader;
        private LevelLoader levelLoader;
        private WindowPresenter windowPresenter;

        public GameLevelSpawnStateFactory(SceneLoader sceneLoader, LevelLoader levelLoader,
            WindowPresenter windowPresenter)
        {
            this.sceneLoader = sceneLoader;
            this.levelLoader = levelLoader;
            this.windowPresenter = windowPresenter;
        }

        public GameLevelSpawnState Create(GameStateMachine gameStateMachine) =>
            new GameLevelSpawnState(gameStateMachine, sceneLoader, levelLoader, windowPresenter);
    }
}