using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Quetion/Quetion", fileName = "Quetion", order = 1)]
public class Quetion : ScriptableObject
{
    [SerializeField] private LocaleText _title;
    [SerializeField] private Answer _firstAnswer;
    [SerializeField] private Answer _secondAnswer;
    [SerializeField] private Answer _thirdAnswer;
    [SerializeField] private Answer _fourthAnswer;

    public string Title => _title.GetText();
    
    public Answer FirstAnswer => _firstAnswer;
    public Answer SecondAnswer => _secondAnswer;
    public Answer ThirdAnswer => _thirdAnswer;
    public Answer FourthAnswer => _fourthAnswer;

    public int ClickOnAnswer(AnswerNumber index)
    {
        Answer answer = null;
        switch (index)
        {
            case AnswerNumber.First:
                answer = _firstAnswer;
                break;
            case AnswerNumber.Second:
                answer = _secondAnswer;
                break;
            case AnswerNumber.Third:
                answer = _thirdAnswer;
                break;
            case AnswerNumber.Fourth:
                answer = _fourthAnswer;
                break;
            default:
                throw new ArgumentException("Варианта ответа не существует");
        }
        return answer.Balls;
    }
}
