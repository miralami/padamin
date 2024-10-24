using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLVL3 : MonoBehaviour
{
    public TriggerScriptLVL2 trigger;
    public GameObject finishMenuUI;
    public GameObject UI;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "fixfireman")
        {
        finishMenuUI.SetActive(true);
        Time.timeScale = 0f;
        UI.SetActive(false);
        }
    }

    public void LoadScene(string SceneName)
    {

        SceneManager.LoadScene(SceneName);
    }

    public void ExitinAku()
    {
        Application.Quit();
    }

}
