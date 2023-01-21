using System.Collections.Generic;
using Match2.Partial.Gameplay.Enums;

namespace Match2.Partial.Gameplay.Static
{
    public class LevelData
    {
        public int XSize;
        public int YSize;
        public int LevelIndex;
        public List<GoalData> Goals;
        public CellType[,] CellsData;
    }
}
