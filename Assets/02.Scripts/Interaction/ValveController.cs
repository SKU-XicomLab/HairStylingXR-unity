using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ValveController : MonoBehaviour
{
    public SteamVR_Input_Sources handType;

    public SteamVR_Action_Boolean interactUI = null;
    public SteamVR_Action_Boolean teleport = null;
    public SteamVR_Action_Boolean grabPinch = null;
    public SteamVR_Action_Boolean grabGrip = null;
    public SteamVR_Action_Boolean snapTurnRight = null;
    public SteamVR_Action_Boolean snapTurnLeft = null;

    private void Update()
    {
        InteractUI();
        Teleport();
        GrabPinch();
        GrabGrip();
        SnapTurnRight();
        SnapTurnLeft();
    }

    private void InteractUI() // VR 컨트롤러 트리거 UI 인터렉션
    {
        if (interactUI.GetStateDown(handType))
        {
            Debug.Log("InteractUI");
        }
    }

    private void Teleport() // VR 컨트롤러 트랙패드 (North, Center, South)
    {
        if (teleport.GetStateDown(handType))
        {
            Debug.Log("Teleport");
        }
    }

    private void GrabPinch() // VR 컨트롤러 트리거
    {
        if (grabPinch.GetState(handType))
        {
            Debug.Log("GrabPinch");
        }
    }

    private void GrabGrip() // VR 컨트롤러 좌우버튼
    {
        if (grabGrip.GetState(handType))
        {
            Debug.Log("GrabGrip");
        }
    }

    private void SnapTurnRight() // VR 컨트롤러 트랙패드 (East)
    {
        if (snapTurnRight.GetState(handType))
        {
            Debug.Log("snapTurnRight");
        }
    }

    private void SnapTurnLeft() // VR 컨트롤러 트랙패드 (West)
    {
        if (snapTurnLeft.GetState(handType))
        {
            Debug.Log("snapTurnLeft");
        }
    }
}

