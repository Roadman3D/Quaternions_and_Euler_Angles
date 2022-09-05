using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEuler : MonoBehaviour
{
    // variables
    public float speed = 50.0f;
    private Vector3 rotateAngle = new Vector3(0.0f, 0.0f, 0.0f);


    // Update is called once per frame
    void Update()
    {
        // adding coordinates to the vector
        rotateAngle += new Vector3(Input.GetAxis("VerticalX"), Input.GetAxis("HorizontalY"), Input.GetAxis("SidewaysZ")) * speed * Time.deltaTime;
        // rotating by euler angle
        transform.rotation = Quaternion.Euler(rotateAngle);
    }
}
