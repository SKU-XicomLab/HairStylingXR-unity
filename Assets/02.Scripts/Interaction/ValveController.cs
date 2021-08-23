using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ValveController : MonoBehaviour
{
    public SteamVR_Action_Vector2 ThumbstickAction = null;
    public SteamVR_Action_Vector2 TrackpadAction = null;
    public SteamVR_Action_Single SqueezeAction = null;
    public SteamVR_Action_Boolean GripAction = null;
    public SteamVR_Action_Boolean grabPinch = null;
    public SteamVR_Action_Skeleton SkeletonAction = null;

    public SteamVR_Input_Sources handType;

    private void Update()
    {
        //Thumbstick();
        //Trackpad();
        //Squeeze();
        //Grip();
        Pinch();
        //Skeleton();
    }

    private void Thumbstick()
    {
        if (ThumbstickAction.axis == Vector2.zero)
            return;

        print("Thumbstick: " + ThumbstickAction.axis);
    }

    private void Trackpad()
    {
        if (TrackpadAction.axis == Vector2.zero)
            return;

        print("Trackpad: " + TrackpadAction.axis);
    }

    private void Squeeze()
    {
        if (SqueezeAction.axis == 0.0f)
            return;

        print("Squeeze: " + SqueezeAction.axis);
    }

    private void Grip()
    {
        if (GripAction.active == false)
            return;

        print("Grip: " + GripAction.active);
    }

    private void Pinch()
    {
        if (grabPinch.GetState(handType))
        {
            Debug.Log("트리거 누르는 중");
        }
    }

    private void Skeleton()
    {

    }
}
