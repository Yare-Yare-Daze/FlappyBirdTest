using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIDifficultyScreen : MonoBehaviour
{
    public void OnClickEasy()
    {
        SceneManager.LoadScene(Strings.sceneEasyLevel);
    }

    public void OnClickNormal()
    {
        SceneManager.LoadScene(Strings.sceneNormalLevel);
    }

    public void OnClickHard()
    {
        SceneManager.LoadScene(Strings.sceneHardLevel);
    }
}
