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
            if (hit.collider.CompareTag("Glas_1") || hit.collider.CompareTag("Flasche_1"))
                {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das Glas gegen die Falsche um einen Sound zu erzeugen.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_2") || hit.collider.CompareTag("Flasche_2"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das blau/grüne Glas gegen die blau/grüne Falsche um einen Sound und eine Vibration zu erzeugen.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_3") || hit.collider.CompareTag("Flasche_3"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das rosa/rötliche Glas gegen die rosa/rötliche Flasche um Scherben zu erzeugen. Es ertönt ein Sound und eine Vibration. Das Glas zerfällt in Scherben.";
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