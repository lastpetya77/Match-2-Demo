using Match2.Partial.Gameplay.GameStates.States;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameIdleStateFactory
    {
        public GameIdleState Create(GameStateMachine gameStateMachine) => new GameIdleState(gameStateMachine);
    }
}