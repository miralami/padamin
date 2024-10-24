using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{

    private static MusicPlayerScript instance = null;
    public static MusicPlayerScript Instance
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