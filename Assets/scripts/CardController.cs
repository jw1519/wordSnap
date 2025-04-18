using System.Collections;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public static CardController instance;
    public Transform gameBoard;
    public Card cardPrefab;
    public int timeToShowCard;

    public int pairsFound;

    Card firstCardSelected;
    Card SecondCardSelected;

    bool cardsShown;
    float time;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void Update()
    {
        if (cardsShown == true)
        {
            if (time + timeToShowCard < Time.time)
            {
                HideAllCards();
            }
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
            pairsFound++;
            a.isFound = true;
            b.isFound = true;
        }
        else
        {
            a.Hide();
            b.Hide();
        } 
    }
    public void ShowAllCards()
    {
        for (int i = 0; i < gameBoard.childCount; i++)
        {
            gameBoard.GetChild(i).GetComponent<Card>().Show();
        }
        cardsShown = true;
        time = Time.time;
    }
    public void HideAllCards()
    {
        for (int i = 0; i < gameBoard.childCount; i++)
        {
            //if pair is found dont show card
            if (gameBoard.GetChild(i).GetComponent<Card>().isFound == false)
            {
                gameBoard.GetChild(i).GetComponent<Card>().Hide();
            }
        }
        cardsShown = false;
    }
}
