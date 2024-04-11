using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour
{
    public int speed;
    private float totalRotation=0;
    //public GameObject target;
    public GameObject lightStatus;
    private int initialDim = 1;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,-400), new Vector3(0,1,0), speed * Time.deltaTime);
        //transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), speed * Time.deltaTime);                 
        totalRotation += speed * Time.deltaTime;
        if (initialDim == 1)
        {
            if (totalRotation > 84.243)
            {
                initialDim = 0;
                totalRotation = 0;
                //dimLight();
                StartCoroutine(DimLightOverTime());
            }
        }
        if(initialDim == 0) {
            if(totalRotation > 360)
            {
                totalRotation = 0;
                StartCoroutine (DimLightOverTime());
            }
        }        
    }
   
    private IEnumerator DimLightOverTime()
    {
        Light lightComponent = lightStatus.GetComponent<Light>();
        float startIntensity = lightComponent.intensity;
        float targetIntensity = 0;
        float duration = 0.9f; // Duration in seconds for the intensity change
        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            lightComponent.intensity = Mathf.Lerp(startIntensity, targetIntensity, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        lightComponent.intensity = 0;
        startIntensity = 0;
        targetIntensity = 25;
        duration = 0.9f;
        elapsedTime = 0;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            lightComponent.intensity = Mathf.Lerp(startIntensity, targetIntensity, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        lightComponent.intensity = 25;
    }


}
