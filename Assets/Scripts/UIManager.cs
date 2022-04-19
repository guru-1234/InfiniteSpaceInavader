using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Canvas Canvas;
    public Canvas GameOverCanvas;
    public Text ScoreText;
    public Text HighScore;
    public Text FinalScore;
    public Text HSIndication;
    private int HighScoreNum;
    private bool AlreadyActive=false;
 
    public void Awake() 
    {
       
        HighScore.text=PlayerPrefs.GetInt("HighScore").ToString();
        HighScoreNum= PlayerPrefs.GetInt("HighScore");
        GameOverCanvas.gameObject.SetActive(false);
    }
    private void Start()
    {
        HSIndication.gameObject.SetActive(false);
    }

    public void GameCanvasActive()
    {
        if(!AlreadyActive)
        {
            GameOverCanvas.gameObject.SetActive(false);
            AlreadyActive=true;
        }else
        {
            GameOverCanvas.gameObject.SetActive(true);
            AlreadyActive=false;
        }
    }

    public void FinalScoreText()
    {
        FinalScore.text = EnemyCollider.score.ToString();

        ScoreText.text = EnemyCollider.score.ToString();
        Debug.Log(EnemyCollider.score);

        if(EnemyCollider.score>HighScoreNum)
        {
            HighScoreNum=EnemyCollider.score;
            HighScore.text=HighScoreNum.ToString();
            HSIndication.gameObject.SetActive(true);
            PlayerPrefs.SetInt("HighScore",HighScoreNum);
        }
    }
}
