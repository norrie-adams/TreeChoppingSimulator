using UnityEngine;
using UnityEngine.AI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    public Inventory inventory;
    private Ray mouseRay;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mouseRay = playerCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out RaycastHit hitInfo, 5f))
            {
                if (hitInfo.collider.gameObject.name.Contains("Shop"))
                {   
                    inventory.SellItem();
                }
            }
        }
    }
}
