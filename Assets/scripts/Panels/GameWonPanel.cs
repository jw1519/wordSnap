using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWonPanel : MonoBehaviour
{
    private void OnEnable()
    {

    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
