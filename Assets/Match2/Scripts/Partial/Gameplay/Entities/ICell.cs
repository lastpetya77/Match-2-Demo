using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface ICell
    {
        public CellType Type { get; }
        public CellState State { get; set; }
        Vector2Int Coord { get; }
        IItem Child { get; }
        bool IsInteractable { get; }
        bool IsMatched(ICell otherCell);
        Transform transform { get; }
        void Initialize(CellType type, Vector2Int coord, Transform parent);
        void SetChild(IItem item);
        void ReleaseChild();
    }
}