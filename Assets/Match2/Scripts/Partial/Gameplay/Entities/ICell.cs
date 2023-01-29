using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface ICell
    {
        public CellType CellType { get; }
        public CellState CellState { get; }
        Vector2Int Coord { get; }
        Transform transform { get; }
        void Initialize(CellType type, Vector2Int coord, Transform parent);
        void SetChild(IItem item);
    }
}