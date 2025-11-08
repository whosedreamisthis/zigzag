using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    bool started = false;
    bool gameOver;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
  {
        started = false;
        gameOver = false;
  }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.linearVelocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }
        else {
            // Debug.DrawRay(transform.position, Vector3.down, Color.red);
            bool collided = Physics.Raycast(transform.position, Vector3.down, 1f);
            if (!collided)
      {
                gameOver = true;
                //rb.useGravity = true;
                rb.linearVelocity = new Vector3(0, -25f, 0);
      }
            if (Input.GetMouseButtonDown(0) && !gameOver)
            {
                SwitchDirection();
            }
        }
    }
    
    void SwitchDirection ()
  {
        if (rb.linearVelocity.z > 0)
        {
            rb.linearVelocity = new Vector3(speed, 0, 0);
        }
    else if (rb.linearVelocity.x > 0)
    {
            rb.linearVelocity = new Vector3(0, 0, speed);
    }
  }
}
