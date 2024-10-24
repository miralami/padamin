using UnityEngine;

public class RotationFollow : MonoBehaviour
{
    public Transform target;
    public float offset = 120f;
    // Start is called before the first frame update
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        dir.y = 0;//This allows the object to only rotate on its y axis
        Quaternion rot = Quaternion.LookRotation(dir) * (Quaternion.AngleAxis(offset, Vector3.up));
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, 10 * Time.deltaTime);
    }
}
