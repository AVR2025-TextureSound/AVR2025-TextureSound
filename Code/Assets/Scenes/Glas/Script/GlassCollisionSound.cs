using UnityEngine;

public class GlassCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject glassSplintersPrefab; // Im Inspector zuweisen

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision mit: " + collision.gameObject.name);

        // Glas_3 trifft Flasche_3: Sound, Splitter, Destroy
        if (collision.gameObject.CompareTag("Flasche_3") && gameObject.CompareTag("Glas_3"))
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
            {
                audioSource.Play();

                // Glassplitter an der Position des Glases instanziieren
                Instantiate(glassSplintersPrefab, transform.position, transform.rotation);

                // Mesh und Collider sofort deaktivieren, damit das Objekt "zerstört" aussieht
                if (GetComponent<MeshRenderer>() != null)
                    GetComponent<MeshRenderer>().enabled = false;
                if (GetComponent<Collider>() != null)
                    GetComponent<Collider>().enabled = false;

                // Objekt erst nach Soundende zerstören
                Destroy(gameObject, audioSource.clip.length);
            }
            else
            {
                Instantiate(glassSplintersPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        // Glas_2 trifft Flasche_2: Nur Sound
        else if (collision.gameObject.CompareTag("Flasche_2") && gameObject.CompareTag("Glas_2"))
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
                audioSource.Play();
        }
        // Optional: Sound für andere Flaschen
        else if (collision.gameObject.CompareTag("Flasche_1"))
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
                audioSource.Play();
        }
    }
}