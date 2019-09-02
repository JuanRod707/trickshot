using UnityEngine;

public class AimingMovement : MonoBehaviour
{
    public float Sensitivity;

    public void RotatePitch(float delta)
    {
        var value = delta * Sensitivity;
        transform.Rotate(Vector3.right * value);
        NormalizeRoll();
    }

    public void RotateYaw(float delta)
    {
        var value = delta * Sensitivity;
        transform.Rotate(Vector3.up * value);
        NormalizeRoll();
    }

    void NormalizeRoll()
    {
        var euler = transform.eulerAngles;
        euler.z = 0f;
        transform.eulerAngles = euler;
    }
}
