using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Gameplay.Level.LevelStates.States;

namespace Match2.Partial.Gameplay.Level.LevelStates.Factories
{
    public class LevelItemsFallingStateFactory
    {
        private IFieldFactory fieldFactory;
        
        public LevelItemsFallingStateFactory(IFieldFactory fieldFactory)
        {
            this.fieldFactory = fieldFactory;
        }
        
        public LevelItemsFallingState Create(LevelStateMachine levelStateMachine) => new LevelItemsFallingState(levelStateMachine, fieldFactory);

    }
}