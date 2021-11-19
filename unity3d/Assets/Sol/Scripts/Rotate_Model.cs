using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Model : MonoBehaviour
{
    //model rotate speed
    public float speed_ = 5f;

    void Update()
    {
        //모델 회전
        float hori = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * speed_ * hori);
    }
}
