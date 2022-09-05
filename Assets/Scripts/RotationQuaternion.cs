using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationQuaternion : MonoBehaviour
{
    // variables
    public float speed = 50.0f;


    // Update is called once per frame
    void Update()
    {
        // creating the vector
        Vector3 rotateEuler = new Vector3(Input.GetAxis("VerticalX"), Input.GetAxis("HorizontalY"), Input.GetAxis("SidewaysZ"));
        // rotation according to vector
        transform.Rotate(rotateEuler * speed * Time.deltaTime);
    }
}
