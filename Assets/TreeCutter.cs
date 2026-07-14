using Unity.VisualScripting;
using UnityEngine;

public class TreeCutter : MonoBehaviour
{

    [SerializeField] private LayerMask treeLayer;
    [SerializeField] private Camera playerCamera;
    
    void Update()
    {   
        Vector3 origin = playerCamera.transform.position;
        Vector3 direction = playerCamera.transform.forward;

        RaycastHit hitInfo;

        if (Physics.Raycast(origin, direction, out hitInfo, 5f, treeLayer))
        {
            Debug.Log("Hit: " + hitInfo.collider.name);
        }
    }
}
