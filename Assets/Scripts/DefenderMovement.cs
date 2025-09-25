using UnityEngine;

public class DefenderMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    public Rigidbody2D defenderRb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        defenderRb.linearVelocity = Vector2.right * speed;
    }
}
