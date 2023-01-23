using Cysharp.Threading.Tasks;
using Match2.Common.UI.Windows;
using Match2.Partial.UI;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay
{
    public class TestEntry : IStartable, ITickable
    {
        //[Inject] private WindowPresenter windowPresenter;
        [Inject] private IObjectResolver container;
        [Inject] private LifetimeScope lifetimeScope;
        
        public void Start()
        {
            //var windowPresenter = container.Resolve<WindowPresenter>();
            //windowPresenter.ShowAsync<MyFirstWindow>().Forget();
            
            Debug.Log($"lifetimeScope parent {lifetimeScope.Parent}");
        }

        public void Tick()
        {
            
        }
    }
}