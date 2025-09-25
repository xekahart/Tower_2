using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public ArcherState archerState;
    public float detectionRange = 6;
    public LayerMask enemyLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        archerState = ArcherState.Walking;
    }

    // Update is called once per frame
    void Update()
    {
        if(archerState == ArcherState.Walking) 
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, detectionRange, enemyLayer);
            if(hit.collider != null) 
            {
                archerState = ArcherState.Shooting;
            }
        }
    }
    public enum ArcherState
{
    Idle,
    Walking,
    Shooting
}
}
