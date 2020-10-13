using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    
}
