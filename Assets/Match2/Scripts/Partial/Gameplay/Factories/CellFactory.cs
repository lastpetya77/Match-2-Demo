using Match2.Partial.Gameplay.Entities;
using Match2.Partial.Gameplay.Enums;
using UnityEngine;
using VContainer;

namespace Match2.Partial.Gameplay.Factories
{
    public class CellFactory : ICellFactory
    {
        private IObjectResolver container;
        
        public CellFactory(IObjectResolver container)
        {
            this.container = container;
        }
        
        public Cell Create(CellType cellType, Transform container, Vector2Int position)
        {
            var cell = new Cell();

            return cell;
        }
    }
}