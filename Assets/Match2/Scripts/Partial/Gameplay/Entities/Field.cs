using Match2.Partial.Gameplay.Factories;
using Match2.Partial.Gameplay.Static;
using UnityEngine;
using VContainer;

namespace Match2.Partial.Gameplay.Entities
{
    public class Field : IField
    {
        [Inject] private LevelData currentLevelData;
        [Inject] private ICellFactory cellFactory;
        
        private Vector2Int size;
        private ICell[,] cells;
        private Vector2Int fieldSize;

        public void Initialize()
        {
            var fieldView = new GameObject("FieldView");
            
            var cellsData = currentLevelData.CellsData;

            fieldSize.x = cellsData.GetLength(0);
            fieldSize.y = cellsData.GetLength(1);
            
            cells = new ICell[fieldSize.x, fieldSize.y];
            for (int y = 0; y < fieldSize.y; y++)
            {
                for (int x = 0; x < fieldSize.x; x++)
                {
                    var cellType = cellsData[x, y];
                    cells[x, y] = cellFactory.Create(cellType, fieldView.transform, new Vector2Int(x, y));
                }
            }
        }
    }
}
