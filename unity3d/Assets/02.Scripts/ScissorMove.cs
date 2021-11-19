using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorMove : MonoBehaviour
{
    public GameObject Scissor;
    public GameObject Hair;
    public float speed;
   

    Vector3 a, b, c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * h * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * v * Time.deltaTime);

        if (c != null)
        {
            
            Debug.DrawRay(transform.position, c, Color.blue, 0.3f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hair")
        {
            a = Hair.transform.position - Scissor.transform.position;
            Debug.Log("a : "+ a);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hair")
        {
            b = Hair.transform.position - Scissor.transform.position;
            Debug.Log("b : " + b);
            c = Vector3.Cross(a.normalized, b.normalized);
            Debug.Log("c : " + c);
        }
    }
}
