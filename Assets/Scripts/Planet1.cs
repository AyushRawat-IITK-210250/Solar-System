using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Planet1 : MonoBehaviour
{
    //public Handle1 handle;
    public Color newColor;
    private TrailRenderer myTrail;
    private void Start()
    {

        myTrail = GetComponent<TrailRenderer>();
        // Check if the Trail Renderer component exists
        if (myTrail != null)
        {
            myTrail.material.color=newColor;
        }
        else
        {
            Debug.LogError("Trail Renderer component not found!");
        }
    }

    //private IEnumerator SmoothCameraMove(Vector3 targetPosition, Quaternion targetRotation, float duration)
    //{
    //    float elapsedTime = 0f;
    //    Vector3 startingPosition = Camera.main.transform.position;
    //    Quaternion startingRotation = Camera.main.transform.rotation;

    //    while (elapsedTime < duration)
    //    {
    //        Camera.main.transform.position = Vector3.Lerp(startingPosition, targetPosition, (elapsedTime / duration));
    //        Camera.main.transform.rotation = Quaternion.Slerp(startingRotation, targetRotation, (elapsedTime / duration));

    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }

    //    Camera.main.transform.position = targetPosition;
    //    Camera.main.transform.rotation = targetRotation;
    //}
    //private void OnMouseDown()
    //{
    //    handle.offset = handle.positions[this.gameObject.tag];
    //    handle.target = this.gameObject;
    //    handle.isTop = false;
    //    Vector3 targetPosition = handle.target.transform.position + handle.offset;
    //    Quaternion targetRotation = Quaternion.identity;
    //    StartCoroutine(SmoothCameraMove(targetPosition, targetRotation, 0.5f));
    //}

}
