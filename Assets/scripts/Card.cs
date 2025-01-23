using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool isSelected;

    private void Awake()
    {
        isSelected = false;
    }
    public void Setword(string word)
    {
        text.text = word;
    }
    public void Show()
    {
        isSelected = true;
        text.gameObject.SetActive(true);
    }
    public void Hide()
    {
        isSelected = false;
        text.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        CardController.instance.SelectedCard(this);
    }
}
