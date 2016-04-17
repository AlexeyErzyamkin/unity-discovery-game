using UnityEngine;
using System.Collections;

public class SkyColor : MonoBehaviour
{
    public Transform objectWithHeight;

    private Color _initialColor;

    void Start()
    {
        _initialColor = camera.backgroundColor;
    }

    void Update()
    {
        float colorCoeffBasedOhHeight = Mathf.Lerp(1f, 0f, (objectWithHeight.position.y / 5000f));

        camera.backgroundColor = _initialColor * colorCoeffBasedOhHeight;
	}
}
