using Cysharp.Threading.Tasks;

namespace Match2.Partial.Gameplay.Entities
{
    public interface IItem
    {
        UniTask CreateView();
        void SetParent(ICell parent);
        void Sort();
    }
}