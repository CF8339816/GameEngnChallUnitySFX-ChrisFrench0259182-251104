using UnityEngine;

public class audioCtrl : MonoBehaviour
{
    public AudioSource musicThreeD;

    void OnTriggerEnter(Collider other)
    {
        musicThreeD.Pause();
    }

    void OnTriggerExit(Collider other)
    {
        musicThreeD.UnPause();
    }
}
