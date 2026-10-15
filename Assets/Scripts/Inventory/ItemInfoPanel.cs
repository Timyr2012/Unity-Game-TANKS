using UnityEngine;
using UnityEngine.UI;

public class ItemInfoPanel : MonoBehaviour
{
    [Header("UI Елементи")]
    public Text itemNameText;
    public Text itemTypeText;
    public Text itemDescriptionText;
    public Text itemValueText;
    public Image itemIcon;

    void Start()
    {
        // На старті панель прихована
        gameObject.SetActive(false);
    }

    public void ShowItem(ItemData data)
    {
        if (data == null)
        {
            HidePanel();
            return;
        }

        gameObject.SetActive(true);

        itemNameText.text = data.itemName;
        itemTypeText.text = "Тип: " + data.itemType.ToString();
        itemDescriptionText.text = data.description;
        itemValueText.text = "Цінність: " + data.value;

        if (data.icon != null)
            itemIcon.sprite = data.icon;
    }

    public void HidePanel()
    {
        gameObject.SetActive(false);
    }
}