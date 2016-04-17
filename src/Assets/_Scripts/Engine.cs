using UnityEngine;

using System.Collections;


[RequireComponent(typeof(Rigidbody), typeof(FuelTank))]
public class Engine : MonoBehaviour
{
	private float _throttle = 0f;

	public float power = 0f;
    public float fuelConsumption = 0f;
    public float powerIncreaseRate = 0f;

    public Transform placeholder;
    public Light fireLight;

    private FuelTank _fuelTank;

    public float Throttle
    {
        get { return _throttle; }
        set { _throttle = value; }
    }

    public float CurrentPower
    {
        get;
        private set;
    }

	void Start()
	{
        _fuelTank = gameObject.GetComponent<FuelTank>();
        DebugUtils.Assert(_fuelTank != null, "Топливный бак необходим для работы двигателя");
	}

	void Update()
	{

	}

	void FixedUpdate()
	{
        CurrentPower = Mathf.Lerp(CurrentPower, Throttle * power, Time.deltaTime * powerIncreaseRate);

        float realFuelConsumption = (CurrentPower / power) * (fuelConsumption * Time.deltaTime);
        float fuelTaken = _fuelTank.takeFuel(realFuelConsumption);
        float powerToFuelCoeff = realFuelConsumption == 0f ? 0f : fuelTaken / realFuelConsumption;

        float realPower = CurrentPower * powerToFuelCoeff;

        if (placeholder != null) {
            rigidbody.AddForceAtPosition(
                placeholder.up * realPower,
                placeholder.position,
                ForceMode.Force);
        }

        if (fireLight != null) {
            fireLight.enabled = realPower > 0f;
        }

        //rigidbody.AddRelativeForce(Vector3.up * Throttle * power, ForceMode.Force);
	}
}
