using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour
{

    private Vector2 old;

    void OnTriggerEnter2D(Collider2D col)
    {
        // Frog? Then make it a Child
        if (col.CompareTag("frog"))
        {
            col.transform.parent = transform;
            print("frog");

            col.GetComponent<Rigidbody2D>().velocity += this.GetComponent<Rigidbody2D>().velocity;

            //  this.rigidbody2D.velocity += activePlatform.rigidbody2D.velocity;

        }

        if (col.CompareTag("frog"))
        {
            if (this.CompareTag("platform"))
            {
                print("log");
            }
        }
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("frog"))
        {
            col.transform.parent = transform;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("frog"))
        {
            col.transform.parent = null;  
            col.GetComponent<Rigidbody2D>().velocity -= this.GetComponent<Rigidbody2D>().velocity;
        }
    }
}
