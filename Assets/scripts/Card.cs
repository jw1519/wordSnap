using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    private TextMeshProUGUI text;
    public bool isSelected;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void Setword(string word)
    {
        text.text = word;
    }
    public void Show()
    {
        isSelected = true;
    }
    public void Hide()
    {
        isSelected = false;
    }
}
