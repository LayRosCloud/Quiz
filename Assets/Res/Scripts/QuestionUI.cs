using System;
using TMPro;
using UnityEngine;

public class QuestionUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _counter;
    [SerializeField] private TextMeshProUGUI _firstText;
    [SerializeField] private TextMeshProUGUI _secondText;
    [SerializeField] private TextMeshProUGUI _thirdText;
    [SerializeField] private TextMeshProUGUI _fourthText;

    public void UpdateQuestion(Quetion question, int currentIndex, int maximumLength)
    {
        SetTitle(question.Title);
        
        SetAnswers(question.FirstAnswer.Name, question.SecondAnswer.Name, question.ThirdAnswer.Name, question.FourthAnswer.Name);
        SetCount(currentIndex, maximumLength);
    }
    
    
    private void SetTitle(String text)
    {
        _title.text = text;
    }
    
    private void SetCount(int count, int maximum)
    {
        _counter.text = $"{count + 1}/{maximum}";
    }

    private void SetAnswers(string answer1, string answer2, string answer3, string answer4)
    {
        _firstText.text = answer1;
        _secondText.text = answer2;
        _thirdText.text = answer3;
        _fourthText.text = answer4;
    }
}
