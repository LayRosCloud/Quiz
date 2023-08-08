using System;
using TMPro;
using UnityEngine;
using YG;

public class RewardAdsManager : MonoBehaviour
{
    [SerializeField] private YandexGame _sdk;
    [SerializeField] private int _coins;
    [SerializeField] private TextMeshProUGUI _coinsTxt;
    [SerializeField] private GameObject _disableContainer;
    [SerializeField] private GameObject _activeContainer;
    private void Awake()
    {
        _coins = PlayerPrefs.GetInt("Coins", 0);
        SetCoinsText();
    }

    public void AdsButton()
    {
        if (_coins - 10 < 0)
        {
            _sdk._RewardedShow(1);
            return;
        }
        SuccessFull();
    }

    public void AdsButtonCul()
    {
        _coins += 15;
        
        SuccessFull();
        
        SetCoinsText();

        PlayerPrefs.SetInt("Coins",_coins);
    }

    private void SetCoinsText()
    {
        _coinsTxt.text = _coins.ToString();
    }
    
    private void SuccessFull()
    {
        _coins -= 10;
        SetCoinsText();
        
        PlayerPrefs.SetInt("Coins",_coins);
        
        _disableContainer.SetActive(false);
        _activeContainer.SetActive(true);
    }
}
