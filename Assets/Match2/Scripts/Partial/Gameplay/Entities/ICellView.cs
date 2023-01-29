using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface ICellView
    {
        void Initialize(Vector2Int coord);
        void OnCellClicked();
    }
}