using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;


    public GameObject WinScreen;


    public void UpdateScore()
    {
        score++;

        scoreText.text = score.ToString();
    }

    public void Won()
    {
        Debug.Log("Won Function Call");
        WinScreen.SetActive(true);
    }

    public void Restarted()
    {
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
