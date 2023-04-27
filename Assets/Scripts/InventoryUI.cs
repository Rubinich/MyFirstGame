using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI CoinText;

    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinText(PlayerInventory playerInventory)
    {
        CoinText.text = "Coins: " + playerInventory.NumberOfCoins.ToString();
    }
}