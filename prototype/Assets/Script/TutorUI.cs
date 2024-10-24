using UnityEngine;

public class TutorUI : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 0f;
    }

    public GameObject tutor;
    // Update is called once per frame
    public void CONTINUE()
    {
        tutor.SetActive(false);
        Time.timeScale = 1f;

    }
}
