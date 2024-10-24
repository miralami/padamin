using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Joystick joystick;
    public Collider alat;
    [SerializeField] private float speed = 10f;

    void FixedUpdate()
    {
        float xMovement = joystick.Horizontal;
        float zMovement = joystick.Vertical;

        transform.position += new Vector3(zMovement, 0f, -xMovement) * speed * Time.deltaTime;
    }

    void OnCollisionEnter()
    {
        Physics.IgnoreCollision(alat.GetComponent<Collider>(), GetComponent<Collider>());
    }

}