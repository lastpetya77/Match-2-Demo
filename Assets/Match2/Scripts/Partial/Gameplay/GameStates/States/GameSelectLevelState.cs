using Match2.Common.UI.Windows;
using Match2.Partial.Loading;
using Match2.Partial.Loading.Enums;
using Match2.Partial.UI.Windows;
using UnityEngine;

namespace Match2.Partial.Gameplay.GameStates.States
{
    public class GameSelectLevelState : GameState
    {
        private SceneLoader sceneLoader;
        private WindowPresenter windowPresenter;
        
        public GameSelectLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
            WindowPresenter windowPresenter) : base(gameStateMachine)
        {
            this.sceneLoader = sceneLoader;
            this.windowPresenter = windowPresenter;
        }

        public override async void Enter()
        {
            Debug.Log($"GameSelectLevelState Enter");
            
            await windowPresenter.ShowAsync<SelectLevelWindow>();
        }

        public override void Update()
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}