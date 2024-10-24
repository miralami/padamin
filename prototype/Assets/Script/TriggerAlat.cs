using UnityEngine;

public class TriggerAlat : MonoBehaviour
{
    public GameObject currentWeapon;
    public Transform equipPosition;
    public bool canGrab = false;
    public bool isGrabbing = false;
    public GameObject dropButton;
    public GameObject pickupButton;
    public GameObject fireButton;
    public GameObject hands;

    private void Update()
    {
        if (isGrabbing == true)
        {
            fireButton.SetActive(true);
            dropButton.SetActive(true);
            pickupButton.SetActive(false);
            hands.SetActive(true);
            canGrab = false;
        }
        else
        {
            pickupButton.SetActive(true);
            dropButton.SetActive(false);
            fireButton.SetActive(false);
            hands.SetActive(false);
        }
}

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("CanGrab"))
        {
            canGrab = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        canGrab = false;
    }

    public void PickUp()
    {
        if(canGrab == true)
        {
            currentWeapon.transform.position = equipPosition.position;
            currentWeapon.transform.parent = equipPosition;
            currentWeapon.transform.localEulerAngles = new Vector3(90f, 0f, -90f);
            currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
            isGrabbing = true;
        }
        
    }

    public void Drop()
    {
        if(isGrabbing == true)
        {
            isGrabbing = false;
            currentWeapon.transform.parent = null;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        }
       
    }

}
