using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text textScore,highScoreText,scoreInGameOverPanelText, highscoreInGameOverPanelText;
    public int score, scoreInGameOverPanel,highScore, highscoreInGameOverPanel;
    public GameObject pausePanel, startPanel, pauseBtn, coinImg, scoreText, gameOverPanel;
    public bool isGAmeStart,isTimeStart;
    public float timeElapsed,startTime;

    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
    }
    void Start()
    {
        
        isGAmeStart = false;
        isTimeStart = false;
       // Time.timeScale = 0;
        pausePanel.SetActive(false);
        startPanel.SetActive(true);
        pauseBtn.SetActive(false);
        coinImg.SetActive(false);
        scoreText.SetActive(false);
        gameOverPanel.SetActive(false);

        highScore =  PlayerPrefs.GetInt("HighScore",0);
        highScoreText.text = "you have to overcome: " + highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Ecape();
        startTime = Time.time;

        highscoreInGameOverPanel = PlayerPrefs.GetInt("HighScore", 0);
        highscoreInGameOverPanelText.text = "your high score: " + highscoreInGameOverPanel.ToString();
        textScore.text = score.ToString();
       // highScoreText.text = "High Score Text Demo: " + score.ToString();
        scoreInGameOverPanelText.text ="Your Current Score: " + score.ToString();
        PlayerPrefs.SetInt("scoreInGameOverPanelToken",scoreInGameOverPanel);
        PlayerPrefs.GetInt("scoreInGameOverPanelToken",0);
        
        if (score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

       
       // Debug.Log(timeElapsed);
        TimeCount();
    }

    public void TimeCount() 
    {
        /*if (isTimeStart == true && Time.timeScale != 0)
        {
            timeElapsed = PlayerPrefs.GetFloat("Time_Count");
        }
        else if (isTimeStart == false && Time.timeScale == 0)
        {
            timeElapsed = 0;
        }
        float timeCount= Time.realtimeSinceStartup;
        PlayerPrefs.SetFloat("Time_Count",timeCount);
        PlayerPrefs.Save();*/

        
       /*if (isTimeStart == true   && Time.timeScale != 0)
        {
            timeElapsed = Time.time - startTime;
           // PlayerPrefs.SetFloat("Time",timeElapsed);
           // timeElapsed = PlayerPrefs.GetFloat("Time");
        }
        else if (isTimeStart == false && Time.timeScale == 0)
        {
            timeElapsed = 0;
         // timeElapsed = PlayerPrefs.GetFloat("Time");


        }*/
    }

    
    public void PauseGame() 
    {
        Time.timeScale = 0;
        isTimeStart = false;
        pausePanel.SetActive(true);
        pauseBtn.SetActive(false);
        coinImg.SetActive(false);
        scoreText.SetActive(false);
    }
    public void StartGame() {

        // Time.timeScale = 1;
        isGAmeStart = true;
        isTimeStart = true;
        startPanel.SetActive(false);
        pauseBtn.SetActive(true);
        coinImg.SetActive(true);
        scoreText.SetActive(true);
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1;
        isTimeStart = false;
        pausePanel.SetActive(false);
        pauseBtn.SetActive(true);
        coinImg.SetActive(true);
        scoreText.SetActive(true);
    }
    public void GameOverPanel() 
    {
        // Time.timeScale = 0;
        isTimeStart = false;
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
        coinImg.SetActive(false);
        scoreText.SetActive(false);

    }
    public void ReStart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void Ecape() 
    {
        if (Application.platform==RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                isTimeStart = false;
                pausePanel.SetActive(true);
                pauseBtn.SetActive(false);
                coinImg.SetActive(false);
                scoreText.SetActive(false);
            }
        }
        
    
    }

    public void ExitButton() 
    {

        Application.Quit();
    }
}
