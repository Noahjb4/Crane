using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform lever;
    public bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
           transform.Rotate(0, -20f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
           transform.Rotate(0, 20f * Time.deltaTime, 0);
        }

        if (lever.rotation.eulerAngles.z > 30 && lever.rotation.eulerAngles.z < 180)
        {
            transform.Rotate(0, -20f * Time.deltaTime, 0);
            isMoving = true;
        }
        else if (lever.rotation.eulerAngles.z > 270 && lever.rotation.eulerAngles.z < 330)
        {
            transform.Rotate(0, 20f * Time.deltaTime, 0);
            isMoving = true;
        }
        else
        {
            transform.Rotate(0, 0, 0);
            isMoving = false;
        }
        


    }

    
}
