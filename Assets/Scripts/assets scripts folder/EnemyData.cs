using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "GameData/EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("Основні характеристики")]
    public string enemyName;
    public int health;
    public float speed;
    public int damage;

    [Header("Візуал")]
    public Material enemyMat;
    public Color enemyColor = Color.white;
}