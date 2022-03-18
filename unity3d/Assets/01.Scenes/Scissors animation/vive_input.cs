using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; //SteamVR namespace

public class vive_input : MonoBehaviour
{
    // GrabGrip 버튼
    public SteamVR_Action_Boolean GrabGrip;  
    
    //SteamVR_Behaviour_Pose안 InputSource 가져오기 위한 변수 저장
    private SteamVR_Behaviour_Pose myHand = null;

    //컨트롤러 이동 변수 저장
    private Transform myTransform = null; 
    

    //컨트롤러와 부딪힌 오브젝트의 rigidbody를 저장하는 변수
    private Rigidbody currentRigidBody = null;

    
    void Start()
    { 
        myHand = GetComponent<SteamVR_Behaviour_Pose>();
        myTransform = GetComponent<Transform>();
        

    }

    
    void Update()
    {
        if(GrabGrip.GetStateDown(myHand.inputSource)) // inputSource = lefthand,righthand 가져옴 
        {
            //오브젝트를 컨트롤러에 부착
            Pickup();
        }

        
    }

    public void Pickup() //버튼 누를때 오브젝트 들기
    {
        
        if(currentRigidBody == null)//오브젝트의 rigidbody 유무검사
        { 
            return; 
        }
        
        //컨트롤러와 부딪힌 오브젝트의 rigidbody를 저장하는 변수의 부모를 컨트롤러 이동 변수로 설정 -> 오브젝트를 컨트롤러에 부착(차일드화)
        currentRigidBody.transform.parent = myTransform;   
    } 

    

    //컨트롤러와 오브젝트 간 충돌이 일어날 때 
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Interactable")) //Interactable 태그가 달린 오브젝트일때
        {
            currentRigidBody = other.gameObject.GetComponent<Rigidbody>(); //해당 rigidbody를 currentRigidBody 변수에 저장
        }
    }
}
        

    
