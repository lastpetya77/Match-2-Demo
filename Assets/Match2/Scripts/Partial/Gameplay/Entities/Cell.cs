using Match2.Partial.Gameplay.Enums;
using Match2.Partial.Gameplay.Utils;
using UnityEngine;
using VContainer;

namespace Match2.Partial.Gameplay.Entities
{
    public class Cell : ICell
    {
        [Inject] private ICellPositionCalculator positionCalculator;
        
        private CellType type;
        private CellState state;

        private CellView view;
        private Item item;
        
        private Vector2Int coord;
        
        public bool HasItem => item != null;
        public Vector2Int Coord => coord;
        
        public void Initialize(Vector2Int coord)
        {
            this.coord = coord;
            
            var position = positionCalculator.CoordToLocalPosition(coord);  
            
        }
    }
}
