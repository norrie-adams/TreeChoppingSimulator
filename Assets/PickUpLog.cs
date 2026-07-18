using UnityEngine;

public class PickUpLog : MonoBehaviour 
{
    [SerializeField] private Camera playerCamera; 
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Right Click
        {
            PickUpWood();
        }
    }

    void PickUpWood() 
    {
        Vector3 origin = playerCamera.transform.position; 
        Vector3 direction = playerCamera.transform.forward; 

        Ray mouseRay = playerCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out RaycastHit hitInfo, 5f)) 
        {
            if (hitInfo.collider.gameObject.name.Contains("Log") || hitInfo.collider.CompareTag("Tree"))
            {
                Debug.Log("Hit and destroyed: " + hitInfo.collider.gameObject.name);
                
                Destroy(hitInfo.collider.gameObject); 

                
            }
        } 
    }
}
