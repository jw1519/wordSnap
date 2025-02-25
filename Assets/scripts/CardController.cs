using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public static CardController instance;
    public Transform gameBoard;
    public Card cardPrefab;

    public Card firstCardSelected;
    public Card SecondCardSelected;

    public int cards = 12;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SelectedCard(Card card)
    {
        if (card.isSelected == false)
        {
            card.Show();
            if (firstCardSelected == null)
            {
                firstCardSelected = card;
                return;
            }
            if (SecondCardSelected == null)
            {
                SecondCardSelected = card;
                StartCoroutine(CheckForPair(firstCardSelected, SecondCardSelected));
                firstCardSelected = null;
                SecondCardSelected = null;
            }
        }
    }
    IEnumerator CheckForPair(Card a, Card b)
    {
        yield return new WaitForSeconds(0.3f);
        //if a and b match
        if (a.cardID == b.cardID)
        {
            Debug.Log("Pair Found");
        }
        else
        {
            a.Hide();
            b.Hide();
        }
        
    }
}
