using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public GameObject archer;
    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnArcher()
    {
        Instantiate(archer, spawnPoint.position, Quaternion.identity);
    }
    public void SpawnPig()
    {

    }
    public void SpawnTurtle()
    {

    }
}
