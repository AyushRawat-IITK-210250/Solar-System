using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotateCapsule : MonoBehaviour
{
    public int speed=10;
    void Update()
    {
        transform.RotateAround(new Vector3(0,-15,0), new Vector3(0,1,0), speed * Time.deltaTime);
    }
}
