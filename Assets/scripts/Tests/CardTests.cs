using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class CardTests
{
    [UnitySetUp]
    public IEnumerator SetUp()
    {
        SceneManager.LoadScene("GameScene");
        yield return null;
    }
    [UnityTest]
    public IEnumerator Card_OnClickRegistersSelection()
    {
        var card = GameObject.FindGameObjectWithTag("Card");
        yield return null;
        Assert.IsNotNull(card, "is null"); //is null shouldnt
        card.GetComponent<Button>().onClick.Invoke();
        yield return null;
        Assert.IsTrue(card.GetComponent<Card>().isSelected);

    }
    [UnityTest]
    public IEnumerator Card_ShowRevealsTextObject()
    {
        var card = GameObject.FindGameObjectWithTag("Card");
        card.GetComponent<Card>().Show();
        yield return null;
        Assert.IsTrue(card.GetComponent<Card>().text.gameObject.activeInHierarchy);
    }
    [UnityTest]
    public IEnumerator Card_HideHidesTextObject()
    {
        var card = GameObject.FindGameObjectWithTag("Card");
        card.GetComponent<Card>().Hide();
        yield return null;
        Assert.IsTrue(!card.GetComponent<Card>().text.gameObject.activeInHierarchy);
    }
    [UnityTest]
    public IEnumerator Card_SetwordAssignsTextCorrectly()
    {
        var cardGO = GameObject.FindGameObjectWithTag("Card");
        Card card = cardGO.GetComponent<Card>();
        card.Setword();
        yield return null;
        Assert.AreSame(card.text.text.ToString(), card.cardName);
    }
}
