using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text woodText;
    [SerializeField] private TMP_Text moneyText;
    [SerializeField] private Inventory inventory;


    void Update()
    {
        woodText.text = "Wood: " + inventory.woodCount + "/5";
        moneyText.text = "Money: $" + inventory.playerMoney;
    } 
}
