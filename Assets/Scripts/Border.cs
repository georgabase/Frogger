using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }

    void OnColliderEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("car"))
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }

}