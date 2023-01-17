using System.Collections.Generic;

namespace Match2.Partial.Gameplay.Static
{
    public class DefaultStaticDataProvider : IStaticDataProvider
    {
        public List<LevelData> Levels { get; }
        public List<ItemData> ItemDatas { get; private set; }

        private int xSize = 5;
        private int ySize = 7;
        private int xObstacleIndex = 2;
        private int yObstacleIndex = 2;   
        
        
    }
}
