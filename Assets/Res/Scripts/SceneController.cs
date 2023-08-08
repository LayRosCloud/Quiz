using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject[] _scenes;
    private const int FIRST_SCENE = 0;
    private void Awake()
    {
        SetActiveScene(FIRST_SCENE);
    }

    public void SetActiveScene(int index)
    {
        DisableAllScenes();
        try
        {
            ActivateScene(index);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    
    private void DisableAllScenes()
    {
        for (int i = 0; i < _scenes.Length; i++)
        {
            _scenes[i].SetActive(false);
        }
    }

    private void ActivateScene(int index)
    {
        _scenes[index].SetActive(true);
    }
}
