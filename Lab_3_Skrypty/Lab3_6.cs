using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; 
    float smoothTime = 0.3f; 
    Vector3 velocity = Vector3.zero; 

    void Update()
    {
        Vector3 targetPosition = target.position;

        //Wybieramy SmoothDamp albo Lerp

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime / smoothTime);
    }
}
