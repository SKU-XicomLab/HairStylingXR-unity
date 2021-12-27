using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using EzySlice;

public class ValveController : MonoBehaviour
{
    public SteamVR_Input_Sources handType;

    // Trigger
    public SteamVR_Action_Boolean interactUI = null;

    // Trackpad
    public SteamVR_Action_Boolean teleport = null;

    // Btn
    public SteamVR_Action_Boolean ABtn = null;
    public SteamVR_Action_Boolean BBtn = null;

    // Grip
    float squueze_value;
    public SteamVR_Action_Single squeeze = null;
    public SteamVR_Action_Boolean grabGrip = null;

    // Thumb Stick
    public SteamVR_Action_Boolean touch = null;
    public SteamVR_Action_Boolean snapTurnRight = null;
    public SteamVR_Action_Boolean snapTurnLeft = null;

    // Pinch
    public SteamVR_Action_Boolean grabPinch = null;

    public GameObject GUI;

    public Material materialAfterSlice;
    public LayerMask sliceMask;
    public bool isTouched;

    void Update()
    {
        //Cut();
        //On_GUI();
        InteractUI();

        /*InteractUI();
        Teleport();
        ABTN();
        BBTN();
        GrabGrip();
        GrabGripForce();
        /*ThumbStick();
        GrabPinch();
        SnapTurnRight();
        SnapTurnLeft();*/
    }

    #region Interact

    public void Cut()
    {
        if (ABtn.GetStateDown(handType) && squueze_value > 0.5f) // A 버튼 + 그랩포스 인터렉션, 포스강도 (0.0 ~ 1.0)
        {
            Debug.Log("Cut");
        }
    }

    public void On_GUI()
    {
        if (BBtn.GetStateDown(handType)) // B 버튼 인터렉션
        {
            if (GUI.activeSelf)
            {
                GUI.SetActive(false);
                Debug.Log("OFF GUI");
            }

            else
            {
                GUI.SetActive(true);
                Debug.Log("ON GUI");
            }
        }
    }

    public void InteractUI()
    {
        if (interactUI.GetStateDown(handType)) // 트리거 인터렉션
        {
            Debug.Log("InteractUI");
        }
    }


    #endregion

    #region Key Mapping
    // 키맵핑시 참고

    /*private void InteractUI() // 트리거
    {
        if (interactUI.GetStateDown(handType))
        {
            Debug.Log("InteractUI");
        }
    }

    private void Teleport() // 트랙패드
    {
        if (teleport.GetStateDown(handType))
        {
            Debug.Log("Teleport");
        }
    }

    private void ABTN() // A 버튼
    {
        if (ABtn.GetStateDown(handType))
        {
            Debug.Log("ABtn");
        }
    }

    private void BBTN() // B 버튼
    {
        if (BBtn.GetStateDown(handType))
        {
            Debug.Log("BBtn");
        }
    }

    private void GrabGrip() // 그랩
    {
        if (grabGrip.GetState(handType))
        {
            Debug.Log("GrabGrip");
        }
    }

    private void GrabGripForce() // 그랩포스
    {
        squueze_value = squeeze.GetAxis(handType);

        if (squueze_value > 0.5f) // 포스강도 (0.0 ~ 1.0)
        {
            Debug.Log("Squeeze");
        }
    }

    // 일반 컨트롤러
    /*private void ThumbStick()
    {
        if (touch.GetStateDown(handType))
        {
            Debug.Log("Touch");
        }
    }

    private void GrabPinch() // VR 컨트롤러 트리거
    {
        if (grabPinch.GetState(handType))
        {
            Debug.Log("GrabPinch");
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
    }*/
    #endregion
}