using UnityEngine;

public class Freeze : MonoBehaviour
{
    public Rigidbody rb;
    public TriggerAlat juan;

    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    private void Update()
    {
        if (juan.isGrabbing == true)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }

}
