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
        for (int i = 0; i < _cardsInLevel.Length; i++)
        {
            ApplyData(_cardsInLevel[i]);
        }
    }
    public void ApplyData(CardData newData)
    {
        GameObject obj = Instantiate(_cardPrefab, _cardsHolder);
        obj.GetComponent<CardHandler>().ApplyData(newData);
    }
}