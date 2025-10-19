using UnityEngine;

[CreateAssetMenu(menuName ="Cards / Card", fileName ="New Card")]
public class CardData : ScriptableObject
{
    public Sprite Icon;
    public int Cost;
    //public float Cooldown;
    public Sprite plushSprite;
}