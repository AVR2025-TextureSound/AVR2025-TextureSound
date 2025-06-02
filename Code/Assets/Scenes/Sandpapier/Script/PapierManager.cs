using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PapierManager : MonoBehaviour
{
    public PapierInfo[] papierObjekte; // Alle Papierobjekte
    public GameObject infoPanel;       // Das UI-Panel
    public TextMeshProUGUI infoText;            // Das Textfeld im Panel

    private int aktuellesIndex = 0;

    void Start()
    {
        AuswahlAktualisieren();
        infoPanel.SetActive(false);
    }

    void Update()
    {
        // Mit Links/Rechts durch die Papierobjekte navigieren
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            aktuellesIndex = (aktuellesIndex - 1 + papierObjekte.Length) % papierObjekte.Length;
            AuswahlAktualisieren();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            aktuellesIndex = (aktuellesIndex + 1) % papierObjekte.Length;
            AuswahlAktualisieren();
        }

        // Info anzeigen/verstecken
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (infoPanel.activeSelf)
                infoPanel.SetActive(false);
            else
            {
                infoPanel.SetActive(true);
                infoText.text = papierObjekte[aktuellesIndex].infoText;
            }
        }
    }

    void AuswahlAktualisieren()
    {
        // Optional: hebe das aktuell ausgewählte Papierobjekt hervor (z.B. mit einer Outline)
        for (int i = 0; i < papierObjekte.Length; i++)
        {
            papierObjekte[i].gameObject.GetComponent<Renderer>().material.color = (i == aktuellesIndex) ? Color.yellow : Color.white;
        }
    }
}
