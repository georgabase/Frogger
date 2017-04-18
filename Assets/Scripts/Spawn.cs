using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    //  public GameObject prefab;
    public float interval = 1;
    public Vector2 velocity = Vector2.right;
    public GameObject[] prefab;

    private int prefabNum;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNext", 0, interval);
    }

    void SpawnNext()
    {
        // Instantiate
        prefabNum = Random.Range(0, prefab.Length);


        GameObject g = (GameObject)Instantiate(prefab[prefabNum],
                           transform.position,
                           Quaternion.identity);
        // Set Velocity
        g.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}