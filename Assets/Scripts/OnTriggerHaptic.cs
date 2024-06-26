using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class OnTriggerHaptic : GrabbableEvents
{
    public Collider LeftHandTrigger;
    public Grabber LeftHand;
    public Collider RightHandTrigger;
    public Grabber RightHand;

    public float VibrateFrequency = 0.3f;
    public float VibrateAmplitude = 0.1f;
    public float VibrateDuration = 0.1f;
    private void OnTriggerEnter(Collider other)
    {
        if(other == LeftHandTrigger)
        {
            if (input)
            {
                input.VibrateController(VibrateFrequency, VibrateAmplitude, VibrateDuration, LeftHand.HandSide);
            }
        }

        if (other == RightHandTrigger)
        {
            if (input)
            {
                input.VibrateController(VibrateFrequency, VibrateAmplitude, VibrateDuration, RightHand.HandSide);
            }
        }
    }
}
