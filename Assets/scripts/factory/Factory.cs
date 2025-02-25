using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{

    private Card cardPrefab;
    public Transform parent;

    public Card GetCard(Vector2 position)
    {
        GameObject instance = Instantiate(cardPrefab.gameObject, parent);
        Card newCard = instance.GetComponent<Card>();
        return newCard;
    }
}
