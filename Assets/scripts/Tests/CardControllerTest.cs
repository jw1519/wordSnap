using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class CardControllerTest
{
    [UnitySetUp]
    public IEnumerator SetUp()
    {
        SceneManager.LoadScene("GameScene");
        yield return null;
    }

    [UnityTest]
    public IEnumerator CardController_CardsHideAfterDelay()
    {
        yield return null;
    }
}
