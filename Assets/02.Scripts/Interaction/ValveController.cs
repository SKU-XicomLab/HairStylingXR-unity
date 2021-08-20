using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using Valve.VR;

public class ValveController : MonoBehaviour
{
    /*void Update()
    {
        Ray raycast = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(raycast, out hit))
        {
            if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))
            {
                Debug.Log("트리거 누름");
            }

            if (ViveInput.GetPress(HandRole.RightHand, ControllerButton.Trigger))
            {
                Debug.Log("트리거 누르는 중");
            }

            if (ViveInput.GetPress(HandRole.RightHand, ControllerButton.Trigger))
            {
                Debug.Log("트리거 땜");
            }
        }
    }*/

    public SteamVR_Action_Vector2 ThumbstickAction = null;
    public SteamVR_Action_Vector2 TrackpadAction = null;
    public SteamVR_Action_Single SqueezeAction = null;
    public SteamVR_Action_Boolean GripAction = null;
    public SteamVR_Action_Boolean PinchAction = null;
    public SteamVR_Action_Skeleton SkeletonAction = null;

    private void Update()
    {
        //Thumbstick();
        Trackpad();
        //Squeeze();
        //Grip();
        //Pinch();
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

    }

    private void Pinch()
    {

    }

    private void Skeleton()
    {

    }
}
