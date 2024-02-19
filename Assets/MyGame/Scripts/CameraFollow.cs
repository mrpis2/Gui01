using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform target;
    //public float smoothSpeed = 0.5f;
    //public Vector3 offset;
    private Transform player;
    public float distance = 6;
    public float height = 5f;
    public float shouderOffset = 0;
    public bool switchSoulder = false;
    public float smoonthtime = 0.25f;
    private Vector3 lookTarget;
    private Vector3 lookTargetVelocity;
    private Vector3 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        /*
        Vector3 desirePosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothPosition;
        transform.LookAt(target.position);
        */
        Vector3 target = player.position + (-player.transform.forward * distance);
        Vector3 verticalPosition = Vector3.up * height;
        Vector3 shouderPosition = switchSoulder ? transform.right * -shouderOffset : transform.right * shouderOffset;
        transform.position = Vector3.SmoothDamp(transform.position, target + verticalPosition + shouderPosition, ref currentVelocity, smoonthtime);
        lookTarget = Vector3.SmoothDamp(lookTarget, player.position + verticalPosition + shouderPosition, ref lookTargetVelocity, smoonthtime);
        transform.LookAt(lookTarget);

    }
}
