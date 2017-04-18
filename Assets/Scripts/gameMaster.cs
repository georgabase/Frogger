using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{

    #region PUBLIC

    [HideInInspector]
    public static int score;
    [HideInInspector]
    public static int lives = 7;
    [HideInInspector]
    public static int homes = 0;

    #endregion

    #region PRIVATE


    #endregion

   

    void Update()
    {
       

        if (homes == 5)
        {
            score += 1000;
            SceneManager.LoadScene("scene");
        }

        if (lives == 0 || time.timer < 0)
        {
            SceneManager.LoadScene("scene");
        }


    }

}
