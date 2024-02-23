using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float health;
    [SerializeField]
    private float fuel;
    private float capacity = 100;
    [SerializeField]
    private int laps = 0;
    private float maxHealth = 100;
    // Start is called before the first frame update

    private void Start()
    {
        fuel = capacity;
        health = maxHealth;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Damage")
        {
            health -= 5;
            Debug.Log("damaged");
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "BarrelRed")
        {
            fuel += 25;
            if (fuel > capacity) fuel = capacity;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BarrelBlue")
        {
            fuel += 10;
            if (fuel > capacity) fuel = capacity;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BoxGift")
        {
            health += 30;
            if (health > maxHealth) health = maxHealth;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BoxFull")
        {
            health = maxHealth;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Finish")
        {
            laps += 1;
        }
        if (health <= 0)
        {
            //SceneManager.LoadScene("Lesson6");
            SceneManager.LoadScene(0);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    

}
