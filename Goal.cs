using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool playerGetsPoint;

    public GameManager gameManager;

    public Ball ball; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (playerGetsPoint)
                gameManager.PlayerScored();
            else
                gameManager.AIScored();

            if (!gameManager.gameOver)
            {
                ball.ResetBall();
            }
        }

    }
}