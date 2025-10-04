using System.Collections;
using TMPro;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime = .15f;
    public MareMovement mareMovement;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth; 
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
        StartCoroutine(KnockbackDelay());
    }

    IEnumerator KnockbackDelay()
    {
        mareMovement.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            mareMovement.enabled=true;
        }
    }

}
