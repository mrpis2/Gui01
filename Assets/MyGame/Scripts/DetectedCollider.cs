using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bat dau va cham");
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Debug.Log("Va cham va giu yen vi tri");
        }
           
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Sau khi va cham va ket thuc va cham");
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bat dau va cham");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Va cham va giu yen vi tri");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sau khi va cham va ket thuc va cham");
    } 
    */
}
