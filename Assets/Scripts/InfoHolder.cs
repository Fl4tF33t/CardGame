using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoHolder : MonoBehaviour
{
    public static InfoHolder finalScore;
    public int score1;
    public int score2;

    private void Awake()
    {
        finalScore = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "GamePlay")
        {
            score1 = GameController.instance.plusScore;
        }

        if (sceneName == "GamePlay1")
        {
            score2 = GameController.instance.plusScore;
        }
    }
}
