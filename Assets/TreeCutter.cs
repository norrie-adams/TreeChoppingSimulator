using UnityEngine;

public class TreeCutter : MonoBehaviour
{

    [SerializeField] private LayerMask treeLayer;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private Animator axeAnimator;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            
            axeAnimator.SetTrigger("Swing");

        } 
    }
}
