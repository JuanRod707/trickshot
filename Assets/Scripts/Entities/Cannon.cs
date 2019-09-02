using UnityEngine;

namespace Entities
{
    public class Cannon : MonoBehaviour
    {
        public Projectile ProjectilePrefab;

        public void FireBall(float force)
        {
            var ball = Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            ball.Launch(force);
        }
    }
}
