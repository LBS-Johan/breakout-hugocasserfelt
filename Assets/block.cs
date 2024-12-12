using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    static int blocksAlive = 0;
    static int level = 0;
    void Start()
    {
        if (level != SceneManager.GetActiveScene().buildIndex)
        {
            blocksAlive = 0;
            level = SceneManager.GetActiveScene().buildIndex;
        }
        blocksAlive += 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        blocksAlive -= 1;
        if (blocksAlive == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Destroy(gameObject);
    }
}
