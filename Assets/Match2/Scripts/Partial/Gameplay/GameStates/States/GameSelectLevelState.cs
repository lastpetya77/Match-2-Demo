using System;
using Match2.Common.UI.Windows;
using Match2.Partial.Loading;
using Match2.Partial.Messages;
using Match2.Partial.UI.Windows;
using MessagePipe;
using UnityEngine;

namespace Match2.Partial.Gameplay.GameStates.States
{
    public class GameSelectLevelState : GameState
    {
        private ISubscriber<SelectLevelFrameMessage> subscriber;
        private IDisposable disposable;
        
        private SceneLoader sceneLoader;
        private WindowPresenter windowPresenter;
        
        public GameSelectLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
            WindowPresenter windowPresenter, ISubscriber<SelectLevelFrameMessage> subscriber) : base(gameStateMachine)
        {
            this.sceneLoader = sceneLoader;
            this.windowPresenter = windowPresenter;
            this.subscriber = subscriber;
        }

        public override async void Enter()
        {
            Debug.Log($"GameSelectLevelState Enter");
            
            var selectLevelWindow = await windowPresenter.ShowAsync<SelectLevelWindow>();
            selectLevelWindow.Initialize();

            var bag = DisposableBag.CreateBuilder(); // composite disposable for manage subscription

            subscriber.Subscribe(MessageHandler).AddTo(bag);
            
            disposable = bag.Build();
        }

        private void MessageHandler(SelectLevelFrameMessage message)
        {
            Debug.Log($"Configure levelData {message.LevelData.LevelIndex}");
            gameStateMachine.SetState<GameLevelCreationState>();
        }
        
        public override void Update()
        {
            
        }

        public override void Exit()
        {
            disposable.Dispose();
        }
    }
}