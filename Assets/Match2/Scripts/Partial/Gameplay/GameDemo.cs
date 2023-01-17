using Cysharp.Threading.Tasks;
using Match2.Common.UI.Windows;
using Match2.Partial.Gameplay.GameStates;
using Match2.Partial.UI;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay
{
    public class GameDemo : IStartable, ITickable
    {
        [Inject] private GameStateMachine gameStateMachine;
        [Inject] private WindowPresenter windowPresenter;
        
        public void Start()
        {
            windowPresenter.ShowAsync<MyFirstWindow>().Forget();
            
            gameStateMachine.Initialize();
        }

        public void Tick()
        {
            gameStateMachine.Update();
        }
    }
}
