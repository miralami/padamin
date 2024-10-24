using UnityEngine;

public class MovementLVL3 : MonoBehaviour
{
    public float speed = 8.0f;
    public Camera followCamera;
    public Joystick joystick;

    private Rigidbody m_Rb;
    private Vector3 m_CameraPos;
    private float offset = 90f;

    // Start is called before the first frame update
    void Awake()
    {
        m_Rb = GetComponent<Rigidbody>();
        m_CameraPos = followCamera.transform.position - transform.position;
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

            targetRotation = Quaternion.RotateTowards(
            transform.rotation, targetRotation, 360 * Time.fixedDeltaTime);

        m_Rb.MovePosition(m_Rb.position + movement * speed * Time.fixedDeltaTime);
        m_Rb.MoveRotation(targetRotation);
    }

    private void LateUpdate()
    {
        followCamera.transform.position = m_Rb.position + m_CameraPos;
    }
}