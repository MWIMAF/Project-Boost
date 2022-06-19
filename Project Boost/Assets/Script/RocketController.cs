using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            print("pressed");
            rigidBody.AddForce(Vector3.up);
        }


        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
}
