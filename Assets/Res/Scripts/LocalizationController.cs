using UnityEngine;
using UnityEngine.Events;

public class LocalizationController : MonoBehaviour
{
    public UnityEvent ChangeLocalizationEvent;
    public void ChangeLocalization()
    {
        Localization.Language = Locale.Ru == Localization.Language ? Locale.En : Locale.Ru;
        ChangeLocalizationEvent.Invoke();
    }
}
