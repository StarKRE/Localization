using System;
using TMPro;
using UnityEngine;

namespace LocalizationModule
{
    [Serializable]
    public class LanguageListenerTMProUGUI_FontSize : ILanguageListener
    {
        [SerializeField]
        private TextMeshProUGUI text;

        [SerializeField]
        private LocalizedInt[] fontSizes = new LocalizedInt[0];
        
        public void OnUpdateLanguage(SystemLanguage language)
        {
            if (this.fontSizes.FindInt(language, out var value))
            {
                this.text.fontSize = value;
            }
        }
    }
}