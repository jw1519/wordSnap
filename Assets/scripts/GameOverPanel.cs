using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI pairsFoundText;
    private void OnEnable()
    {
        pairsFoundText.text = "Pairs Found: " + CardController.instance.pairsFound.ToString();
    }
}
