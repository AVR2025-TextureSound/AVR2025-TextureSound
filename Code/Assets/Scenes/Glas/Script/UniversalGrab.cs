using UnityEngine;
using UnityEngine.InputSystem;

public class UniversalGrab : MonoBehaviour
{
    private bool isGrabbed = false;
    private Vector3 offset;
    private float zCoord;

    public void OnGrab(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Glas_1")) // oder dein gewünschtes Tag
                {
                    isGrabbed = true;
                    zCoord = Camera.main.WorldToScreenPoint(hit.transform.position).z;
                    Vector3 mousePoint = Mouse.current.position.ReadValue();
                    mousePoint.z = zCoord;
                    offset = hit.transform.position - Camera.main.ScreenToWorldPoint(mousePoint);
                }
            }
        }
    }

    public void OnRelease(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isGrabbed = false;
        }
    }

    void Update()
    {
        if (isGrabbed)
        {
            Vector3 mousePoint = Mouse.current.position.ReadValue();
            mousePoint.z = zCoord;
            // Hier ggf. das aktuelle Objekt bewegen
            // Beispiel: transform.position = Camera.main.ScreenToWorldPoint(mousePoint) + offset;
        }
    }
}