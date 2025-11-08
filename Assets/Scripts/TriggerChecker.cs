using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Ball")
        {
            Invoke("FallDown",1f);
            // FallDown();
        }
    }
  
  void FallDown()
    {
        Rigidbody rb = GetComponentInParent<Rigidbody>();
        rb.useGravity = true;
        rb.linearVelocity = 5* Vector3.down;// new Vector3(rb.linearVelocity.x, -1f, rb.linearVelocity.z);
        Destroy(transform.parent.gameObject, 2f);
  }
}
