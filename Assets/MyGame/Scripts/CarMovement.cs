using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points;
    private int currentPoint;

    // Start is called before the first frame update
    public enum Mode
    {
        Automatic,
        Manual
    };

    public Mode mod;
    private float speedVertical =10;
    private float speedHorizontal=100;

    // Update is called once per frame
    void Update()
    {
        if (mod ==Mode.Automatic)
        {
            if (Vector3.Distance(transform.position, points[currentPoint].position) < 0.3f)
            {
                currentPoint++;
            }
            if (currentPoint >= points.Length)
            {
                currentPoint = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, Time.deltaTime * speed);
            transform.LookAt(points[currentPoint].position);
        }
        else if (mod ==Mode.Manual)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            transform.Translate(0, 0, v * speedVertical * Time.deltaTime);
            transform.Rotate(0, h * speedHorizontal * Time.deltaTime, 0);
        }


       
    }
}
