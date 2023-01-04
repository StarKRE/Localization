using System;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationModule
{
    [Serializable]
    public class LanguageListenerImage_Sprite : ILanguageListener
    {
        [SerializeField]
        private Image image;

        [SerializeField]
        private LocalizedSprite[] sprites = new LocalizedSprite[0];
        
        public void OnUpdateLanguage(SystemLanguage language)
        {
            if (this.sprites.FindSprite(language, out var sprite))
            {
                this.image.sprite = sprite;                
            }
        }
    }
}