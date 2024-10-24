using UnityEngine;

public class DragMove : MonoBehaviour
{

    private Vector3 touchpos;
    private Rigidbody2D rb;
    private Vector3 arah;
    private float speed = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchpos = Camera.main.ScreenToWorldPoint(touchpos);
            touchpos.z = 0;
            arah = (touchpos - transform.position);
            rb.velocity = new Vector2(arah.x, arah.y) * speed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
    }
}