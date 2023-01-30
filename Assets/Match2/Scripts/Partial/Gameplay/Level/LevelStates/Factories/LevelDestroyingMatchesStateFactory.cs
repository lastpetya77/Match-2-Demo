using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Gameplay.Level.LevelStates.States;

namespace Match2.Partial.Gameplay.Level.LevelStates.Factories
{
    public class LevelDestroyingMatchesStateFactory
    {
        private IFieldFactory fieldFactory;
        
        public LevelDestroyingMatchesStateFactory(IFieldFactory fieldFactory)
        {
            this.fieldFactory = fieldFactory;
        }
        
        public LevelDestroyingMatchesState Create(LevelStateMachine levelStateMachine) => new LevelDestroyingMatchesState(levelStateMachine, fieldFactory);

    }
}