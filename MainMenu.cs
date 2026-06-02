using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject menuPanel;
    public Ball ball;
    public GameObject playerScoreText;
    public GameObject aiScoreText;

    public void PlayGame()
    {
        menuPanel.SetActive(false);
        playerScoreText.gameObject.SetActive(true);
        aiScoreText.gameObject.SetActive(true);

        ball.LaunchBall();
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}