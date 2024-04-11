using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EllipticalRotation : MonoBehaviour
{
    
    public GameObject Text;
    private float angle = 90f;
    private float alpha=0;
    private int i=0;
    ArrayList About = new ArrayList();
    void Start()
    {
        About.Add("Spring: As the Earth moves along its orbit, the northern hemisphere starts tilting towards the sun.This tilt allows more direct sunlight to reach the northern regions, leading to longer days and warmer temperatures.");
        About.Add("Summer: As the Earth moves along its orbit, the northern hemisphere is tilted towards the sun and receiving more direct sunlight. This tilt leads to longer daylight hours and warmer temperatures.");
        About.Add("Autumn: As the Earth moves along its orbit, the northern hemisphere starts tilting away from the Sun. This tilt reduces the amount of direct sunlight reaching the northern regions, leading to shorter days and cooler temperatures.");
        About.Add("Winter: As the Earth moves along its orbit, the northern hemisphere is tilted away from the sun. This tilt results in shorter daylight hours and less direct sunlight reaching the northern regions, leading colder temperatures.");
    }

    void Update()
    {

        transform.position =  new Vector3(-100f + (300f * Mathf.Sin(Mathf.Deg2Rad * angle)),0,0f + (200f * Mathf.Cos(Mathf.Deg2Rad * angle)));
        angle -= 0.02f;
        alpha += 0.02f;
        if(alpha > 90)
        {
            alpha = 0;
            Text.GetComponent<TextMeshProUGUI>().text = About[i%4].ToString();
            i++;
        }
    }
    

}
