using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class PlantCardManager : MonoBehaviour
{
    //[Header("UI Parameters")]
    //public Image plantIconDisp;
    //public TMP_Text plantCostDisp;

    [Header("Cards Parameters")]
    public int amtOfCards;
    int index = 0;
    public PlantScriptableObject[] plantCardSO;
    public GameObject cardPrefab;
    public Transform cardHolderTransform;

    [Header("Plant Parameters")]
    public PlantScriptableObject plantCard;
    public float cooldown;
    public int cost;
    public Sprite plantIcon;

    private void Start()
    {
        plantCard = plantCardSO[amtOfCards];

        for (int i = 0; i < amtOfCards; i++)
        {
            AddPlantCard(i);

        }
    }
    public void AddPlantCard(int index)
    {
        GameObject card = Instantiate(cardPrefab,cardHolderTransform);

       // plantCard[index] = card;

        //Getting Variables
        plantIcon = plantCardSO[index].plantIcon;
        cost = plantCardSO[index].cost;
        cooldown = plantCardSO[index].cooldown;
        //Updating UI
        card.GetComponentInChildren<Image>().sprite  = plantIcon;
        card.GetComponentInChildren<TMP_Text>().text = "" + cost;

    }

}
