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

    List<int> numbersUsed = new List<int>();

    private void Start()
    {
        words = textAssetWords.text.Split("\n").ToList();
        synonyms = textAssetSynonyms.text.Split("\n").ToList();
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
        CardController.instance.ShowCards();
    }
    public void GameOver()
    {

    }
}
