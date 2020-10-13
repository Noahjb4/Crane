using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extention : MonoBehaviour
{
    public Transform lever;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           transform.Translate(-Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
           transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (lever.rotation.eulerAngles.x > 30 && lever.rotation.eulerAngles.x < 180)
        {
            transform.Translate(-Vector3.forward * Time.deltaTime);
        }
        else if (lever.rotation.eulerAngles.x > 270 && lever.rotation.eulerAngles.x < 330)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else
        {
            
        }



    }
}
