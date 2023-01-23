using Match2.Partial.Gameplay.GameStates.States;
using Match2.Partial.Loading;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameLevelClearStateFactory
    {
        private LevelLoader levelLoader;
        
        public GameLevelClearStateFactory(LevelLoader levelLoader)
        {
            this.levelLoader = levelLoader;
        }
        
        public GameLevelClearState Create(GameStateMachine gameStateMachine) => new GameLevelClearState(gameStateMachine, levelLoader);
    }
}