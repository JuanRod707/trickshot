using UnityEngine;

namespace Entities
{
    public class EntityRandomizer: MonoBehaviour
    {
        public bool Rotation;
        public bool Scale;

        public float MinScale;
        public float MaxScale;
        
        void Start()
        {
            if(Rotation)
                transform.rotation = Random.rotation;
            if(Scale)
                transform.localScale = RandomizeVector3();
        }

        private Vector3 RandomizeVector3()
        {
            var x = Random.Range(MinScale, MaxScale);
            var y = Random.Range(MinScale, MaxScale);
            var z = Random.Range(MinScale, MaxScale);

            return new Vector3(x, y, z);
        }
    }
}
