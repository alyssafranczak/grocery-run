using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltSpriteOnMove : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     float moveDirection = Input.GetAxisRaw("Vertical");
    //     if (moveDirection >= 1) 
    //     {
    //         transform.Rotate(0, 0, 3.0f);
    //     } else if (moveDirection <= -1) 
    //     {
    //         transform.Rotate(0, 0, -3.0f);
    //     }
    // }
    public float smooth;
    public float tiltAngle;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }
}
