using System;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationModule
{
    [Serializable]
    public class LanguageListenerText_FontSize : ILanguageListener
    {
        [SerializeField]
        private Text text;

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