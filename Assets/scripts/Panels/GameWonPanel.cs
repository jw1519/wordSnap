using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameWonPanel : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private void OnEnable()
    {
        timeText.text = "Time: " + Time.timeSinceLevelLoad.ToString();
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
