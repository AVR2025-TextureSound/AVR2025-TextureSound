using UnityEngine;

public class MetalCollisionSound : MonoBehaviour
{
    public AudioClip glassHitSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Prüfe, ob das andere Objekt das Tag "Glas" hat
        if (collision.gameObject.CompareTag("Glas"))
        {
            audioSource.PlayOneShot(glassHitSound);
        }
    }
}
