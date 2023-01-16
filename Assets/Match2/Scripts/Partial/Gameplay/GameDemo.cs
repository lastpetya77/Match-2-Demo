using Cysharp.Threading.Tasks;
using Match2.Common.UI.Windows;
using Match2.Partial.UI;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay
{
    public class GameDemo : IStartable
    {
        [Inject] private WindowPresenter windowPresenter;
        
        public void Start()
        {
            windowPresenter.ShowAsync<MyFirstWindow>().Forget();
        }
    }
}
