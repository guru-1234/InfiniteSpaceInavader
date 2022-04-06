using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public Canvas GameOverCanvas;
    public Text FinalScore;

    void Start()
    {
        GameOverCanvas.gameObject.SetActive(false);
        Time.timeScale=1;
    }

    void Update()
    {
        FinalScore.text = EnemyCollider.score.ToString();
    }
    public void GameOver()
    {
        GameOverCanvas.gameObject.SetActive(true);
        Time.timeScale=0;
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale=1;
    }

}
