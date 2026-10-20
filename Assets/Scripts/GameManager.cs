using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // other scripts use GameManager.instance
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject gameOverPanel; // leave EMPTY until Part 10
    public int lives = 3;
    private int score = 0;
    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        if(gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
        UpdateUI();
    }
    public void AddGameScore(int amount)
    {
        if (isGameOver)
        {
            return;
        }
        score += amount;
        UpdateUI();   
    }
    public void LoseLife()
    {
        if(isGameOver) return;
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }
    void UpdateUI()
    {
        scoreText.text = "Score : " + score;
        livesText.text = "Lives : " + lives;
    }
    void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over ! Final Score is " + score );
        if(gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        instance =this;
    }
    
}
