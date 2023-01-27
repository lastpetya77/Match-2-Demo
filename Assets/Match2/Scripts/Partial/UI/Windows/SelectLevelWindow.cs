using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Match2.Common.UI.Windows;
using Match2.Partial.Gameplay.Static;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VContainer;

namespace Match2.Partial.UI.Windows
{
    public class SelectLevelWindow : WindowBase
    {
        [SerializeField] private RectTransform levelButtons;

        [Inject] private IStaticDataProvider staticDataProvider;
        
        private List<GameObject> buttons;

        private void Start()
        {
            Initialize().Forget();
        }

        private async UniTaskVoid Initialize()
        {
            var levels = staticDataProvider.Levels;
            
            buttons = new List<GameObject>(levels.Count);

            foreach (var levelData in levels)
            {
                var instance = await Addressables.InstantiateAsync("SelectLevelButton");
                var levelButton = instance.GetComponent<SelectLevelButton>();
                levelButton.Initialize();
                levelButton.RectTransform.SetParent(levelButtons);
                levelButton.SetLabel(levelData.LevelIndex.ToString());
            }
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            for (int i = buttons.Count - 1; i >= 0; i--)
            {
                if (!Addressables.ReleaseInstance(buttons[i].gameObject))
                {
                    GameObject.Destroy(buttons[i].gameObject);
                }
            }
        }
    }
}