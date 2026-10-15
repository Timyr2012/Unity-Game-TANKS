using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "GameData/WeaponData")]
public class WeaponData : ScriptableObject
{
    [Header("Інформація")]
    public string weaponName;
    public string description;
    public Sprite icon;

    [Header("Характеристики")]
    public int damage;
    public float fireRate;       // постріли за секунду
    public float bulletSpeed;
    public int magazineSize;

    [Header("Звук та ефекти")]
    public AudioClip shootSound;
    public GameObject bulletPrefab;
    public GameObject muzzleFlashEffect;
}