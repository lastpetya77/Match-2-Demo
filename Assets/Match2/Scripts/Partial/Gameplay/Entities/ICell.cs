using Match2.Partial.Gameplay.Enums;
using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface ICell
    {
        void Initialize(CellType type, Vector2Int coord, Transform parent);
    }
}