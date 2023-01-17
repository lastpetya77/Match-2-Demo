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

        private List<IInstaller> unityBehaviorInstallers;
        private List<IInstaller> simpleInstallers;

        protected override void Configure(IContainerBuilder builder)
        {
            Initialize();

            Install(builder, unityBehaviorInstallers);
            Install(builder, simpleInstallers);
            
            builder.RegisterEntryPoint<GameDemo>(Lifetime.Singleton);
        }
        private void Initialize()
        {
            unityBehaviorInstallers = new List<IInstaller>
            {
                commonSceneObjectsInstaller,
                guiInstaller
            };

            simpleInstallers = new List<IInstaller>
            {
                new MessagePipeInstaller(),
                new GameStateFactoriesInstaller()
            };
        }

        private void Install(IContainerBuilder builder, List<IInstaller> installers)
        {
            foreach (var installer in installers)
            {
                installer.Install(builder);
            }
        }
    }
}