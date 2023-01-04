using UnityEngine;

namespace LocalizationModule
{
    public interface ILanguageListener
    {
        void OnUpdateLanguage(SystemLanguage language);
    }
}