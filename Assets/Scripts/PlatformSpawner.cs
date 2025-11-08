using Unity.VisualScripting;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject diamond;
    Vector3 lastPos;
    float size;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        SpawnPlatforms();
        // SpawnPlatforms();
    }

    public void StartSpawningPlatforms()
    {
        InvokeRepeating("SpawnPlatform", 0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver)
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
        for (int i = 0; i < 20; i++)
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

        SpawnDiamond(pos);
    }

    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        GameObject p = Instantiate(platform, pos, Quaternion.identity);
        p.transform.parent = transform;
        SpawnDiamond(pos);
    }

    void SpawnDiamond(Vector3 pos)
    {
        pos.y += 1;
        float randVal = Random.value;

        if (randVal < 0.25f)
        {
            Instantiate(diamond, pos, diamond.transform.rotation);
        }
    }
}
