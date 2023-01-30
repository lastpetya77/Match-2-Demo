using Cysharp.Threading.Tasks;
using Match2.Partial.Gameplay.Enums;

namespace Match2.Partial.Gameplay.Entities
{
    public interface IItem
    {
        ItemType Type { get; }
        ItemColor Color { get; }
        ItemState State { get; }
        bool IsMatched(IItem item);
        UniTask CreateView();
        void SetParent(ICell parent);
        void Sort();
        void Decline();
    }
}