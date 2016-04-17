using UnityEngine;
using System.Collections;

public class StatsToGUI : MonoBehaviour
{
    private FuelTank _fuelTank;

    public GUIText altitude;
    public GUIText fuelAmount;
    public GUIText speed;
    public GUIText verticalSpeed;

    public void Start()
    {
        _fuelTank = gameObject.GetComponent<FuelTank>();
        DebugUtils.Assert(_fuelTank != null, "Необходим топливный резервуар");
    }

    public void Update()
    {
        if (altitude != null && rigidbody != null) {
            altitude.text = "Altitude: " + gameObject.rigidbody.transform.position.y.ToString("0.00");
        }

        if (fuelAmount != null) {
            fuelAmount.text = "Fuel: " + _fuelTank.FuelAmount.ToString("0.00");
        }

        if (speed != null) {
            speed.text = "Speed: " + gameObject.rigidbody.velocity.magnitude;
        }

        if (verticalSpeed != null) {
            verticalSpeed.text = "V-Speed: " + gameObject.rigidbody.velocity.y;
        }
    }
}
