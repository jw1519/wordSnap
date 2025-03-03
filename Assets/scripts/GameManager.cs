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
        CardController.instance.ShowCards();
    }
    public void GameOver()
    {

    }
}
