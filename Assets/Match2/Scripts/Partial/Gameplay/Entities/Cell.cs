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
        private IItem child;
        
        private Vector2Int coord;

        public Transform transform => view.transform;
        public bool HasChild => child != null;
        public Vector2Int Coord => coord;
        public CellType CellType => type;
        public CellState CellState => state;
        
        public async void Initialize(CellType type, Vector2Int coord, Transform parent)
        {
            this.type = type;
            this.coord = coord;

            this.view = await cellViewFactory.Create(type, coord, parent);

        }
        
        public void SetChild(IItem item)
        {
            if (this.child != null)
            {
                Debug.LogError("Can not create chip in non empty cell");
                return;
            }
            
            this.child = item;
            
            item.SetParent(this);
        }
    }
}
