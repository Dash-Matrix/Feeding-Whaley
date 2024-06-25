using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;


    public void UpdateScore()
    {
        score++;

        scoreText.text = score.ToString();
    }
}
