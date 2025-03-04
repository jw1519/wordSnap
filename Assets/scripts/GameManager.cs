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
            int random = Random.Range(0, words.Count);
            //check if the cards have already been made
            if (!numbersUsed.Contains(random))
            {
                Factory.instance.Create(words[random], random);
                Factory.instance.Create(synonyms[random], random);
            }
            else
            {
                i--;
            }
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
        }
    }
    public void GameOver()
    {
        Debug.Log("time up");
        gameOverPanel.SetActive(true);
    }
}
