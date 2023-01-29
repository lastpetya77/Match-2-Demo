using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public class CellView : MonoBehaviour, ICellView
    {
        public CellType CellType;
        public Vector2Int Coord;

        public void Initialize(Vector2Int coord)
        {
            
        }
    }
}
