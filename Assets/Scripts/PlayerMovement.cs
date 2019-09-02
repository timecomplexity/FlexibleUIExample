using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Move the player when input is received.
/// Code borrowed from: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float rotationSpeed = 100.0f;

    private void Update()
    {
        this.HandlePlayerMovement();
    }

    /// <summary>
    /// Handles player movement using axis
    /// </summary>
    private void HandlePlayerMovement()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        this.transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        this.transform.Rotate(0, rotation, 0);
    }
}
