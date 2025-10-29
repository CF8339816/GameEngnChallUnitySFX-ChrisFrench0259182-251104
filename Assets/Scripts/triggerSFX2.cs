
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSFX2 : MonoBehaviour
{
    public AudioSource sfx2;

    void OnTriggerEnter(Collider other)
    {
        sfx2.Play();
    }

    void OnTriggerExit(Collider other)
    {
        sfx2.Stop();
    }

}