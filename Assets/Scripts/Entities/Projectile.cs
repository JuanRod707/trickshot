using System.Collections;
using UnityEngine;

namespace Entities
{
    public class Projectile : MonoBehaviour
    {
        public Rigidbody Body;
        public float Lifetime;

        public void Launch(float force)
        {
            Body.AddForce(transform.forward * force);
            StartCoroutine(WaitAndDestroy(Lifetime));
        }

        IEnumerator WaitAndDestroy(float lifetime)
        {
            yield return new WaitForSeconds(lifetime);
            Destroy();
        }

        private void Destroy()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Goal"))
            {
                Debug.Log("score!");
                Destroy();
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.rigidbody.CompareTag("Killer"))
                Destroy();
        }
    }
}
