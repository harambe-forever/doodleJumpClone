using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{

    public GameObject platform;
    public Transform player;
    Vector2 screenB;

    void Start()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Spawn();
    }

    void Update()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Spawn()
    {
        GameObject platform2 = Instantiate(platform) as GameObject;
        platform2.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), player.position.y + 1, 0);
        
        GameObject platform3 = Instantiate(platform) as GameObject;
        platform3.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), player.position.y + 4, 0);
        
        GameObject platform4 = Instantiate(platform) as GameObject;
        platform4.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), player.position.y + 7, 0);
        
        GameObject platform5 = Instantiate(platform) as GameObject;
        platform5.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), player.position.y + 10, 0);
        
        GameObject platform6 = Instantiate(platform) as GameObject;
        platform6.transform.position = new Vector3(Random.Range(-screenB.x, screenB.x), player.position.y + 13, 0);

    }

    
}
