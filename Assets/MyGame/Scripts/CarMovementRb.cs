using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarMovementRb : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speedPosition = 20;
    public float speedRotation = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        rb.MovePosition(transform.position + new Vector3(0, 0, v * Time.deltaTime * speedPosition));
        rb.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0, h * Time.deltaTime * speedRotation, 0)));
        
    }
}
