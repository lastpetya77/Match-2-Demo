using Match2.Partial.Gameplay.Factories;
using VContainer;
using VContainer.Unity;

namespace Match2.Partial.Gameplay.Level
{
    public class LevelEntry : IStartable, ITickable
    {
        [Inject] private IFieldFactory fieldFactory;
        
        public void Start()
        {
            var field = fieldFactory.Create();
        }

        public void Tick()
        {
            
        }
    }
}