using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public class Cell
    {
        private CellType type;
        private CellState state;

        private CellView view;
        private Item item;
        
        private int size = 1;
        private Vector2Int coord;
        
        public bool HasItem => item != null;
        public Vector2Int Coord => coord;
        
        
    }
}
