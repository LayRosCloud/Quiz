
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Quetion/Result")]
public class Result : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] private LocaleText _title;
    [SerializeField] private LocaleText _description;
    [SerializeField] private int _balls;

    public Sprite Sprite => _sprite;
    public string Title => _title.GetText();
    public string Description => _description.GetText();
    public int Balls => _balls;
}
