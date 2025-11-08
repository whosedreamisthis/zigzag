using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;

    Vector3 offset;
    
    [SerializeField]
    float lerpRate;

    public bool gameOver = false;

    void Start()
    {
        gameOver = false;
        offset = ball.transform.position - transform.position;
    }

    void Update()
    {
        if (!gameOver)
    {
            Follow();
    }

    }
    
    void Follow ()
  {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        transform.position = Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);
        
  }
}
