using System.Collections.Generic;
using Match2.Partial.Gameplay;
using Match2.Partial.Installers;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Scopes
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private CommonSceneObjectsInstaller commonSceneObjectsInstaller;
        [SerializeField] private GUIInstaller guiInstaller;

        private List<IInstaller> installers;

        protected override void Configure(IContainerBuilder builder)
        {
            Initialize();
            
            foreach (var installer in installers)
            {
                installer.Install(builder);
            }
            
            builder.RegisterEntryPoint<GameDemo>(Lifetime.Singleton);
        }
        private void Initialize()
        {
            installers = new List<IInstaller>
            {
                commonSceneObjectsInstaller,
                guiInstaller,
                new MessagePipeInstaller()
            };
        }
    }
}