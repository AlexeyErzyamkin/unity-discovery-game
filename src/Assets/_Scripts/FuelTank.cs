using UnityEngine;
using System.Collections;

public class FuelTank : MonoBehaviour
{
    /// <summary>
    /// Максимально возможное количество топлива
    /// </summary>
    public float maxFuelAmount = 0f;

    /// <summary>
    /// Текущее количество топлива
    /// </summary>
    public float FuelAmount
    {
        get;
        private set;
    }

    public void Start()
    {
        FuelAmount = maxFuelAmount;
    }

    /// <summary>
    /// Запрос на получение топлива из резервуара. Функция пытается отнять запрошенное количество топлива от текущего количества.
    /// Если текущее количество меньше чем запрошенное, то только функция вернёт остаток топлива.
    /// </summary>
    /// <param name="amount">Количество топлива, которое необходимо получить</param>
    /// <returns>Рельно полученное количество топлива</returns>
    public float takeFuel(float amount)
    {
        DebugUtils.Assert(amount >= 0f, "Количество топлива меньше 0");

        FuelAmount -= amount;

        if (FuelAmount < 0f) {
            amount += FuelAmount;
            FuelAmount = 0f;
        }

        return amount;
    }

    /// <summary>
    /// Пополнить топливный резервуар. Количество топлива после пополнения не может превышать максимально допустимого количества.
    /// </summary>
    /// <param name="amount">Количество топлива</param>
    public void replenishFuel(float amount)
    {
        DebugUtils.Assert(amount > 0f, "Количество топлива меньше либо равно нулю");

        FuelAmount += amount;

        if (FuelAmount > maxFuelAmount) {
            FuelAmount = maxFuelAmount;
        }
    }
}
