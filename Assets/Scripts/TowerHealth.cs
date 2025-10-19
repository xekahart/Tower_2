using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Slider slider;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    public SheepLife[] sheeps;
    public int currentSheep = 0;
    public Animator animator;

    public void damageSheep()
    {
        sheeps[currentSheep].takeDamage();
        
        if (currentSheep < sheeps.Length - 1)
        {
            currentSheep++;
        }
    }

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
                                                                // int spriteIndex = Mathf.FloorToInt(healthPercentage * towerSprites.Length);
              ;

            //Destroy(slider.gameObject);
            //Destroy(gameObject);
        }
        else
        {
            float healthPercentage = (float)health / maxHealth; //convert health to a value between 0 and 1
            //int spriteIndex = Mathf.Clamp(Mathf.FloorToInt(healthPercentage * towerSprites.Length -1),0, towerSprites.Length -1);
            //towerSr.sprite = towerSprites[spriteIndex];
        }
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("ishit");
        animator.SetBool("ishit",false);
        if (currentSheep <= sheeps.Length - 1)
            { 
            damageSheep();
            return;
            }


        health -= damage;

        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
 


    }
}
