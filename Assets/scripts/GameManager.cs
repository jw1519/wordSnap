using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    List<string> words;
    List<string> synonyms;
    List<int> numbersUsed = new List<int>();

    bool isRunning;

    public TextAsset textAssetWords;
    public TextAsset textAssetSynonyms;

    public float secondsToPlay;
    public TextMeshProUGUI timeText;

    public int amountOfPairs;

    public GameObject gameOverPanel;
    public GameObject gameWonPanel;
    private void Awake()
    {
        words = textAssetWords.text.Split("\n").ToList();
        synonyms = textAssetSynonyms.text.Split("\n").ToList();
        StartGame(words, synonyms);
    }

    public void StartGame(List<string> words, List<string> synonyms)
    {
        isRunning = true;
        for (int i = 0; i < amountOfPairs; i++)
        {
            Factory.instance.Create(words[i], i);
            Factory.instance.Create(synonyms[i], i);
        }
        Factory.instance.ShuffleCards();
        CardController.instance.ShowAllCards();
    }
    private void Update()
    {
        if (isRunning)
        {
            if (Time.timeSinceLevelLoad > secondsToPlay)
            {
                GameOver();
                isRunning = false;
            }
            else
            {
                timeText.text = Time.timeSinceLevelLoad.ToString();
            }
            if (amountOfPairs == CardController.instance.pairsFound)
            {
                GameWon();
                isRunning = false;
            }
        }
    }
    public void GameOver()
    {
        Debug.Log("time up");
        gameOverPanel.SetActive(true);
    }
    public void GameWon()
    {
        Debug.Log("Game won");
        gameWonPanel.SetActive(true);
    }
}
