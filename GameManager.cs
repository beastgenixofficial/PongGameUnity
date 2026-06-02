using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public int aiScore = 0;

    public TMP_Text playerScoreText;
    public TMP_Text aiScoreText;
    
    public GameObject playerWinsText;
    public GameObject CPUWinsText;
    public GameObject restartText;

    public bool gameOver = false;

    public Ball ball;

    void Start()
    {
        UpdateScoreUI();
    }

    public void PlayerScored()
    {
        if (gameOver) return;

        playerScore++;
        UpdateScoreUI();

        if (playerScore >= 5)
        {
            gameOver = true;
            playerWinsText.SetActive(true);
            restartText.SetActive(true);

            Debug.Log("PLAYER WINS!");

            ball.StopBall();
        }
    }
        public void AIScored()
        {
            if (gameOver) return;

            aiScore++;
            UpdateScoreUI();

            if (aiScore >= 5)
            {
                gameOver = true;
            CPUWinsText.SetActive(true);
            restartText.SetActive(true);

            Debug.Log("AI WINS!");

                ball.StopBall();
            }
        }
    

    void UpdateScoreUI()
    {
        playerScoreText.text = playerScore.ToString();
        aiScoreText.text = aiScore.ToString();
    }
    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        playerScore = 0;
        aiScore = 0;

        gameOver = false;
        playerWinsText.SetActive(false);
        CPUWinsText.SetActive(false );
        restartText.SetActive(false);

        UpdateScoreUI();

        ball.ResetBall();
    }
}