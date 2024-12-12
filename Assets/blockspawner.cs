using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blockpurple;
    public GameObject blockblue;
    public GameObject blockgreen;
    public GameObject blockyellow;
    public GameObject blockorange;
    public GameObject blockred;
    public GameObject blockpink;
    public int level;
    void Start()
    {
        if (level == 1)
        {
            int i = 0;
            while (i < 23)
            {
                Instantiate(blockpurple, new Vector2(-9.9f + 0.9f * i, 1.9f), Quaternion.identity);
                i += 1;
            }
            i = 0;
            while (i < 23)
            {
                Instantiate(blockblue, new Vector2(-9.9f + 0.9f * i, 2.3f), Quaternion.identity);
                i += 1;
            }
            i = 0;
            while (i < 23)
            {
                Instantiate(blockgreen, new Vector2(-9.9f + 0.9f * i, 2.7f), Quaternion.identity);
                i += 1;
            }
            i = 0;
            while (i < 23)
            {
                Instantiate(blockyellow, new Vector2(-9.9f + 0.9f * i, 3.1f), Quaternion.identity);
                i += 1;
            }
            i = 0;
            while (i < 23)
            {
                Instantiate(blockorange, new Vector2(-9.9f + 0.9f * i, 3.5f), Quaternion.identity);
                i += 1;
            }
            i = 0;
            while (i < 23)
            {
                Instantiate(blockred, new Vector2(-9.9f + 0.9f * i, 3.9f), Quaternion.identity);
                i += 1;
            }
        }
        if (level == 2)
        {
            
            int i = 0;
            int spawnheight = 0;
            while (spawnheight < 20)
            {
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockpurple, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                spawnheight += 1;
                i = 0;
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockblue, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                spawnheight += 1;
                i = 0;
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockgreen, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                i = 0;
                spawnheight += 1;
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockyellow, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                spawnheight += 1;
                i = 0;
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockorange, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                spawnheight += 1;
                i = 0;
                while (i < 3 && spawnheight < 20)
                {
                    Instantiate(blockred, new Vector2(-1f + 1f * i, -4.7f + spawnheight * 0.5f), Quaternion.identity);
                    i += 1;
                }
                spawnheight += 1;
                i = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
