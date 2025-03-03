using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<string> words;
    List<string> synonyms;

    public TextAsset textAssetWords;
    public TextAsset textAssetSynonyms;

    public int amountOfPairs;
    public Transform gameBoard;

    public int timeToShowCard;
    bool cardsShown;
    float time;

    private void Start()
    {
        words = textAssetWords.text.Split("\n").ToList();
        synonyms = textAssetSynonyms.text.Split("\n").ToList();
        for (int i = 0; i < amountOfPairs; i++)
        {
            Factory.instance.Create(words[i], i);
            Factory.instance.Create(synonyms[i], i);
        }
        Factory.instance.ShuffleCards();
        ShowCards();
    }
    public void Update()
    {
        if (cardsShown == true)
        {
            if (time + timeToShowCard < Time.time)
            {
                HideCards();
            }
        }
    }
    public void ShowCards()
    {
        for (int i = 0; i < gameBoard.childCount; i++)
        {
            gameBoard.GetChild(i).GetComponent<Card>().Show();
        }
        cardsShown = true;
        time = Time.time;
    }    
    public void HideCards()
    {
        for (int i = 0; i < gameBoard.childCount; i++)
        {
            gameBoard.GetChild(i).GetComponent<Card>().Hide();
        }
        cardsShown = false;
    }
    public void GameWon()
    {

    }
}
