using UnityEngine;

public class TooltipTriggerScript : MonoBehaviour
{
    public GameObject tooltipPanel; // Tooltip-Panel aus der Canvas

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Stelle sicher, dass dein Spieler den Tag "Player" hat
        {
            tooltipPanel.SetActive(true); // Tooltip anzeigen
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tooltipPanel.SetActive(false); // Tooltip ausblenden
        }
    }
}