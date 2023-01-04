using System;
using UnityEngine;

namespace LocalizationModule
{
    [Serializable]
    public sealed class LanguageListenerComposite : ILanguageListener
    {
        [SerializeReference]
        private ILanguageListener[] children = new ILanguageListener[0];

        public LanguageListenerComposite()
        {
        }

        public LanguageListenerComposite(params ILanguageListener[] children)
        {
            this.children = children;
        }

        public void OnUpdateLanguage(SystemLanguage language)
        {
            for (int i = 0, count = this.children.Length; i < count; i++)
            {
                var child = this.children[i];
                child.OnUpdateLanguage(language);
            }
        }
    }
}