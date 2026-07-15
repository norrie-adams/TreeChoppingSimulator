using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask treeLayer;

    public void DealAxeDamage()
    {
        Vector3 origin = playerCamera.transform.position;
        Vector3 direction = playerCamera.transform.forward;

        if (Physics.Raycast(origin, direction, out RaycastHit hitInfo, 5f, treeLayer))
        {
            TreeHealth tree = hitInfo.collider.GetComponentInParent<TreeHealth>();

            if (tree != null)
            {
                tree.TakeDamage(1);
            }
        }
    }
}
