using UnityEngine;
using System.Collections;

public class TilesPool : MonoBehaviour 
{
    public GameObject tilePrefab;                                    
    public int tilePoolSize = 5;                                   
    public float spawnRate = 3f;                                   
    public float tileMin = 0f;                                    
    public float tileMax = 5f;                                   
    private GameObject[] tiles;                                   
    private int currentTile = 0;                                   
    private Vector2 objectPoolPosition = new Vector2 (-15,-25);        
    private float spawnXPosition = 10f;
    private float timeSinceLastSpawned;

    void Start()
    {
        timeSinceLastSpawned = 0f;
        tiles = new GameObject[tilePoolSize];
        for(int i = 0; i < tilePoolSize; i++)
        {
            tiles[i] = (GameObject)Instantiate(tilePrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (timeSinceLastSpawned >= spawnRate) 
        {    
            timeSinceLastSpawned = 0f;

            float spawnYPosition = Random.Range(tileMin, tileMax);
            tiles[currentTile].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            spawnXPosition += 5f;
            currentTile ++;
            
            if (currentTile >= tilePoolSize) 
            {
                currentTile = 0;
            }
        }
    }
}