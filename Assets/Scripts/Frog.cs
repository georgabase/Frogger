using UnityEngine;
using System.Collections;
using System;

public class Frog : MonoBehaviour
{
    
    // Jump Speed
    public float speed = 0.1f;
    public GameObject prefab;

    // Current jump
    Vector2 jump = Vector2.zero;

    // Is the Frog currently jumping?
    public bool isJumping()
    {
        return jump != Vector2.zero;
    }
    
    // FixedUpdate for Physics Stuff
    void FixedUpdate()
    {
        // Currently jumping?
        if (isJumping())
        {
            // Remember current position
            Vector2 pos = transform.position;
            
            // Jump a bit further
            transform.position = Vector2.MoveTowards(pos, pos + jump, speed);
            
            // Subtract stepsize from jumpvector
            jump -= (Vector2)transform.position - pos;
        }
        // Otherwise allow for next jump
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                jump = Vector2.up;
                gameMaster.score += 10;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                jump = Vector2.right;
                gameMaster.score += 10;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                jump = -Vector2.up; // -up means down
                gameMaster.score += 10;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                jump = -Vector2.right; // -right means left
                gameMaster.score += 10;
            }
        }
        
        // Animation Parameters
        GetComponent<Animator>().SetFloat("X", jump.x);
        GetComponent<Animator>().SetFloat("Y", jump.y);
        GetComponent<Animator>().speed = Convert.ToSingle(isJumping());
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("car"))
        {
            gameMaster.lives--;
            time.timer = 60;
            Instantiate(prefab, new Vector2(0, -7), Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
