using UnityEngine;

public class DragHold : MonoBehaviour
{
    private Touch touch;
    public Vector2 turn;
    public float sensitivity = .5f;
    public float speed = 1;
    float rotSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                turn.x += -(touch.deltaPosition.y) * sensitivity;
                turn.y += touch.deltaPosition.x * sensitivity;
                transform.localRotation = Quaternion.Euler(turn.x, turn.y, 90);
            }
        }
    }
    void OnMouseDrag()
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.RotateAround(Vector3.up, -rotX);
            transform.RotateAround(Vector3.right, rotY);
        }
}
