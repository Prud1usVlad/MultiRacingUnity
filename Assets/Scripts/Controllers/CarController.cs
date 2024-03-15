using Assets.Scripts.Controllers;
using Assets.Scripts.DataContainers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float accelerationInput;
    public float steeringInput;

    public float rotationAngle;

    public float velocityVsUp;

    public float maxSpeed;

    public float accelerationMul;
    public float turnMul;
    public float driftMul;

    public float inertionMul;

    public float sideMovementForSkidmarks = 4f;

    public void SetInput(Vector2 input)
    {
        steeringInput = input.x;
        accelerationInput =  input.y;
    }

    public bool IsTireScreeching(out float lateralVelocity, out bool isBraking)
    {
        lateralVelocity = GetLateralVelocity();
        isBraking = false;

        if (accelerationInput < 0 && velocityVsUp > 0)
        {
            isBraking = true;
            return true;
        }
        if (Mathf.Abs(lateralVelocity) > sideMovementForSkidmarks)
        {
            return true;
        }

        return false;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (gameObject.name.Contains("Clone"))
            gameObject.tag = "OtherPlayer";
    }

    private void FixedUpdate()
    {
        if (gameObject.tag != "Player")
            return;

        ApplyEngineForce();
        KillOrthagonalVelocity();
        ApplySteering();
    }

    private void ApplyEngineForce()
    {
        velocityVsUp = Vector2
            .Dot(transform.up, rb.velocity);

        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
            return;

        if (rb.velocity.sqrMagnitude > maxSpeed * maxSpeed
            && accelerationInput > 0)
            return;


        if (accelerationInput == 0)
        {
            rb.drag = Mathf.Lerp(rb.drag, 3f, Time.fixedDeltaTime * inertionMul);
        }
        else
        {
            rb.drag = 0;
        }


        var forceVector = transform.up 
            * accelerationInput * accelerationMul;

        rb.AddForce(forceVector, ForceMode2D.Force);
    }

    private void ApplySteering()
    {
        var minSpeedCheck = rb.velocity.magnitude / 8;
        minSpeedCheck = Mathf.Clamp01(minSpeedCheck);

        rotationAngle += steeringInput * turnMul * minSpeedCheck;

        rb.MoveRotation(rotationAngle);
    }

    private void KillOrthagonalVelocity()
    {
        var forvardVelocity = transform.up 
            * Vector2.Dot(rb.velocity, transform.up);
        var rightVelocity = transform.right 
            * Vector2.Dot(rb.velocity, transform.right);

        rb.velocity = forvardVelocity + rightVelocity * driftMul;
    }

    private float GetLateralVelocity()
    {
        return Vector2.Dot(transform.right, rb.velocity);
    }
}
