using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour
{

    public GameObject prefab;

    void OnTriggerStay2D(Collider2D coll)
    {
        // Frog?
        if (coll.CompareTag("frog"))
            // Not Jumping?
            if (!coll.GetComponent<Frog>().isJumping())
                // Not on a platform?
        if (coll.transform.parent == null)
        {
            // Game Over
            Instantiate(prefab, new Vector2(0, -7), Quaternion.identity);
            Destroy(coll.gameObject);
            gameMaster.lives--;
            time.timer = 60;

        }
    }
}
