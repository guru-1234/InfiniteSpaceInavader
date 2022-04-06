using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public float speed=100f;
    public float horizontal;
    public Transform GunHolder;
    public GameObject ShootingPerfab;
    public Text ScoreText;
    public Text HighScore;
    public Text HSIndication;
    public new AudioSource audio;
    public static int HighScoreNum;
    // Start is called before the first frame update
    void Awake()
    {
        HighScoreNum= PlayerPrefs.GetInt("HighScore");
        HighScore.text=PlayerPrefs.GetInt("HighScore").ToString();
        HSIndication.gameObject.SetActive(false);
    }
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal")*speed;
        Vector3 targetvelocity = new Vector2(horizontal,playerRigidbody.velocity.y);
        playerRigidbody.velocity = Vector2.right*targetvelocity;

        if(Input.GetButtonDown("Fire1"))
        {
            audio.Play();
            Instantiate(ShootingPerfab,GunHolder.position,GunHolder.rotation);
        }
        Debug.Log(EnemyCollider.score);
        ScoreText.text = EnemyCollider.score.ToString();

        if(EnemyCollider.score>HighScoreNum)
        {
            HighScoreNum=EnemyCollider.score;
            HighScore.text=HighScoreNum.ToString();
            HSIndication.gameObject.SetActive(true);
            PlayerPrefs.SetInt("HighScore",HighScoreNum);
        }
    }

}
