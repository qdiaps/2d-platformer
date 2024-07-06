using UnityEngine;

namespace Core
{
    public class CreatorGameObject : MonoBehaviour
    {
        public static void CreateObject(GameObject prefab) =>
            Instantiate(prefab);

        public static void CreateObjects(GameObject[] prefabs)
        {
            foreach (GameObject prefab in prefabs) 
                CreateObject(prefab);
        }
    }
}