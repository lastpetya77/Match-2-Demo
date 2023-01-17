using System.Collections.Generic;

namespace Match2.Partial.Gameplay.Static
{
    public interface IStaticDataProvider
    {
        List<LevelData> Levels { get; }

        List<ItemData> ItemDatas { get; }
    }
}
