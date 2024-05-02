using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    Vector2 enemypos;
    public GameObject playerM;
    bool perseguirP;
    public int speed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (perseguirP)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemypos, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, enemypos) > 12f)
        {
            perseguirP = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            enemypos = playerM.transform.position;
            perseguirP = true;
        }
    }
    
}
