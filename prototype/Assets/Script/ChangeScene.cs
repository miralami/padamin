
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject credits;
    public GameObject blackz;
    public GameObject mainmenu;
    public void Start()
    {
        PlayerPrefs.GetInt("SceneName");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame()
    {
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeTime()
    {
        Time.timeScale = 1f;
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }

    public void EXIT()
    {
        Application.Quit();
    }

    public void CREDITS()
    {
        credits.SetActive(true);
        blackz.SetActive(true);
        mainmenu.SetActive(true);
    }

    public void NORMAL()
    {
        credits.SetActive(false);
        blackz.SetActive(false);
        mainmenu.SetActive(false);
    }  
}