using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceLocationIndicator : MonoBehaviour
{
    public Renderer r;

    public Material red, transparent;

    AudioSource myAudioSource;

    public AudioClip soundFX;

    // Start is called before the first frame update
    void Start()
    {
        //r = GetComponent<Renderer>();
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        r.material = red;
        myAudioSource.Play();

        //create haptic clip and pass to right controller
        OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
        OVRHaptics.RightChannel.Preempt(ovrClip);
        OVRHaptics.LeftChannel.Preempt(ovrClip);
    }

    private void OnTriggerExit(Collider other)
    {
        //r.material.color = Color.grey;
        r.material = transparent;
    }
}
