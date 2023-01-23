using Match2.Partial.Loading;
using UnityEngine;

namespace Match2.Partial.Gameplay.GameStates.States
{
    public class GameIdleState : GameState
    {
        private LevelLoader levelLoader;
        
        public GameIdleState(GameStateMachine gameStateMachine, LevelLoader levelLoader) : base(gameStateMachine)
        {
            this.levelLoader = levelLoader;
        }

        public override async void Enter()
        {
            Debug.Log($"GameIdleState Enter");
            await levelLoader.Load();
        }

        public  override void Update()
        {

        }

        public override void Exit()
        {
            
        }
    }
}
