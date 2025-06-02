using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(MeshRenderer))]
public class AutoBoxColliderFit : MonoBehaviour
{
    void Reset()
    {
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if (boxCollider != null && renderer != null)
        {
            boxCollider.center = renderer.bounds.center - transform.position;
            boxCollider.size = renderer.bounds.size;
        }
    }
}