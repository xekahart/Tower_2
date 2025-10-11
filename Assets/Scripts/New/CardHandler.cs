using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardHandler: MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _costText;
    //[SerializeField] private TextMeshProUGUI _coolDownText;

    public void ApplyData(CardData newCard)
    {
        _icon.sprite = newCard.Icon;
        _costText.text = newCard.Cost.ToString();
        //_coolDownText.text = newCard.Cooldown.ToString();
    }
}