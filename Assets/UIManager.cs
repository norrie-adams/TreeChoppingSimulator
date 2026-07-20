using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text woodText;
    [SerializeField] private Inventory inventory;

    void Update()
    {
        woodText.text = "Wood: " + inventory.woodCount + "/5";
    } 
}
