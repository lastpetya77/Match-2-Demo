using Match2.Partial.Gameplay.Enums;
using Match2.Partial.Gameplay.Factories;
using UnityEngine;
using VContainer;

namespace Match2.Partial.Gameplay.Entities
{
    public class Cell : ICell
    {
        [Inject] private ICellViewFactory cellViewFactory;
        
        private CellType type;
        private CellState state;

        private ICellView view;
        private Item item;
        
        private Vector2Int coord;
        
        public bool HasItem => item != null;
        public Vector2Int Coord => coord;
        
        public async void Initialize(CellType type, Vector2Int coord, Transform parent)
        {
            this.type = type;
            this.coord = coord;

            this.view = await cellViewFactory.Create(type, coord, parent);

        }
    }
}
