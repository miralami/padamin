using UnityEngine;

public class TriggerScriptLVL2 : MonoBehaviour
{
    public int health = 100;
    public GameObject hitbox;
    public int enemyCount = 3;

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
            health--;
    }
}