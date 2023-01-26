using Match2.Partial.Gameplay.Enums;

namespace Match2.Partial.Gameplay.Factories
{
    public interface IItemColorConverter
    {
        ItemColor Create(int value);
    }
}