using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetDropOff : MonoBehaviour
{

    public GameObject cube;
    public GameObject dropOffTrigger;
    public GameObject dropOffPosition;

    public bool magnetOn;

    // Start is called before the first frame update
    void Start()
    {
        dropOffTrigger.SetActive(true);
        dropOffPosition.SetActive(false);
        magnetOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("Drop Off Collision");

            dropOffTrigger.SetActive(false);
            dropOffPosition.SetActive(true);

            cube.transform.position = dropOffPosition.transform.position;
            cube.transform.SetParent(dropOffPosition.transform);
    }


    public void TurnOnMagnet()
    {

    }

}
