using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface ICell
    {
        void Initialize(Vector2Int coord);
    }
}