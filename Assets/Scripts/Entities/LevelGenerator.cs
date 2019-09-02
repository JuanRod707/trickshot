using System.Linq;
using UnityEngine;

namespace Entities
{
    public class LevelGenerator : MonoBehaviour
    {
        public GameObject BouncerPrefab;
        public GameObject KillerPrefab;
        public GameObject GoalPrefab;

        public float Radius;
        public float YDelta;
        public int MinObjects;
        public int MaxObjects;

        void Start()
        {
            var objectCount = Random.Range(MinObjects, MaxObjects);
            foreach (var _ in Enumerable.Range(0, objectCount))
                SpawnObject();
        }

        private void SpawnObject()
        {
            var xzPos = Random.insideUnitCircle * Radius;
            var yValue = Random.Range(-YDelta, YDelta);
            var position = new Vector3(xzPos.x, yValue, xzPos.y);
            var prefab = Random.Range(0, 3) > 0 ? BouncerPrefab : KillerPrefab;
            var obj = Instantiate(prefab, position, Quaternion.identity);
            obj.transform.SetParent(transform);
        }
    }
}
