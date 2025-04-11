using UnityEngine;

public class GerakKeAtas : MonoBehaviour
{
    public float kecepatan = 2f;

    void Update()
    {
         transform.position += Vector3.up * kecepatan * Time.deltaTime;

        // Hapus objek jika sudah keluar layar atas
        if (transform.position.y > 2.5f)
        {
            Destroy(gameObject);
        }
    }
}
