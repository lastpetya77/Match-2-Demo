using Cysharp.Threading.Tasks;
using Match2.Common.UI.Windows;
using Match2.Partial.Loading;
using Match2.Partial.UI;
using UnityEngine;

namespace Match2.Partial.Gameplay.GameStates.States
{
    public class GameLevelSpawnState : GameState
    {
        private SceneLoader sceneLoader;
        private LevelLoader levelLoader;
        private WindowPresenter windowPresenter;

        public GameLevelSpawnState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LevelLoader levelLoader, WindowPresenter windowPresenter)
            : base(gameStateMachine)
        {
            this.sceneLoader = sceneLoader;
            this.levelLoader = levelLoader;
            this.windowPresenter = windowPresenter;
            
        }

        public override async void Enter()
        {
            Debug.Log($"GameLevelSpawnState Enter");
            
            await windowPresenter.ShowAsync<MyFirstWindow>();
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}