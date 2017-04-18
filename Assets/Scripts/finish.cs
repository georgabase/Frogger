using UnityEngine;

public class finish : MonoBehaviour
{

    #region PUBLIC

    public GameObject prefab;
    public GameObject frog;

    #endregion

    #region PRIVATE



    #endregion


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("frog"))
        {
            Instantiate(frog, new Vector2(0, -7), Quaternion.identity);
            Destroy(col.gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            gameMaster.lives--;
            gameMaster.score += 50;
            gameMaster.homes++;
            gameMaster.score += 10 * (int)time.timer;
            time.timer = 60;
        }
    }

    void Start()
    {
		
    }

    void Update()
    {
		
    }
}
