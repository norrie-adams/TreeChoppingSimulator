using UnityEngine;

public class TreeHealth : MonoBehaviour
{
    [SerializeField] private int treeHealth = 5;

    public void TakeDamage(int damage)
    {
        treeHealth -= damage;

        Debug.Log("Tree health: " + treeHealth);

        if (treeHealth <= 0)
        {
            Animator anim = GetComponent<Animator>();

            if (anim != null)
            {
        
                anim.Play("TreeFalling"); 
            }
        }
    }
}
