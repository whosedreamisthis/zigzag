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
        GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(transform.parent.gameObject, 2f);
  }
}
