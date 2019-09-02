using Entities;
using UnityEngine;

namespace Input
{
    public class KeyboardInput : MonoBehaviour
    {
        public AimingMovement Aiming;
        public Cannon Cannon;
        public float DefaultForce;

        void Update()
        {
            if(UnityEngine.Input.GetKey(KeyCode.A))
                Aiming.RotateYaw(-1);
            else if (UnityEngine.Input.GetKey(KeyCode.D))
                Aiming.RotateYaw(1);
            if (UnityEngine.Input.GetKey(KeyCode.W))
                Aiming.RotatePitch(-1);
            else if (UnityEngine.Input.GetKey(KeyCode.S))
                Aiming.RotatePitch(1);

            if(UnityEngine.Input.GetKeyDown(KeyCode.Space))
                Cannon.FireBall(DefaultForce);
        }
    }
}
