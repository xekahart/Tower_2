using UnityEngine;

public class MareAttack : MonoBehaviour
{
    public int damage = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<TowerHealth>())
        {
            collision.gameObject.GetComponent<TowerHealth>().health -= damage;
            Destroy(gameObject);
        };
        if (collision.gameObject.GetComponent<DefenderHealth>())
        {
            collision.gameObject.GetComponent<DefenderHealth>().health -= damage;
            Destroy(gameObject);
        }

    }
}
