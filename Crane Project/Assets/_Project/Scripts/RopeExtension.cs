using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeExtension : MonoBehaviour
{
    SpringJoint spring;
    public Transform lever;
    // Start is called before the first frame update
    void Start()
    {
        spring = GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && spring.spring >= 2)
        {
            spring.spring -= 5f*Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E) && spring.spring <= 18)
        {
            spring.spring += 5f*Time.deltaTime;
        }
        else
        {

        }

        if (lever.rotation.eulerAngles.x > 30 && lever.rotation.eulerAngles.x < 180 && spring.spring >= 2)
        {
            spring.spring -= 10f * Time.deltaTime;
        }
        else if (lever.rotation.eulerAngles.x > 270 && lever.rotation.eulerAngles.x < 330 && spring.spring <= 18)
        {
            spring.spring += 10f * Time.deltaTime;
        }
        else
        {

        }


    }
}
