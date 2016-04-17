using UnityEngine;
using System.Collections;

public class IsButtonPressed
:   MonoBehaviour
{
    public int level = 0;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (collider.Raycast(ray, out hit, 1000f))
            {
                Application.LoadLevel(level);
            }
        }
    }
}
