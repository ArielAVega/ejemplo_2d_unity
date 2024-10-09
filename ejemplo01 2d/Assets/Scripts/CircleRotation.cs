using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime,
                           20 * Time.deltaTime,
                           30 * Time.deltaTime);
    }
}
