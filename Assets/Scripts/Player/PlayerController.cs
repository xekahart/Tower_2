using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CardData _currentCard;
    [SerializeField] private LayerMask _layerMask;

    private InputAction _onPositionClick;

    private PlayerInput _playerInput;


    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _onPositionClick = _playerInput.actions["PositionClick"];
    }
    public void SetCard(CardData newData)
    {
        _currentCard = newData;
    }
    public void PlaceCard(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_currentCard == null) return;

            Vector2 pos = _onPositionClick.ReadValue<Vector2>();
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(pos);

            Collider2D obj = Physics2D.OverlapPoint(worldPos);
            if (obj != null)
            {
                Instantiate(_currentCard._prefab, obj.transform.position, Quaternion.identity);
            }
        }
    }
}