using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    bool started = false;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
  {
        started = false;
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
            if (Input.GetMouseButtonDown(0))
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
