using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public float timeRemaining = 2;
    public Material[] material;
    public Renderer rend;
    public SinkBasah sink;

    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    public void Update()
    {
        if (sink.onSink)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            else
            {
                rend.sharedMaterial = material[1];
                sink.alreadySink = true;
            }
        }
    }
}
