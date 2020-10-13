using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevation : MonoBehaviour
{
    public Transform lever;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     GetComponent<Rigidbody>().freezeRotation = false;
        //     GetComponent<HingeJoint>().axis = new Vector3(0,0,-1);
        //     GetComponent<HingeJoint>().useMotor = true;
        // }else if (Input.GetKey(KeyCode.S))
        // {
        //     GetComponent<Rigidbody>().freezeRotation = false;
        //     GetComponent<HingeJoint>().axis = new Vector3(0,0,1);
        //     GetComponent<HingeJoint>().useMotor = true;
        // }else{
        //     GetComponent<HingeJoint>().useMotor = false;
        //     GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ;
        // }

        if (lever.rotation.eulerAngles.x > 30 && lever.rotation.eulerAngles.x < 180)
        {
            GetComponent<Rigidbody>().freezeRotation = false;
            GetComponent<HingeJoint>().axis = new Vector3(0, 0, -1);
            GetComponent<HingeJoint>().useMotor = true;
        }
        else if (lever.rotation.eulerAngles.x > 270 && lever.rotation.eulerAngles.x < 330)
        {
            GetComponent<Rigidbody>().freezeRotation = false;
            GetComponent<HingeJoint>().axis = new Vector3(0, 0, 1);
            GetComponent<HingeJoint>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint>().useMotor = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ;
        }



    }
}
