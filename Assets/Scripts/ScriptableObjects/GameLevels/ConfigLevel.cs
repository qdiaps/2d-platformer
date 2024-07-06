using UnityEngine;

namespace ScriptableObjects.GameLevels
{
    [CreateAssetMenu(fileName="ConfigLevel", menuName="Config/Levels")]
    public class ConfigLevel : ScriptableObject
    {
        public GameObject Player;
        public GameObject UI;
        public GameObject[] StaticObjects;
        public GameObject[] DynamicObjects;
    }
}