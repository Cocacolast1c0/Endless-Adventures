using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 camOffset;
    public float time = 0.3f;

    private Vector3 currentVelocity = Vector3.zero;

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + camOffset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, time);
    }
}