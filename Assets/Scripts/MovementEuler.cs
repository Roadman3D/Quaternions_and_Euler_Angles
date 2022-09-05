using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEuler : MonoBehaviour
{
    // variables
    public float speed = 2.0f;


    // Update is called once per frame
    void Update()
    {
        // creating the vector
        Vector3 moveEuler = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Vertical"));
        // movement according to vector
        transform.Translate(moveEuler * speed * Time.deltaTime);
    }
}
