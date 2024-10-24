using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("Bro");
    }
    // Start is called before the first frame update
    IEnumerator Bro()
    {
        yield return new WaitForSeconds(9);
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }
}
