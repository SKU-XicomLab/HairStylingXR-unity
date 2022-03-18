using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; //steamVR namespace
using EzySlice; // mesh 자르는 라이브러리 (cut)

public class ValveController : MonoBehaviour
{
    public SteamVR_Input_Sources handType;  //hand타입 설정

    // Trigger  
    public SteamVR_Action_Boolean interactUI = null; //인터렉션 활성화 

    // Trackpad
    public SteamVR_Action_Boolean teleport = null;

    // Btn
    public SteamVR_Action_Boolean ABtn = null; //A button
    public SteamVR_Action_Boolean BBtn = null; //B button

    // Grip
    float squueze_value; //그랩 쥐는 강도
    public SteamVR_Action_Single squeeze = null;
    public SteamVR_Action_Boolean grabGrip = null;

    // Thumb Stick
    public SteamVR_Action_Boolean touch = null;
    public SteamVR_Action_Boolean snapTurnRight = null;
    public SteamVR_Action_Boolean snapTurnLeft = null;

    // Pinch
    public SteamVR_Action_Boolean grabPinch = null;

    public GameObject GUI;  //사용자 인터페이스

    public Material materialAfterSlice; //cut한 이후 
    public LayerMask sliceMask; //LayerMask = raycast 사용중 자신과 타겟사이에 오브젝트가 끼어들어도 계속 타겟에게 ray를 쏘고 싶을때
    public bool isTouched;  //isTouched 활성화/비활성화

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

    public void Cut()  //자르기
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
            if (GUI.activeSelf)  //gameobject(GUI) ON상태
            {
                GUI.SetActive(false); //gameobject(GUI) 비활성화
                Debug.Log("OFF GUI");
            }

            else //gameobject(GUI) Off상태
            {
                GUI.SetActive(true); //gameobject(GUI) 활성화
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