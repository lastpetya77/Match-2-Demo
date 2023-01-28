using Match2.Partial.Gameplay;
using Match2.Partial.Gameplay.Static;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Scopes
{
    public class LevelLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Debug.Log($"LevelLifetimeScope Configure {gameObject.GetInstanceID()}");
            // Debug.Log($"LevelLifetimeScope Configure {levelData.LevelIndex}");
            
            //builder.RegisterInstance(currentLevelData);
            builder.RegisterEntryPoint<TestEntry>(Lifetime.Singleton);
        }
    }
}