using UnityEngine;

[RequireComponent(typeof(QuestionUI), typeof(ResultUI))]
public class QuetionController : MonoBehaviour
{
    [SerializeField] private SceneController _sceneController;
    [SerializeField] private QuestAnimator _questAnimator;
    [Header("Arrays")]
    [SerializeField] private Quetion[] _questions;
    [SerializeField] private Result[] _results;
    [SerializeField] private LocalizationController _localizationController;
    private int _currentQuestionIndex;
    private int _currentBalls;
    
    private QuestionUI _ui;
    private ResultUI _resultUi;
    
    private const int RESULT_SCENE = 2;
    private void Awake()
    {
        _ui = GetComponent<QuestionUI>();
        _resultUi = GetComponent<ResultUI>();
        _ui.UpdateQuestion(_questions[_currentQuestionIndex], _currentQuestionIndex, _questions.Length);
        _localizationController.ChangeLocalizationEvent.AddListener(UpdateQuestion);
    }
    
    public void ClickOnAnswer(int indexAnswer)
    {
        AnswerNumber answerNumber = (AnswerNumber)indexAnswer;
        NextQuestion(answerNumber);
        _currentQuestionIndex++;
        if (_currentQuestionIndex + 1 > _questions.Length)
        {
            SendResult();
            return;
        }
    }

    private void SendResult()
    {
        _sceneController.SetActiveScene(RESULT_SCENE);
        
        for (int i = 0; i < _results.Length; i++)
        {
            Result result = _results[i];
            Debug.Log($"{_currentBalls <= result.Balls}= Balls: {_currentBalls} ResultBalls: {result.Balls}");
            if (_currentBalls <= result.Balls)
            {
                _resultUi.UpdateResult(result);
                break;
            }
        }
    }

    private void NextQuestion(AnswerNumber indexAnswer)
    {
        Quetion question = _questions[_currentQuestionIndex];
        _currentBalls += question.ClickOnAnswer(indexAnswer);
        Debug.Log(_currentBalls);
        _questAnimator.Play();
    }

    public void UpdateQuestion()
    {
        _ui.UpdateQuestion(_questions[_currentQuestionIndex], _currentQuestionIndex, _questions.Length);
    }
}
