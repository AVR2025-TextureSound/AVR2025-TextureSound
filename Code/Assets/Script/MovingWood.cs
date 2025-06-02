using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MovingWood : MonoBehaviour
{
    public AudioClip collisionSound; // Ziehe hier deine Audiodatei rein
    public string targetTag = "Wood"; // Das Objekt, mit dem die Stange kollidieren soll

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false; // Nicht automatisch abspielen
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag) && collisionSound != null)
        {
            audioSource.PlayOneShot(collisionSound);
        }
    }
}

