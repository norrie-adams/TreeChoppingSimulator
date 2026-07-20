using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int woodCount = 0;

    public bool HasSpaceForWood()
    {
        if (woodCount < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddWood()
    {
        woodCount += 1;
        Debug.Log("Wood Count Is: " + woodCount);
    }
}
