using UnityEngine;

public class TreeCutter : MonoBehaviour
{

    [SerializeField] private LayerMask treeLayer;
    [SerializeField] private Camera playerCamera;
    
    void Update()
    {   

        Vector3 origin = playerCamera.transform.position;
        Vector3 direction = playerCamera.transform.forward;

        if (Input.GetMouseButton(0)) {

            RaycastHit hitInfo;

            Debug.Log("Mouse clicked!");

            if (Physics.Raycast(origin, direction, out hitInfo, 5f, treeLayer)) {

                TreeHealth tree = hitInfo.collider.GetComponent<TreeHealth>();

                if (tree != null)
                {
                    tree.TakeDamage(1);
                }
            }
        } 
    }
}
