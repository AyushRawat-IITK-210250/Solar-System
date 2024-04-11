using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Planet : MonoBehaviour
{
    public Handle handle;
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
    //private void OnMouseDown()
    //{
    //    Debug.Log(this.gameObject.tag);
    //    //handle.offset=new Vector3 (0,10,-40);
    //    handle.offset = handle.positions[this.gameObject.tag];
    //    handle.target = this.gameObject;
    //    //Camera.main.transform.position = handle.target.transform.position + handle.offset;
    //    Camera.main.transform.rotation = Quaternion.identity;
    //}
    private IEnumerator SmoothCameraMove(Vector3 targetPosition, Quaternion targetRotation, float duration)
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = Camera.main.transform.position;
        Quaternion startingRotation = Camera.main.transform.rotation;

        while (elapsedTime < duration)
        {
            Camera.main.transform.position = Vector3.Lerp(startingPosition, targetPosition, (elapsedTime / duration));
            Camera.main.transform.rotation = Quaternion.Slerp(startingRotation, targetRotation, (elapsedTime / duration));

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Camera.main.transform.position = targetPosition;
        Camera.main.transform.rotation = targetRotation;
    }
    private void OnMouseDown()
    {
        handle.offset = handle.positions[this.gameObject.tag];
        handle.target = this.gameObject;
        handle.isTop = false;
        Vector3 targetPosition = handle.target.transform.position + handle.offset;
        Quaternion targetRotation = Quaternion.identity;
        StartCoroutine(SmoothCameraMove(targetPosition, targetRotation, 0.5f));
    }

}
