using UnityEngine;

public class SheepLife : MonoBehaviour
{
    public TowerHealth towerHealth;
    public int towerHp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (towerHealth.health == towerHp)
        //{ 
        //    Destroy(gameObject);
        //}
        

    }
    public void takeDamage()
    {
        gameObject.SetActive(false);
    }
}
