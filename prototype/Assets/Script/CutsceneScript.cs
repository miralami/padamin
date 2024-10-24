using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneScript : MonoBehaviour
{
    public float cutsceneTime = 15f;
    public string SceneName;
    // Update is called once per frame
    public void Update()
    {
        if (cutsceneTime > 0)
        {
            cutsceneTime -= Time.deltaTime;
        }

        else
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
