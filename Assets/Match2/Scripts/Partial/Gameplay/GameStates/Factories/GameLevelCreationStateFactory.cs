using Match2.Partial.Gameplay.GameStates.States;
using Match2.Partial.Loading;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameLevelCreationStateFactory
    {
        private SceneLoader sceneLoader;
        private LevelLoader levelLoader;

        public GameLevelCreationStateFactory(SceneLoader sceneLoader, LevelLoader levelLoader)
        {
            this.sceneLoader = sceneLoader;
            this.levelLoader = levelLoader;
        }

        public GameLevelCreationState Create(GameStateMachine gameStateMachine) =>
            new GameLevelCreationState(gameStateMachine, sceneLoader, levelLoader);
    }
}