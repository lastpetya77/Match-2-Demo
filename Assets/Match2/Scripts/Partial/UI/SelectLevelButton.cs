using TMPro;
using UnityEngine;

namespace Match2.Partial.UI
{
    public class SelectLevelButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI label;

        public RectTransform RectTransform { get; private set; }

        public void Initialize()
        {
            RectTransform = GetComponent<RectTransform>();
        }
        
        public void SetLabel(string text)
        {
            this.label.text = text;
        }
    }
}
