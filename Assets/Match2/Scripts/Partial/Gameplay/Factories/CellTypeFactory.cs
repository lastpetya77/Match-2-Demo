using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Factories
{
    public class CellTypeFactory : ICellTypeFactory
    {
        public CellType Create(int x, int y)
        {
            //CellType cellType;
                    
            // if (y == ySize - 1 )
            // {
            //     cellType = CellType.SpawnPoint;
            // }
            // else if (x == xObstacleIndex && y == yObstacleIndex)
            // {
            //     cellType = CellType.Obstacle;
            // }
            // else
            // {
            //     cellType = CellType.Default;
            // }
            //return cellType;

            return CellType.Default;
        }
    }
}
