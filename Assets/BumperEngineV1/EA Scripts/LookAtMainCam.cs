using UnityEngine;

public class LookAtMainCam : MonoBehaviour
{
    private Transform target;

    void Start()
    {
        GameObject cameraObj = GameObject.FindWithTag("MainCamera");
        
        if (cameraObj != null)
        {
            target = cameraObj.transform;
        }
    }

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}