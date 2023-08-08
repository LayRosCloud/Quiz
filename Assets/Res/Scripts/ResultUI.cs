using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _description;
 
    public void UpdateResult(Result result)
    {
        _title.text = result.Title;
        _description.text = result.Description;
        _image.sprite = result.Sprite;
    }
}