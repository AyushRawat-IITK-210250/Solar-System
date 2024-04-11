using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Rotate2 : MonoBehaviour
{
    public GameObject target;
    public int speed;
    public float x_comp;
    public float y_comp;
    public float z_comp;
   
   

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, new Vector3(x_comp, y_comp, z_comp), speed * Time.deltaTime);
     
    }
}
