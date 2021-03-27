using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Car carPrefab;

    private Car controlledCar;

    void Start()
    {
        controlledCar = Instantiate(carPrefab, Vector3.up, Quaternion.identity);
    }

    void FixedUpdate()
    {
        Vector2 inputs = ReadInputs();
        controlledCar.Move(inputs);
    }

    private Vector2 ReadInputs()
    {
        return new Vector2()
        {
            x = Input.GetAxisRaw ("Horizontal"),
            y = Input.GetAxisRaw ("Vertical")
        };
    }
}