using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Build.Content;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class Handle : MonoBehaviour
{   private Vector3 cam_Position =new Vector3(0,800,0);
    private Vector3 cam_Rotation =new Vector3(90,0,0);
    public Vector3 offset = new Vector3(0, 0, 0);
    public bool isTop = true;
    public GameObject target;
    public Dictionary<string, Vector3> positions = new Dictionary<string, Vector3>();
    private void Start()
    {
        // Initialize positions for different objects
        positions.Add("Sun", new Vector3(0, 10, -210));
        positions.Add("Earth", new Vector3(0, 10, -100));
        positions.Add("Mercury", new Vector3(0, 10, -100));
        positions.Add("Venus", new Vector3(0, 10, -102));
        positions.Add("Mars", new Vector3(0, 10, -100));
        positions.Add("Jupiter", new Vector3(0, 10, -110));
        positions.Add("Saturn", new Vector3(0, 10, -100));
        positions.Add("Uranus", new Vector3(0, 10, -100));
        positions.Add("Neptune", new Vector3(0, 10, -100));
        positions.Add("Moon", new Vector3(0, 10, -100));
        positions.Add("Phobos", new Vector3(0, 10, -100));
        positions.Add("Diemos", new Vector3(0, 10, -100));
        positions.Add("Ganymede", new Vector3(0, 10, -110));
        positions.Add("Titan", new Vector3(0, 10, -110));
        positions.Add("Titania", new Vector3(0, 10, -100));
        positions.Add("Triton", new Vector3(0, 10, -100));
    }
    // Update is called once per frame
    void Update()
    {
        if (!isTop)
        {
            Camera.main.transform.position = target.transform.position + offset;
        }
    }
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
    public void TopView()
    {
        Vector3 targetPosition = cam_Position;
        Quaternion targetRotation = Quaternion.Euler(cam_Rotation);
        StartCoroutine(SmoothCameraMove(targetPosition, targetRotation, 0.5f));
        offset = Vector3.zero;
        isTop = true;
    }
}
