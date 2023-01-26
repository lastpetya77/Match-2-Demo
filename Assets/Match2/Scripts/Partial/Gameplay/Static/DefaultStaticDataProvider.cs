using System.Collections.Generic;
using Match2.Partial.Gameplay.Enums;
using Match2.Partial.Gameplay.Factories;
using UnityEngine;
using VContainer;

namespace Match2.Partial.Gameplay.Static
{
    public class DefaultStaticDataProvider : IStaticDataProvider
    {
        [Inject] private CellTypeConverter cellTypeConverter;
        
        public List<LevelData> Levels { get; private set; }
        public Dictionary<int, LevelData> LevelsDictionary { get; }
        public List<ItemData> ItemDatas { get; private set; }
        
        private void Initialize()
        {
            var firstLevel = CreateTemporaryLevelData();
            
            Levels.Add(firstLevel);
        }
        
        private LevelData CreateTemporaryLevelData()
        {
            var matrix = CreateTemporaryLevelMatrix();
            var cellsData = CreateCellsData(matrix);
            
            var itemData = new ItemData
            {
                Type = ItemType.Default,
                Color = ItemColor.Red
            };
            
            var firstGoal = new GoalData
            {
                ItemData = itemData,
                Amount = 10
            };
            
            var goals = new List<GoalData> { firstGoal };
            var levelData = new LevelData
            {
                LevelIndex = 1,
                Goals = goals,
                CellsData = cellsData
            };

            return levelData;
        }
        
        private int[,] CreateTemporaryLevelMatrix()
        {
            var matrix = new int[5, 7]
            {
                { 0, 0, 0, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 0, 0, 2 },
                { 0, 0, 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 0, 0, 2 }
            };
            
            return matrix;
        }

        private CellType[,] CreateCellsData(int[,] matrix)
        {
            var cellsData = new CellType[5, 7];
            
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int x = 0; x < matrix.GetLength(0); x++)
                {
                    var currentValue = matrix[x, y];
                    cellsData[x, y] = cellTypeConverter.Create(currentValue);
                    
                    Debug.Log($"[{x}][{y}] = {currentValue.ToString()}");
                }
            }
            
            return cellsData;
        }
        
    }
}
