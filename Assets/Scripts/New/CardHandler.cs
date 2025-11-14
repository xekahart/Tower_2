using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets.Scripts.GameEvents;

public class CardHandler: MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _costText;
    //[SerializeField] private TextMeshProUGUI _coolDownText;

    [SerializeField] private GameCardDataEvent _onButtonPressed;

    private Button _button;
    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    public void ApplyData(CardData newCard)
    {
        _icon.sprite = newCard.Icon;
        _costText.text = newCard.Cost.ToString();
        //_coolDownText.text = newCard.Cooldown.ToString();

        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(() => _onButtonPressed.Raise(newCard));
    }
}