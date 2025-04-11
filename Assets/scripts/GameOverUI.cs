using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("CurrentScore", 0);
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        scoreText.text = "Score anda sekarang: " + score.ToString();
        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
