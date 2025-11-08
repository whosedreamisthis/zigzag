using Unity.VisualScripting;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    Vector3 lastPos;
    float size;
    public bool gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver = false;
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        SpawnPlatforms();   
        // SpawnPlatforms();
        InvokeRepeating("SpawnPlatform", 2f,0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) 
        {
            CancelInvoke("SpawnPlatform");
        }
    }

    void SpawnPlatform()
    {
      
     float randVal = Random.value;
            if (randVal > 0.5f)
            {
                SpawnX();
            }
            else
            {
                SpawnZ(); 
            }
  }

    void SpawnPlatforms()
  {
        for (int i = 0; i < 20; i++ )
        {
            SpawnPlatform();
        }
  }
    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        GameObject p = Instantiate(platform, pos, Quaternion.identity);
        p.transform.parent = transform;

    }
  
  void SpawnZ()
  {
     Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        GameObject p = Instantiate(platform, pos, Quaternion.identity);
        p.transform.parent = transform;
  }
}
