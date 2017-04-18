using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    #region PUBLIC

	

    #endregion

    #region PRIVATE

    private Text text;


    #endregion

    void Start()
    {
        text = GetComponent<Text>();
        text.text = gameMaster.score.ToString();
    }

    void Update()
    {
        text.text = gameMaster.score.ToString();
    }
}
