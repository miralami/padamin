using UnityEngine;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour
{
    private float timeRemaining = 120f;
    public Text timeText;
    public bool GameIsFailed;
    public GameObject failed;
    public void Update()
    {
        timeText.text = "Time left: " + Mathf.RoundToInt(timeRemaining);
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            FAILED();
        }
    }

    void FAILED()
    {
        failed.SetActive(true);
        Time.timeScale = 0f;
    }
}
