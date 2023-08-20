using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    private void Start()
    {
        scoreText.text = "Score: ";
    }

    private void Update()
    {
        scoreText.text = "Score: " + scoreManager.score.ToString();
    }
}
