using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI pairsFoundText;
    private void OnEnable()
    {
        pairsFoundText.text = "Pairs Found: " + CardController.instance.pairsFound.ToString();
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
