using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class CardTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void CardTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CardTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;

        var card = GameObject.FindGameObjectWithTag("Card");
        Assert.IsNotNull(card); //is null shouldnt
        card.GetComponent<Button>().onClick.Invoke();

        Assert.IsTrue(card.GetComponent<Card>().isSelected);
    }
}
