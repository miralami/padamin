using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public int health = 100;
    public GameObject hitbox;
    public int enemyCount = 3;
    public SinkBasah sink;

    public void firingHitbox()
    {
        hitbox.SetActive(true);

    }

    public void isnotfiringHitbox()
    {
        hitbox.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage();
            if (health <= 0)
            {
                enemyCount--;
                Destroy(other.gameObject);
                health = 100;
            }
        }
    }

    public void TakeDamage()
    {
        if(sink.alreadySink)
        health--;
    }
}