using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Slider slider;
    public Sprite[] towerSprites; 
    public SpriteRenderer towerSr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        if (health <= 0)
        {
            float healthPercentage = (float)health / maxHealth; //convert health to a value between 0 and 1
            int spriteIndex = Mathf.FloorToInt(healthPercentage * towerSprites.Length);
            towerSr.sprite = towerSprites[spriteIndex]
            ;

            //Destroy(slider.gameObject);
            //Destroy(gameObject);
        }
        else
        {
            float healthPercentage = (float)health / maxHealth; //convert health to a value between 0 and 1
            int spriteIndex = Mathf.Clamp(Mathf.FloorToInt(healthPercentage * towerSprites.Length -1),0, towerSprites.Length -1);
            towerSr.sprite = towerSprites[spriteIndex];
        }
    }
}
