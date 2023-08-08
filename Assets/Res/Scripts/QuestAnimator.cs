using UnityEngine;

public class QuestAnimator : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private QuetionController _quetionController;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Play()
    {
        _animator.SetBool("Next", true);
    }

    public void NextQuest()
    {
        _quetionController.UpdateQuestion();
    }

    public void End()
    {
        _animator.SetBool("Next", false);
    }
}
