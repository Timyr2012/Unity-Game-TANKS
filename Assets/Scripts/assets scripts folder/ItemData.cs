using UnityEngine;

public enum ItemType { Weapon, Armor, Potion, Key }

[CreateAssetMenu(fileName = "NewItem", menuName = "GameData/ItemData")]
public class ItemData : ScriptableObject
{
    [Header("Основна інформація")]
    public string itemName;
    public string description;
    public Sprite icon;
    public ItemType itemType;

    [Header("Характеристики")]
    public int value;           // ціна або потужність ефекту
    public bool isStackable;    // чи можна складати в стопку

    [Header("Звук")]
    public AudioClip pickupSound;
}