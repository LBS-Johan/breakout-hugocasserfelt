using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float movementspeedx;
    public float movementspeedy;
    public GameObject ball;
    float spawnballtimer = 0;
    // Start is called before the first frame update
    Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnballtimer += Time.deltaTime;
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(movementspeedx, 0);
        }
        else if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-movementspeedx, 0);
        }else if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.velocity = new Vector2(0, movementspeedy);
        }
        else if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody.velocity = new Vector2(0, -movementspeedy);
        }
        else
        {
            myRigidbody.velocity = new Vector2(0, 0);
        }
        if (spawnballtimer > 9)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                if (transform.position.x > 0)
                {
                    Instantiate(ball, new Vector2(transform.position.x - 1, transform.position.y), Quaternion.identity);
                }
                else
                {
                    Instantiate(ball, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
                }
            }
            else
            {
                Instantiate(ball, new Vector2(transform.position.x, transform.position.y + 1), Quaternion.identity);
            }
            spawnballtimer = 0;
        }
    }
}
