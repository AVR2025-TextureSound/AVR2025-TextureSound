using UnityEngine;
using TMPro;

public class TooltipByMouse : MonoBehaviour
{
    public GameObject tooltipPanel;           // Das Panel, das angezeigt wird
    public TextMeshProUGUI tooltipText;       // Das Textfeld im Panel
    public string generalInfoText;            // Allgemeiner Einf�hrungstext

    void Update()
    {
        // Raycast von der Mausposition in die Szene
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Pr�fe zuerst, ob ein Exponat getroffen wird
        if (Physics.Raycast(ray, out hit, 100f))
        {
            // Pr�fe auf Exponat-Tags oder Namen
            if (hit.collider.CompareTag("Glas_1") || hit.collider.CompareTag("Flasche_1"))
                {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das Glas gegen die Falsche um einen Sound zu erzeugen.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_2") || hit.collider.CompareTag("Flasche_2"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das blau/gr�ne Glas gegen die blau/gr�ne Falsche um einen Sound und eine Vibration zu erzeugen.";
                return;
            }
            else if (hit.collider.CompareTag("Glas_3") || hit.collider.CompareTag("Flasche_3"))
            {
                tooltipPanel.SetActive(true);
                tooltipText.text = "Bewege das rosa/r�tliche Glas gegen die rosa/r�tliche Flasche um Scherben zu erzeugen. Es ert�nt ein Sound und eine Vibration. Das Glas zerf�llt in Scherben.";
                return;
            }
            // Pr�fe, ob der Mauszeiger �ber dem Bereich vor dem Tisch ist
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