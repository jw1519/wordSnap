using TMPro;
using UnityEngine;

public class Card : MonoBehaviour, ICard
{
    public TextMeshProUGUI text;

    public string cardName { get; set; }
    public int cardID { get; set; }
    public bool isSelected { get; set; }
    public bool isFound { get; set; }
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
