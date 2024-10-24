using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScriptLVL2 : MonoBehaviour
{

    public static bool GameIsFinished = false;
    public TriggerScriptLVL2 trigger;
    public GameObject finishMenuUI;



    // Update is called once per frame
    void Update()
    {
        if (trigger.enemyCount == 0)
        {
            GameIsFinished = true;
            if (GameIsFinished)
            {
                ShowMenu();
                Time.timeScale = 0f;
            }
        }
    }

    void ShowMenu()
    {

        finishMenuUI.SetActive(true);
    }

    public void LoadScene(string SceneName)
    {

        SceneManager.LoadScene(SceneName);
        GameIsFinished = false;
    }

    public void ExitinAku()
    {

        Application.Quit();

    }

}
