using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Locale/File")]
public class LocaleText : ScriptableObject
{
    [SerializeField] private string _ru;
    [SerializeField] private string _en;

    public string GetText()
    {
        switch (Localization.Language)
        {
            case Locale.En:
                return _en;
            case Locale.Ru:
                return _ru;
        }

        throw new ArgumentException("Ошибка! Языка не существует");
    }
}
