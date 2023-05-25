using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScore : MonoBehaviour
{
    [SerializeField] private BirdCollide birdCollide;
    private int _score;
    private int _bestScore;

    public Action<int> OnScoreChanged;

    public int Score 
    { 
        get
        {
            return _score;
        }
        private set
        {
            _score = value;
            OnScoreChanged?.Invoke(_score);
        }
    }

    public int BestScore
    {
        get
        {
            return _bestScore;
        }
        private set
        {
            _bestScore = value;
        }
    }

    private void Awake()
    {
        birdCollide.OnTriggeredScore += OnTriggeredScoreHandler;
        Score = 0;

        _bestScore = PlayerPrefs.GetInt(Strings.ppBestScore);
    }

    private void OnTriggeredScoreHandler()
    {
        Score++;

        if(_bestScore < Score)
        {
            _bestScore = Score;
            PlayerPrefs.SetInt(Strings.ppBestScore, _bestScore);
        }
    }
}
