using System;
using UnityEngine;

namespace LocalizationModule
{
    [Serializable]
    public sealed class LanguageListenerSpriteRenderer_Sprite : ILanguageListener
    {
        [SerializeField]
        private SpriteRenderer renderer;

        [SerializeField]
        private LocalizedSprite[] sprites = new LocalizedSprite[0];
        
        public void OnUpdateLanguage(SystemLanguage language)
        {
            if (this.sprites.FindSprite(language, out var sprite))
            {
                this.renderer.sprite = sprite;
            }
        }
    }
}