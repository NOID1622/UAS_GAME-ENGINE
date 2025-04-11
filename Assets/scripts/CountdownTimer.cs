using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float waktu = 30f; // Waktu hitung mundur (dalam detik)
    public Text teksWaktu;    // Referensi ke komponen UI Text

    void Update()
    {
        if (waktu > 0)
        {
            waktu -= Time.deltaTime;
            teksWaktu.text = Mathf.CeilToInt(waktu).ToString();
        }
        else
        {
            
            PlayerPrefs.SetInt("CurrentScore", Data.score);

            
            int highScore = PlayerPrefs.GetInt("HighScore", 0);
            if (Data.score > highScore)
            {
                PlayerPrefs.SetInt("HighScore", Data.score);
            }

            
            SceneManager.LoadScene("GameOver");
        }
    }
}
