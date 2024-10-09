using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(4 * Time.deltaTime, 0, 0);
    }
}
