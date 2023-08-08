using TMPro;
using UnityEngine;

public class MainSceneLocalization : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mainText;
    [SerializeField] private LocaleText _mainTextLocale;
    [Space]
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private LocaleText _titleLocale;
    [Space]
    [SerializeField] private TextMeshProUGUI _settings;
    [SerializeField] private LocaleText _settingsLocale;
    [Space]
    [SerializeField] private LocaleText _startLocale;
    [SerializeField] private TextMeshProUGUI _start;
    [Space(30)]
    [SerializeField] private LocalizationController _localizationController;

    private void Awake()
    {
        UpdateLocale();
        
        _localizationController.ChangeLocalizationEvent.AddListener(UpdateLocale);
    }

    private void UpdateLocale()
    {
        _title.text = _titleLocale.GetText();
        _start.text = _startLocale.GetText();
        _settings.text = _settingsLocale.GetText();
        _mainText.text = _mainTextLocale.GetText();
    }
}
