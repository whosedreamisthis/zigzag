using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;

    Vector3 offset;
    
    [SerializeField]
    float lerpRate;


    void Start()
    {
        offset = ball.transform.position - transform.position;
    }

    void Update()
    {
        if (!GameManager.instance.gameOver)
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
