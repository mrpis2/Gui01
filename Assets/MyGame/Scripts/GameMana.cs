using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMana : MonoBehaviour
{
    [SerializeField]
    private int b = 6;
    [SerializeField]
    private int C = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(b * Time.deltaTime);
        
    }
}
