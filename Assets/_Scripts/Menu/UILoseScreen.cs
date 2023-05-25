using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILoseScreen : MonoBehaviour
{
    [SerializeField] private BirdCollide birdCollide;
    [SerializeField] private BirdScore birdScore;
    [SerializeField] private RectTransform loseScreenPanel;
    [SerializeField] private RectTransform difficultyPanel;
    [SerializeField] private TextMeshProUGUI scoreValueText;
    [SerializeField] private TextMeshProUGUI bestScoreValueText;
    [SerializeField] private TextMeshProUGUI difficultyText;

    private string _currentSceneName;

    private void Awake()
    {
        birdCollide.OnCollidedObstacle += OnCollidedObstacleHandler;
        loseScreenPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(false);
    }

    private void OnCollidedObstacleHandler()
    {
        loseScreenPanel.gameObject.SetActive(true);
        difficultyPanel.gameObject.SetActive(false);

        scoreValueText.text = birdScore.Score.ToString();
        bestScoreValueText.text = birdScore.BestScore.ToString();

        _currentSceneName = SceneManager.GetActiveScene().name;

        if(_currentSceneName == Strings.sceneEasyLevel)
        {
            difficultyText.text = "Easy";
        }
        else if(_currentSceneName == Strings.sceneNormalLevel)
        {
            difficultyText.text = "Normal";
        }
        else if (_currentSceneName == Strings.sceneHardLevel)
        {
            difficultyText.text = "Hard";
        }
        else
        {
            Debug.Log("Hasn't level scene");
        }
    }

    public void OnClickChangeDifficulty()
    {
        loseScreenPanel.gameObject.SetActive(false);
        difficultyPanel.gameObject.SetActive(true);
    }

    public void OnClickRetry()
    {
        Debug.Log("On Clicked Retry botton");
        if (_currentSceneName == Strings.sceneEasyLevel)
        {
            SceneManager.LoadScene(Strings.sceneEasyLevel);
        }
        else if (_currentSceneName == Strings.sceneNormalLevel)
        {
            SceneManager.LoadScene(Strings.sceneNormalLevel);
        }
        else if(_currentSceneName == Strings.sceneHardLevel)
        {
            SceneManager.LoadScene(Strings.sceneHardLevel);
        }
        else
        {
            Debug.Log("Hasn't level scene");
        }
    }
}
