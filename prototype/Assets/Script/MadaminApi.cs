using UnityEngine;

public class MadaminApi : MonoBehaviour
{
    public ParticleSystem cipratanAir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        } 
    }
    public void Shoot()
    {
        cipratanAir.Play();
    }

}
