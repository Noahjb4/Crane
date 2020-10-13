using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extention : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           transform.position = transform.position + new Vector3(-10f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
           transform.position = transform.position + new Vector3(10f * Time.deltaTime, 0, 0);
        }
    }
}
