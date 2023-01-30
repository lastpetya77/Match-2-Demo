using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Gameplay.Level.LevelStates.States;

namespace Match2.Partial.Gameplay.Level.LevelStates.Factories
{
    public class LevelPlayerActionStateFactory
    {
        private IFieldFactory fieldFactory;
        
        public LevelPlayerActionStateFactory(IFieldFactory fieldFactory)
        {
            this.fieldFactory = fieldFactory;
        }
        
        public LevelPlayerActionState Create(LevelStateMachine levelStateMachine) => new LevelPlayerActionState(levelStateMachine, fieldFactory);

    }
}