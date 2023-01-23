﻿using Match2.Partial.Gameplay.GameStates.States;
using Match2.Partial.Loading;

namespace Match2.Partial.Gameplay.GameStates.Factories
{
    public class GameIdleStateFactory
    {
        private LevelLoader levelLoader;
        
        public GameIdleStateFactory(LevelLoader levelLoader)
        {
            this.levelLoader = levelLoader;
        }
        
        public GameIdleState Create(GameStateMachine gameStateMachine) => new GameIdleState(gameStateMachine, levelLoader);
    }
}