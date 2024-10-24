using UnityEngine;

public class SinkControl : MonoBehaviour
{
    public ParticleSystem particles;
    public SinkBasah pablo;

    public void Update()
    {
        if (pablo.onSink == true)
        {
            particles.Play();
            ParticleSystem.EmissionModule em = particles.emission;
            em.enabled = true;
        }
        else
        {
            ParticleSystem.EmissionModule em = particles.emission;
            em.enabled = false;
        }
    }
}
