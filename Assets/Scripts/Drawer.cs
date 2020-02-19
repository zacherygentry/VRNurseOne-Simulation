using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{

    Vector3 initialPosition;
    public Vector3 maxPositiveDistance;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = gameObject.transform.localPosition;
    }


    void FixedUpdate()
    {
        Debug.Log(transform.localPosition);
        if( transform.localPosition.z > initialPosition.z + maxPositiveDistance.z)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, initialPosition.z + maxPositiveDistance.z);
        }
    }
}
