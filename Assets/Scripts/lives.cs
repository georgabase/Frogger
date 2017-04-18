using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{

    #region PUBLIC

	

    #endregion

    #region PRIVATE

    private Text text;


    #endregion

    void Start()
    {
        text = GetComponent<Text>();
        text.text = gameMaster.lives.ToString();
    }

    void Update()
    {
        text.text = gameMaster.lives.ToString();
    }
}
