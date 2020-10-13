using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPickUp : MonoBehaviour
{

    public GameObject magnet;
    public GameObject cube;
    public GameObject trigger;
    public GameObject cubePosition;
    

    public bool machineOn;

    private void Start()
    {
        machineOn = false;
    }

    private void Update()
    {
        if(machineOn == false)
        {
            cube.transform.SetParent(null);
            cube.GetComponent<Rigidbody>().useGravity = true;
            cube.GetComponent<Rigidbody>().isKinematic = false;
            cube.GetComponent<BoxCollider>().enabled = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(machineOn == true && other.gameObject.name == "Cube")
        {
            Debug.Log("Collision");

            cube.GetComponent<Rigidbody>().useGravity = false;
            cube.GetComponent<Rigidbody>().isKinematic = true;
            cube.GetComponent<BoxCollider>().enabled = false;

            cube.transform.position = cubePosition.transform.position;
            //cube.transform.rotation = cubePosition.transform.rotation;
            cube.transform.SetParent(magnet.transform);
            
        }
     
    }


    public void IsMachineOn()
    {
        if (machineOn == true)
        {
            machineOn = false;
            Debug.Log("Machine is off");
        }

         
        else
        {
            machineOn = true;
            Debug.Log("Machine is on");
        }
            
    }



    


}
