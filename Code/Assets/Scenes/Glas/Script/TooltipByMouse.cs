using UnityEngine;
using TMPro;

public class TooltipByMouse : MonoBehaviour
{
    public GameObject tooltipPanel;           // Das Panel, das angezeigt wird
    public TextMeshProUGUI tooltipText;       // Das Textfeld im Panel
    public string generalInfoText;            // Allgemeiner Einführungstext

    void Update()
    {
        // Raycast von der Mausposition in die Szene
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Prüfe zuerst, ob ein Exponat getroffen wird
        if (Physics.Raycast(ray, out hit, 100f))
        {
            // Prüfe auf Exponat-Tags oder Namen
            if (hit.collider.CompareTag("Glas_1"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Dies ist Glas 1. Hier ist die spezifische Beschreibung.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_2"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Dies ist Glas 2. Hier ist die spezifische Beschreibung.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_3"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Dies ist Glas 3. Hier ist die spezifische Beschreibung.";
                return;
            }
            // Prüfe, ob der Mauszeiger über dem Bereich vor dem Tisch ist
            else if (hit.collider.gameObject == this.gameObject)
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = generalInfoText;
                return;
            }
        }
        // Wenn nichts Relevantes getroffen wurde: Tooltip ausblenden
        tooltipPanel.SetActive(false);
    }
}