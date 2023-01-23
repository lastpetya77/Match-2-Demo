﻿using Match2.Partial.Loading;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Installers
{
    public class MainInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<LevelLoader>(Lifetime.Scoped);
        }
    }
}