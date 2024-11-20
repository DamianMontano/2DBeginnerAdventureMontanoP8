using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckoController : MonoBehaviour
{
    public int maxHealth = 5;
    int currentHealth;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("vertical");
       
        

        Vector2 position = transform.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;
        transform.position = position;

    }
}
