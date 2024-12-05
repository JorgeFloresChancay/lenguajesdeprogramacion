using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource
    public AudioClip clip; // El archivo de audio a reproducir

    void Start()
    {
        // Asignar el clip al AudioSource si no está configurado
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play(); // Reproducir automáticamente
        }
    }

    public void PlaySound()
    {
        // Reproducir sonido manualmente
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void StopSound()
    {
        // Detener el sonido
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
