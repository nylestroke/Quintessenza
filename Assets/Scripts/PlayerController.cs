using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float MovementSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get controller (X axis)
        var x = Input.GetAxis("Horizontal");

        // Count result horizontal movement (left/right using X axis)
        var movement = Vector3.right * x * Time.deltaTime; // Multiply by delta time

        // Get controller (Y axis)
        var y = Input.GetAxis("Vertical");

        // Count result horizontal + vertical movement (forward/backward using Y axis)
        movement += Vector3.forward * y * Time.deltaTime; // Multiply by delta time

        // Normalize movement
        movement = movement.normalized;

        // Multiply by speed time and delta time
        movement *= MovementSpeed * Time.deltaTime;

        // Move player every update tick
        transform.position += movement;
    }
}
