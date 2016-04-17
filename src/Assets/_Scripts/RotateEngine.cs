using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class RotateEngine : MonoBehaviour
{
    public float Throttle
    {
        get; set;
    }

    public float power = 0f;
    public Transform placeholder;

    void FixedUpdate()
    {
        if (placeholder != null)
        {
            rigidbody.AddForceAtPosition(
                placeholder.right * power * Throttle,
                placeholder.position,
                ForceMode.Force);
        }
    }
}
