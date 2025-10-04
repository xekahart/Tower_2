using UnityEngine;

public class DefenderMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    public Rigidbody2D defenderRb;
    public bool canMove= true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            defenderRb.linearVelocity = Vector2.right * speed;
        }
        else
        {
            defenderRb.linearVelocity = Vector2.zero;
        }

    }
}
