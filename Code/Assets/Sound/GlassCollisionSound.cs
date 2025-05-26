using UnityEngine;

public class GlassCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision erkannt mit: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Flasche")) // Tag ggf. anpassen oder entfernen
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
    }

}
