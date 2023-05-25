using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIDisplayScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private BirdScore birdScore;

    private void Awake()
    {
        birdScore.OnScoreChanged += OnChangedScoreHandler;
    }

    private void OnChangedScoreHandler(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }

}
