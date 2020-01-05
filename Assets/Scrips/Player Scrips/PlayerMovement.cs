using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform transform;
    public float forwadForce = 2000f;
    public float sidewaysForce = 500f;
    public Vector3 startPosition;




    // Start is called before the first frame update
    void Start()
    {
        startPosition = (transform.position);
    }

    // Update is called once per frame for physics
    void FixedUpdate()
    {
        float baseNum = 1 * Time.deltaTime;

        rb.AddForce(0, 0 * baseNum, forwadForce * baseNum, ForceMode.VelocityChange);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * baseNum, 0, 0, ForceMode.VelocityChange);
        }
        else
        {    
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * baseNum, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}
