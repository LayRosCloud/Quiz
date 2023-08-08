using UnityEngine;

[CreateAssetMenu(menuName = "Quetion/Answer", fileName = "Answer", order = 2)]
public class Answer : ScriptableObject
{
    [SerializeField] private LocaleText _name;
    [SerializeField, Range(0, 3)] private int _balls;

    public string Name => _name.GetText();
    public int Balls => _balls;
}
