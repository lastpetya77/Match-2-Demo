using Match2.Common.UI.Windows;
using Match2.Partial.Gameplay.GameStates.States;
using Match2.Partial.Loading;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameSelectLevelStateFactory
    {
        private SceneLoader sceneLoader;
        private WindowPresenter windowPresenter;
        
        public GameSelectLevelStateFactory(SceneLoader sceneLoader, WindowPresenter windowPresenter)
        {
            this.sceneLoader = sceneLoader;
            this.windowPresenter = windowPresenter;
        }
        
        public GameSelectLevelState Create(GameStateMachine gameStateMachine) => new GameSelectLevelState(gameStateMachine, sceneLoader, windowPresenter);
    }
}