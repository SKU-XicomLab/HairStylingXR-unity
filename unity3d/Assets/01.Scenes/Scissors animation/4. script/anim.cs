using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; //벨브 인덱스 불러오기

public class anim : MonoBehaviour
{
    private Animator MyanimController;

    
    
    void Awake() 
    {
        MyanimController = GetComponent<Animator>();    
    }
    void Update()
    {
        //벨브 인덱스 버튼 액션 bool함수에 저장
        bool state = SteamVR_Actions.default_ABtn[SteamVR_Input_Sources.RightHand].state;

        if(state) //A버튼이 눌러지면
        {
            StartCoroutine("MyCo"); //coroutine 발생
        }    
    }

    IEnumerator MyCo()
    {
        yield return new WaitForSeconds(0.1f);   //0.1초 기다렸다 트리거 활성화 시킨 뒤 빠져나감.
        
        MyanimController.SetTrigger("Ontrigger"); //트리거 활성화

        
    }
}
