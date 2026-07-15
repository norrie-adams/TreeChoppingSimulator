using UnityEngine;

public class TreeCutter : MonoBehaviour
{

    [SerializeField] private LayerMask treeLayer;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Animator axeAnimator;
    
    void Update()
    {   

        Vector3 origin = playerCamera.transform.position;
        Vector3 direction = playerCamera.transform.forward;

        if (Input.GetMouseButtonDown(0)) {

            RaycastHit hitInfo;

            if (Physics.Raycast(origin, direction, out hitInfo, 5f, treeLayer)) {

                axeAnimator.SetTrigger("Swing");

                TreeHealth tree = hitInfo.collider.GetComponent<TreeHealth>();

                if (tree != null)
                {
                    tree.TakeDamage(1);
                }
            }
        } 
    }
}
