using UnityEngine;

public class CipratControl : MonoBehaviour
{
    public ParticleSystem particles;
    public TriggerAlat pablo;

    public void Firing()
    {
        if (pablo.isGrabbing == true)
        particles.Play();
        ParticleSystem.EmissionModule em = particles.emission;
        em.enabled = true;
    }

    public void disableFiring()
    {
        ParticleSystem.EmissionModule em = particles.emission;
        em.enabled = false;
    }
}
