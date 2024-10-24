using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;
    public GameObject hitboxfinish;
    public GameObject afterfire;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.speed = 0f;
        hitboxfinish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "fixfireman")
        {
            AFTER();
        }

        else if (other.gameObject.name == "alatpemadam")
        {
            AFTER();
        }
    }

    void AFTER()
    {
        nav.speed = 2f;
        hitboxfinish.SetActive(true);
        afterfire.SetActive(true);
    }
}
