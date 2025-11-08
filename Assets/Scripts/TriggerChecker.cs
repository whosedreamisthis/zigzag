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
            Invoke("FallDown",0.5f);
        }
    }
  
  void FallDown()
    {
        Rigidbody rb = GetComponentInParent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
        // Destroy(transform.parent.gameObject, 2f);
        Destroy(transform.parent.gameObject);
  }
}
