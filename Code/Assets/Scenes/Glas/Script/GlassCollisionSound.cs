using UnityEngine;

public class GlassCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject glassSplintersPrefab; // Im Inspector zuweisen

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision mit: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Flasche_3") && gameObject.CompareTag("Glas_3"))
        {
            // Sound abspielen
            if (audioSource != null && audioSource.isActiveAndEnabled)
                audioSource.Play();

            // Glassplitter an der Position des Glases instanziieren
            Instantiate(glassSplintersPrefab, transform.position, transform.rotation);

            // Ursprüngliches Glas zerstören
            Destroy(gameObject);
        }

        // Optional: Weiterhin Sound für andere Flaschen
        else if (collision.gameObject.CompareTag("Flasche_1") ||
                 collision.gameObject.CompareTag("Flasche_2"))
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
                audioSource.Play();
        }
    }
}