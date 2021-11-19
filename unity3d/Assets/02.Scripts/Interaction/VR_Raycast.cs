using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.EventSystems;


public class VR_Raycast : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

    private void OnEnable()
    {
        laserPointer = gameObject.GetComponent<SteamVR_LaserPointer>();

        // 이벤트 할당
        laserPointer.PointerIn += OnPointerEnter;
        laserPointer.PointerOut += OnPointerExit;
        laserPointer.PointerClick += OnPointerClick;
    }

    private void OnDisable()
    {
        // 이벤트 연결 해제
        laserPointer.PointerIn -= OnPointerEnter;
        laserPointer.PointerOut -= OnPointerExit;
        laserPointer.PointerClick -= OnPointerClick;
    }

    void OnPointerEnter(object sender, PointerEventArgs e)
    {
        IPointerEnterHandler enterHandler = e.target.GetComponent<IPointerEnterHandler>();
        if (enterHandler == null) return;

        enterHandler.OnPointerEnter(new PointerEventData(EventSystem.current));

    }

    void OnPointerExit(object sender, PointerEventArgs e)
    {
        IPointerExitHandler exitHandler = e.target.GetComponent<IPointerExitHandler>();
        if (exitHandler == null) return;

        exitHandler.OnPointerExit(new PointerEventData(EventSystem.current));
    }

    void OnPointerClick(object sender, PointerEventArgs e)
    {
        IPointerClickHandler clickHandler = e.target.GetComponent<IPointerClickHandler>();
        if (clickHandler == null) return;

        clickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
    }
}