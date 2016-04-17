using UnityEngine;
using System.Collections;

public class CameraFollowObject : MonoBehaviour
{
    public Transform objectToFollow;
    public float offset = 1f;

    private float _initialCameraZ;

	void Start()
    {
        _initialCameraZ = camera.transform.position.z;
	}
	
	void LateUpdate()
    {
        Vector3 offsetVector = (objectToFollow.rotation * Vector3.up) * offset;
	    Vector3 finalPosition = objectToFollow.position + offsetVector;
        finalPosition.z = _initialCameraZ;

        camera.transform.position = finalPosition;
	}
}
