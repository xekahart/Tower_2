using UnityEngine;

public class MareMovement : MonoBehaviour
{
    public Rigidbody2D robotRb;
    public float speed;
    
    void FixedUpdate()
    {
        robotRb.linearVelocity = Vector2.left * speed ;    
    }
}
