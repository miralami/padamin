using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform fireParent;
    public GameObject fire;
    public int fireCount;
    public TriggerLVL4 script;

    private void Update()
    {
        if(script.health == 0)
        {
            fireCount--;
        }
      while (fireCount < 6)
         {
            Vector3 spawnLocation = fireParent.GetChild(Random.Range(0, fireParent.childCount)).position;
            Instantiate(fire, spawnLocation, Quaternion.identity);
            fireCount++;
         }

      if (fireCount == 0)
        {
            Vector3 spawnLocation = fireParent.GetChild(Random.Range(0, fireParent.childCount)).position;
            Instantiate(fire, spawnLocation, Quaternion.identity);
            fireCount++;
        }
        Debug.Log(fireCount);
    }
}
