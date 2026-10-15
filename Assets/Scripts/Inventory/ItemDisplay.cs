using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Text itemNameText;
    public Text itemDescriptionText;
    public Image itemIconImage;

    // Виклич цей метод і передай будь-який ItemData
    public void ShowItem(ItemData item)
    {
        if (item == null) return;

        itemNameText.text = item.itemName;
        itemDescriptionText.text = item.description;
        itemIconImage.sprite = item.icon;
    }

    public void ClearDisplay()
    {
        itemNameText.text = "";
        itemDescriptionText.text = "";
        itemIconImage.sprite = null;
    }
}