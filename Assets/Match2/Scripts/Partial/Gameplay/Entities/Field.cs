using Cysharp.Threading.Tasks;
using Match2.Partial.Gameplay.Enums;
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
        [Inject] private IItemFactory itemFactory;
        
        private Vector2Int size;
        private ICell[,] cells;
        private Vector2Int fieldSize;

        private GameObject fieldView;

        public void Initialize()
        {
            fieldView = new GameObject("FieldView");
            
            var cellsData = currentLevelData.CellsData;

            fieldSize.x = cellsData.GetLength(0);
            fieldSize.y = cellsData.GetLength(1);

            CreateCells();
            CreateChips().Forget();
        }

        private void CreateCells()
        {
            var cellsData = currentLevelData.CellsData;
            
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
        
        private async UniTaskVoid CreateChips()
        {
            var itemsData = currentLevelData.ItemsData;
            
            for (int y = 0; y < fieldSize.y; y++)
            {
                for (int x = 0; x < fieldSize.x; x++)
                {
                    var currentCell = cells[x, y];
                    
                    if (currentCell.CellType != CellType.Default)
                    {
                        continue;
                    }                
                    
                    if (currentCell.CellState == CellState.Blocked)
                    {
                        continue;
                    }

                    var itemData = itemsData[x, y];
                    var item = await itemFactory.Create(itemData, currentCell);
                }
            }          
        }
    }
}
