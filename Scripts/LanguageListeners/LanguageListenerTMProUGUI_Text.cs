using System;
using TMPro;
using UnityEngine;

namespace LocalizationModule
{
    [Serializable]
    public class LanguageListenerTMProUGUI_Text : ILanguageListener
    {
        [SerializeField]
        private TextMeshProUGUI text;

        [SerializeField]
        private LocalizedString[] texts = new LocalizedString[0];
        
        public void OnUpdateLanguage(SystemLanguage language)
        {
            if (this.texts.FindString(language, out var value))
            {
                this.text.text = value;
            }
        }
    }
}