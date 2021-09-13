using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProppelerRotation : MonoBehaviour
{
    public GameObject proppeler;
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        proppeler.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
