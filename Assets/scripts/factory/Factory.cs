using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public static Factory instance;

    public Card cardPrefab;
    public Transform parent;

    List<Transform> cards = new List<Transform>();

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //create card with an id
    public void Create(string cardName, int id)
    {
        GameObject instance = Instantiate(cardPrefab.gameObject, parent);
        Card newCard = instance.GetComponent<Card>();
        newCard.cardName = cardName;
        newCard.cardID = id;
        newCard.Setword();
    }
    public void ShuffleCards()
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < parent.childCount; i++)
        {
            indexes.Add(i);
            cards.Add(parent.GetChild(i));
        }
        foreach(var card in cards)
        {
            card.SetSiblingIndex(indexes[Random.Range(0, indexes.Count)]);
        }
    }
}
