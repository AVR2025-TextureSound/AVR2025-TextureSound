using UnityEngine;

public class MouseGrab : MonoBehaviour
{
    private bool isGrabbed = false;
    private Vector3 offset;
    private float zCoord;

    void Update()
    {
        // Objekt greifen
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    isGrabbed = true;
                    zCoord = Camera.main.WorldToScreenPoint(transform.position).z;
                    Vector3 mousePoint = Input.mousePosition;
                    mousePoint.z = zCoord;
                    offset = transform.position - Camera.main.ScreenToWorldPoint(mousePoint);
                }
            }
        }

        // Objekt loslassen
        if (Input.GetMouseButtonUp(0))
        {
            isGrabbed = false;
        }

        // Objekt mit Maus bewegen
        if (isGrabbed)
        {
            Vector3 mousePoint = Input.mousePosition;
            mousePoint.z = zCoord;
            transform.position = Camera.main.ScreenToWorldPoint(mousePoint) + offset;
        }
    }

}
