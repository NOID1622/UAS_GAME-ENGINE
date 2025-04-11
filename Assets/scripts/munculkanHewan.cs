using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculkanHewan : MonoBehaviour
{


    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, obyekSampah.Length);

            // Tentukan posisi horizontal acak (X), spawn dari bawah layar (Y tetap)
                float randomX = Random.Range(-0.50f, 0.50f);


            Vector3 posisiBaru = new Vector3(randomX, -5f, 0); // Y = -5f untuk muncul dari bawah

            // Buat objek
            GameObject sampah = Instantiate(obyekSampah[random], posisiBaru, Quaternion.identity);

            // Tambahkan gerakan ke atas
            sampah.AddComponent<GerakKeAtas>();

            timer = 0;
        }
    }
}
