using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private GameObject _cardPrefab; //card mold

    [SerializeField] private RectTransform _cardsHolder; //cards parent

    [SerializeField] private CardData[] _cardsInLevel; //all card in this level

    private void Start()
    {
        InitializeCards();
    }
    public void InitializeCards()
    {
        //Show in UI
        //cardsHolder children
        for (int i = 0; i < _cardsInLevel.Length; i++)   // R: explain pls
        {
            ApplyData(_cardsInLevel[i]);
        }
    }
    public void ApplyData(CardData newData)
    {
        GameObject obj = Instantiate(_cardPrefab, _cardsHolder);
        
        CardHandler newCard = obj.GetComponent<CardHandler>();

        newCard.ApplyData(newData); // R: explain dis too pls :v

        // tratando de agregar el drag and drop
       // CardManager_2 cardManager_2 = CardData.GetComponent<CardManager_2>();
    }
}