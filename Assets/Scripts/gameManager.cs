using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject box;
    public Text scoreText;
    public Text timeText;
    public static gameManager I;
    public Animator anim;
    public GameObject ball;
    public GameObject gameOverText;

    float begin = 0.00f;
    
    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBox", 0.5f, 0.5f);
        initGame();
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        begin = 0.00f;
    }

    void spawnBox()
    {
        Instantiate(box, new Vector3(Random.Range(-2.5f, 2.5f), 6.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        begin += Time.deltaTime;
        timeText.text = begin.ToString("N2");
    }

    public void gameOver()
    {
        anim.SetBool("isDie", true);
        gameOverText.SetActive(true);
        Time.timeScale = 0.0f;
        Invoke("dead", 0.5f);
    }

    public void retry(){
        SceneManager.LoadScene("MainScene");
    }

    void dead(){
        Time.timeScale = 0.0f;
        Destroy(ball);
    }
}
