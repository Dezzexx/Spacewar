using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    private int score;
    public TextMeshProUGUI scoreText;
    
    [SerializeField] Button restartButton;
    [SerializeField] Button exitButton;
    [SerializeField] Button resumeButton;
    
    void Start()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
    }

    void FixedUpdate()
    {
        PauseGame();
    }

    public void UpdateScore(int scoreToAdd)
    {
        if (isGameActive)
        {
            score += scoreToAdd;
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Start();
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            restartButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
            resumeButton.gameObject.SetActive(true);
            isGameActive = false;
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        isGameActive = true;
        restartButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
