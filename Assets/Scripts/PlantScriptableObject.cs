using UnityEngine;

[CreateAssetMenu(menuName ="Cards/Plant Card", fileName ="New Plant Card")]
public class PlantScriptableObject : ScriptableObject
{
    public Sprite plantIcon;
    public int cost;
    public float cooldown;

}
