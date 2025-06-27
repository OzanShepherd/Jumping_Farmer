using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 obsLoc = new Vector3(35, 0, 0);
    private float startDelay = 2;
    private float spawnInterval = 2;
    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("Spawner", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(prefab, obsLoc, prefab.transform.rotation);
        }
    }
}
