using UnityEngine;

public class TriggerSFX1 : MonoBehaviour
{
    public AudioSource sfx1;

    void OnTriggerEnter(Collider other)
    {
        sfx1.Play();
    }

    void OnTriggerExit(Collider other)
    {
        sfx1.Stop();
    }
}
