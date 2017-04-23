using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    bool isDying = false;

    public MeshRenderer[] renderers;
    public ParticleSystem[] particles;

    public void StartDeath()
    {
        isDying = true;

        foreach (MeshRenderer r in renderers)
        {
            r.enabled = false;
        }

        foreach (ParticleSystem p in particles)
        {
            p.Play();
        }
    }

    private void Update()
    {
        if (!isDying) return;

        foreach (ParticleSystem p in particles)
        {
            if (p.isPlaying)
                return;
        }

        Destroy(gameObject);
    }
}
