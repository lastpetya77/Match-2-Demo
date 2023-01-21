using Match2.Partial.Gameplay.Enums;

namespace Match2.Partial.Gameplay.Factories
{
    public interface ICellTypeFactory
    {
        CellType Create(int x, int y);
    }
}
