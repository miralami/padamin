using UnityEngine;
using System.Collections;

public class VideoDont : MonoBehaviour
{

    private static VideoDont instance = null;
    public static VideoDont Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
// any other methods you need