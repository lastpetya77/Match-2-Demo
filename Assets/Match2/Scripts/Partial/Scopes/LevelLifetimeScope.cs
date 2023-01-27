using System;
using Match2.Partial.Gameplay.Static;
using Match2.Partial.Messages;
using MessagePipe;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Scopes
{
    public class LevelLifetimeScope : LifetimeScope
    {
        [Inject] private ISubscriber<SelectLevelFrameMessage> subscriber;
        private IDisposable disposable;

        // public LevelLifetimeScope()
        // {
        //     var bag = DisposableBag.CreateBuilder(); // composite disposable for manage subscription
        //
        //     subscriber.Subscribe(x => Console.WriteLine("here")).AddTo(bag);
        //     //subscriber.Subscribe(message => Debug.Log($"Configure levelData {message.LevelData.LevelIndex}")).AddTo(bag);
        //
        //     disposable = bag.Build();
        // }
        
        protected override void Configure(IContainerBuilder builder)
        {

            
            //Debug.Log($"LevelLifetimeScope Configure {currentLevelData.LevelIndex}");
            
            //builder.RegisterInstance(currentLevelData);
            //builder.RegisterEntryPoint<TestEntry>(Lifetime.Singleton);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            
            //disposable.Dispose();
        }
    }
}