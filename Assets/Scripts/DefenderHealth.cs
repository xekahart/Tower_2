using System.Collections;
using TMPro;
using UnityEngine;

public class DefenderHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime = .15f;
    public Bow bow;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
        popUpText.text = damage.ToString();

        //      StartCoroutine(KnockbackDelay());
    }

    //IEnumerator KnockbackDelay()
    //{
    //    bow.enabled = false;
    //    yield return new WaitForSeconds(delayTime);
    //    if (health <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        bow.enabled = true;
    //    }
    //}
}
