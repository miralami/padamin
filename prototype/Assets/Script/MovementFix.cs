using UnityEngine;

public class MovementFix : MonoBehaviour
{
    public float speed = 8.0f;
    public Joystick joystick;
    public Collider alat;

    private Rigidbody m_Rb;
    private float offset = 90f;

    // Start is called before the first frame update
    void Awake()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = joystick.Vertical;
        float verticalInput = joystick.Horizontal;

        Vector3 movement = new Vector3(horizontalInput, 0, -verticalInput).normalized;

        if (movement == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(movement) * (Quaternion.AngleAxis(offset, Vector3.up));

        Debug.Log(targetRotation.eulerAngles);

        targetRotation = Quaternion.RotateTowards(
        transform.rotation, targetRotation, 360 * Time.fixedDeltaTime);

        m_Rb.MovePosition(m_Rb.position + movement * speed * Time.fixedDeltaTime);
        m_Rb.MoveRotation(targetRotation);
    }
    void OnCollisionEnter()
    {
        Physics.IgnoreCollision(alat.GetComponent<Collider>(), GetComponent<Collider>());
    }
}