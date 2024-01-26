using UnityEngine;

public class Projectile : MonoBehaviour
{
    public TrajectoireCurve curve;
    public float speed;
    public float rotationSpeedZ; // Added rotation speed around the z-axis
    private float sampleTime;

    void Start()
    {
        transform.rotation = Quaternion.identity;
        sampleTime = 0f;
    }

    void Update()
    {
        sampleTime += Time.deltaTime * speed;

        if (sampleTime >= 0f && sampleTime <= 1f)
        {
            // Evaluate the position on the curve and set the arrow's position
            Vector3 newPosition = curve.evaluate(sampleTime);
            transform.position = newPosition;

            // Calculate the forward direction based on the next point on the curve
            Vector3 nextPosition = curve.evaluate(sampleTime + 0.01f); // You can adjust the delta value
            Vector3 direction = (nextPosition - newPosition).normalized;

            // Calculate the rotation to face the calculated direction without the -90 degrees on the y-axis
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeedZ);
        }
        else
        {
            // If the sample time is outside the valid range, log an explosion and destroy the arrow
            Debug.Log("explosion!");
            Destroy(gameObject);
        }
    }
}
