using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class starbutton: MonoBehaviour
{
    public void starbuttom()
    {
        // Reset skor saat mulai ulang
        Data.score = 0;
DontDestroyOnLoad(gameObject);
        // Ganti "Gameplay" dengan nama scene gameplay kamu
        SceneManager.LoadScene("gameplay");
        

    }
}
