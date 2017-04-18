using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class time : MonoBehaviour
{

    #region PUBLIC

    [HideInInspector]
    public static float timer = 60;

    #endregion

    #region PRIVATE

    private Text timerLabel;

    #endregion

    void Start()
    {
        timerLabel = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerLabel.text = " " + Mathf.Round(timer);
    }

    IEnumerator StartCountdown()
    {
        while (timer > 0)
        {
            Debug.Log("Countdown: " + timer);
            timer--;
            yield return new WaitForSeconds(1.0f);
            //update the label value
            timerLabel.text = string.Format("{0}", timer);
        }
    }
}
