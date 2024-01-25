using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Rotation : MonoBehaviour
{
    
    void Update()
    {

        Vector3 rotate = transform.eulerAngles;
        float mw = Input.GetAxis("Mouse ScrollWheel");

        float rotZ;
        rotZ = transform.eulerAngles.z;

        int angleRotation = 45;


        if (mw > 0)
        {
            if (rotZ == 135 | rotZ == 180)
            {
                rotate.z = rotZ + angleRotation;

                transform.rotation = Quaternion.Euler(rotate);
            }
            else
            {
                rotate.z = rotZ + angleRotation * 2;

                transform.rotation = Quaternion.Euler(rotate);
            }

        }

        if (mw < 0)
        {
            if (rotZ == 180 | rotZ == 225)
            {
                rotate.z = rotZ - angleRotation;

                transform.rotation = Quaternion.Euler(rotate);
            }
            else
            {
                rotate.z = rotZ - angleRotation * 2;

                transform.rotation = Quaternion.Euler(rotate);
            }
        }


        /*
            if (mw > 0)
                rotate.z = rotZ + 45;
            if (mw < 0)
                rotate.z = rotZ - 45;
        */

        //transform.rotation = Quaternion.Euler(rotate);

    }
}