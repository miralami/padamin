using UnityEngine;

public class SinkBasah : MonoBehaviour
{

    public Transform sinkpos;
    public GameObject goni;
    public TriggerAlat trgalt;
    public Transform equippos;
    public bool isTouchingSink;
    public bool onSink;
    public bool alreadySink;
    public GameObject sinkhitbox;

    public void Start()
    {
        onSink = false;
        alreadySink = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("CanGrab"))
        {
            trgalt.canGrab = true;
        }

        else if (other.gameObject.name == "Area Ngambil")
        {
            isTouchingSink = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTouchingSink = false;
    }

    public void Update()
    {
        if(alreadySink == true && onSink == false)
        {
            sinkhitbox.SetActive(false);
        }

        if (alreadySink == true)
        {
            isTouchingSink = false;
        }
    }

    

    // Update is called once per frame
    public void PutGoni()
    {
        if(trgalt.isGrabbing == true && isTouchingSink == true)
        {
            goni.transform.parent = null;
            goni.transform.position = sinkpos.position;
            goni.transform.parent = sinkpos;
            goni.transform.localEulerAngles = new Vector3(90f, 0f, -90f);
            trgalt.isGrabbing = false;
            onSink = true;
        }
        else if(trgalt.isGrabbing == true)
        {
            goni.transform.parent = null;
            goni.GetComponent<Rigidbody>().isKinematic = true;
            trgalt.isGrabbing = false;
        }
    }

    public void GrabGoni()
    {
        if (trgalt.canGrab == true)
        {
            goni.transform.position = equippos.position;
            goni.transform.parent = equippos;
            goni.GetComponent<Rigidbody>().isKinematic = true;
            trgalt.isGrabbing = true;
            onSink = false;
        }
    }
}
