using UnityEngine;
using UnityEngine.EventSystems;

public class CardManager_2 : MonoBehaviour, IDragHandler, IDropHandler, IPointerUpHandler
{
    public CardData cardData;
    public Sprite plushSprite; 
    public void OnDrag(PointerEventData eventData)
    {
        // Take GameObject
        plushSprite = cardData.plushSprite;
    }

    public void OnDrop(PointerEventData eventData)
    {
      // Place the gameObjet
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Remove the gameObject

    }
}
