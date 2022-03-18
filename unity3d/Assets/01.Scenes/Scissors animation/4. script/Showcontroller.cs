using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem; 

public class Showcontroller : MonoBehaviour
{
    
    public bool showcontroller = false; 
    void Update()
    {
        foreach (var hand in Player.instance.hands) //Player>instance>hands 
        {
            if(showcontroller)
            {
                hand.ShowController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController); //컨트롤러가 보이도록 켜져있을때 마치 잡은것처럼 손모양 설정 
            }
            else
            {
                hand.HideController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
            }
        
        }

            
    }
}
