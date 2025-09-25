using System.Collections;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime = .15f;
    public MareMovement mareMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void takeDamage(int damage)
    {
        health -= damage;
        StartCoroutine(knockbackDelay());
    }

    IEnumerator knockbackDelay()
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
