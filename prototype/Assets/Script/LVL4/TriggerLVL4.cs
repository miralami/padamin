using UnityEngine;

public class TriggerLVL4 : MonoBehaviour
{
    public int health = 100;
    public GameObject hitbox;
    public int enemyCount = 4;

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
        health--;
    }
}