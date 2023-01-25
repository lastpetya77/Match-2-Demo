using Match2.Partial.Loading;
using Match2.Partial.Loading.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.GameStates.States
{
    public class GameLevelCreationState : GameState
    {
        private SceneLoader sceneLoader;
        private LevelLoader levelLoader;

        public GameLevelCreationState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LevelLoader levelLoader)
            : base(gameStateMachine)
        {
            this.sceneLoader = sceneLoader;
            this.levelLoader = levelLoader;
        }

        public override async void Enter()
        {
            Debug.Log($"GameLevelCreationState Enter");
            
            await sceneLoader.LoadSceneAsync(SceneType.Game);
            await levelLoader.Load();
            
            gameStateMachine.SetState<GameLevelSpawnState>();
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}