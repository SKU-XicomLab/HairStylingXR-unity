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

    }

    private void Trackpad()
    {

    }

    private void Squeeze()
    {

    }

    private void Grip()
    {

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
