using Match2.Partial.Gameplay.Factories;
using UnityEngine;

namespace Match2.Partial.Gameplay.Level.LevelStates.States
{
    public class LevelDestroyingMatchesState : LevelState
    {
        private IFieldFactory fieldFactory;
        
        public LevelDestroyingMatchesState(LevelStateMachine levelStateMachine, IFieldFactory fieldFactory) : base(levelStateMachine)
        {
            this.fieldFactory = fieldFactory;
        }

        public override void Enter()
        {
            Debug.Log($"LevelDestroyingMatchesState Enter");
        }

        public override void Update()
        {
            
        }

        public override void Exit()
        {
            
        }
    }
}