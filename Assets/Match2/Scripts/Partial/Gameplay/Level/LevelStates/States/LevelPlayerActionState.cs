using Match2.Partial.Gameplay.Factories;
using UnityEngine;

namespace Match2.Partial.Gameplay.Level.LevelStates.States
{
    public class LevelPlayerActionState : LevelState
    {
        private IFieldFactory fieldFactory;
        
        public LevelPlayerActionState(LevelStateMachine levelStateMachine, IFieldFactory fieldFactory) : base(levelStateMachine)
        {
            this.fieldFactory = fieldFactory;
        }

        public override void Enter()
        {
            Debug.Log($"LevelPlayerActionState Enter");
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