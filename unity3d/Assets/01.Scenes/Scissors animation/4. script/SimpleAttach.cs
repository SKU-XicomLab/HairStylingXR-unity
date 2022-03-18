using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class SimpleAttach : MonoBehaviour
{
    Interactable interactable;

    Animator animator;
    
    
    public GameObject Camera;
    void Awake() 
    {
        interactable = GetComponent<Interactable>();

        
        
        /*if (Camera.activeSelf)
        {
            Camera.SetActive(false);
        }*/
            
    }

    
    


    void OnHandHoverBegin(Hand hand)
    {
        //hand.ShowGrabHint(); 
    }

    void OnHandHoverEnd(Hand hand)
    {
        hand.HideGrabHint();
    }
    void HandHoverUpdate(Hand hand)
    {
        GrabTypes grabType = hand.GetGrabStarting();  //GetGrabStarting = 부울 Grab행동이 해당 시간에 트리거 되고있는지 확인할 때 사용
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        

        //잡을 때
        if(interactable.attachedToHand == null && grabType != GrabTypes.None) //interactable Hover Events>AttachedTOHand == null 그리고 grabtype이 None이 아니라면,
        {
            hand.AttachObject(gameObject, grabType); //손에서 객체를 부착
            
            
            //hand.HoverLock(interactable); //누를때만 붙어있음, 손이 특정 물체 위에 떠 있도록 하기 위해서만 사용
            //hand.HideGrabHint(); //컨트롤러 숨기기
        }

        else if(isGrabEnding) //풀었을때
        {
            hand.DetachObject(gameObject); //손에서 객체를 분리
           //hand.HoverUnlock(interactable); 

        }
    } 

    
    
}
