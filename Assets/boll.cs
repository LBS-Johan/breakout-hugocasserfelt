using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boll : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRigidbody;
    float timee = -1;
    public GameObject ball;
    static int ballsalvie = 0;
    static int level = 0;
    void Start()
    {
        if (level != SceneManager.GetActiveScene().buildIndex)
        {
            ballsalvie = 0;
            level = SceneManager.GetActiveScene().buildIndex;
        }
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(Random.Range(-3, 3), Random.Range(-2, 3));
        ballsalvie += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody.velocity.y < 0 && myRigidbody.velocity.y > -1.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -2);
        }
        else if (myRigidbody.velocity.y < 1.5f && myRigidbody.velocity.y > -0.1f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 2f);
        }

        if (myRigidbody.velocity.x < 0 && myRigidbody.velocity.x > -1.5f)
        {
            myRigidbody.velocity = new Vector2(-2, myRigidbody.velocity.y);
        }
        else if (myRigidbody.velocity.x < 1.5f && myRigidbody.velocity.x > -0.1f)
        {
            myRigidbody.velocity = new Vector2(2, myRigidbody.velocity.y);
        }

        if (transform.position.y < -6|| transform.position.y > 6|| transform.position.x > 12|| transform.position.x < -12)
        {
            ballsalvie -= 1;
            if (ballsalvie == 0)
            {
                SceneManager.LoadScene(4);
            }
            Destroy(gameObject);
        }
        timee += Time.deltaTime;
        float speed = 4 + (timee/ (3.5f + ballsalvie / 2));
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
    }
}
