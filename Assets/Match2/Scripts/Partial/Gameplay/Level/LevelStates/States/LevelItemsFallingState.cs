using Match2.Partial.Gameplay.Factories;
using UnityEngine;

namespace Match2.Partial.Gameplay.Level.LevelStates.States
{
    public class LevelItemsFallingState : LevelState
    {
        private IFieldFactory fieldFactory;
        
        public LevelItemsFallingState(LevelStateMachine levelStateMachine, IFieldFactory fieldFactory) : base(levelStateMachine)
        {
            this.fieldFactory = fieldFactory;
        }

        public override void Enter()
        {
            Debug.Log($"LevelItemsFallingState Enter");
        }

        public override void Update()
        {
            
        }

        public override void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}