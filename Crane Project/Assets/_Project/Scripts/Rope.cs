using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Transform boom;
    LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0,boom.position);
        lr.SetPosition(1,transform.position);
    }
}
