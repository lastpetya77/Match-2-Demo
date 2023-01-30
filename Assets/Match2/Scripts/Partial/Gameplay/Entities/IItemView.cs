using UnityEngine;

namespace Match2.Partial.Gameplay.Entities
{
    public interface IItemView
    {
        Transform transform { get; }
        void Initialize(Sprite sprite);
        void SetSortingOrder(int sortingOrder);
        void Decline();
    }
}