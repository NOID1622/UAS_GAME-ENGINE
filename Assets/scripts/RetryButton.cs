using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void RetryGame()
    {
        // Reset skor saat mulai ulang
        Data.score = 0;
DontDestroyOnLoad(gameObject);
        // Ganti "Gameplay" dengan nama scene gameplay kamu
        SceneManager.LoadScene("gameplay");
        

    }
}
