using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip music;
    private AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = 0.5f;
        audioSource.Play();
    }
}
