using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public TextMeshProUGUI text;
    public bool isSelected;
    public bool isFound;

    public string cardName;
    public int cardID;

    private void Awake()
    {
        isSelected = false;
    }
    public void Setword()
    {
        text.text = cardName;
    }
    public void Show()
    {
        if (!isSelected == true)
        {
            isSelected = true;
            text.gameObject.SetActive(true);
        }
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
