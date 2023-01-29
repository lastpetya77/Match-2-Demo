using System;
using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Messages;
using MessagePipe;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay.Level
{
    public class LevelEntry : IStartable, ITickable
    {
        [Inject] private IFieldFactory fieldFactory;
        [Inject] private ISubscriber<OnCellClickedMessage> subscriber;
        private IDisposable disposable;
        
        public void Start()
        {
            var field = fieldFactory.Create();
            
            var bag = DisposableBag.CreateBuilder(); // composite disposable for manage subscription
            
            subscriber.Subscribe(m => Debug.Log($"message coord {m.Coord}")).AddTo(bag);
            
            disposable = bag.Build();
        }

        public void Tick()
        {
            
        }
    }
}