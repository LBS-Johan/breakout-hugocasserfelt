using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boll2 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRigidbody;
    public GameObject ball;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (transform.position.x > 0)
            {
                myRigidbody.velocity = new Vector2(-4, 0);
            }
            else
            {
                myRigidbody.velocity = new Vector2(4, 0);
            }
        }
        else
        {
            myRigidbody.velocity = new Vector2(0, 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(ball, transform.position, quaternion.identity);
        Destroy(gameObject);
    }
}
