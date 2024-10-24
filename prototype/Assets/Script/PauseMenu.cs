using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
        public void Resume()
        {  
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;        
        }

        public void Pause()
        {
            
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            
        }

        public void LoadMainMenu(string SceneName)
        {

        SceneManager.LoadScene(SceneName);
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        }

        public void ExitinAku()
        {

        Application.Quit();
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);

        }
    
}
