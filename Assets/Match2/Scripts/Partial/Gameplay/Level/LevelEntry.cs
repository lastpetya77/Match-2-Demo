using System;
using Match2.Partial.Gameplay.Level.LevelStates;
using Match2.Partial.Messages;
using MessagePipe;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay.Level
{
    public class LevelEntry : IStartable, ITickable, IDisposable
    {
        [Inject] private LevelStateMachine levelStateMachine;
        [Inject] ISubscriber<OnCellClickedMessage> onCellClickedSubscriber;
        private IDisposable subscriptions;
        public void Start()
        {
            levelStateMachine.Initialize();
            
            var bag = DisposableBag.CreateBuilder(); // composite disposable for manage subscription
            onCellClickedSubscriber.Subscribe(OnCellClicked).AddTo(bag);
            subscriptions = bag.Build();
        }
        
        private void OnCellClicked(OnCellClickedMessage message)
        {
            Debug.Log($"LevelEntry OnCellClicked {message.Coord}");
        }
        
        public void Tick()
        {
            levelStateMachine.Update();
        }

        public void Dispose()
        {
            subscriptions.Dispose();
        }
    }
}