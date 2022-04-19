using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    private static Gamemanager Instance;
    public UIManager UIinstance;

    private void Awake() {
        Instance=this;
    }
    public void Start()
    {
        UIinstance.GameCanvasActive();
        Time.timeScale=1;
    }

    public void Update()
    {
        Instance.ManagerCall();
    }
    public void GameOver()
    {
        UIinstance.GameCanvasActive();
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
        EnemyCollider.score=0;
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }

    public void MainMenu()
    {
        EnemyCollider.score=0;
        SceneManager.LoadScene(0);
        Time.timeScale=1;
    }

    private void ManagerCall()
    {
        UIinstance.FinalScoreText();
    }

}
