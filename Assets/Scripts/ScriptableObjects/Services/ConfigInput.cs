using Services.InputService;
using UnityEngine;

namespace ScriptableObjects.Input
{
    [CreateAssetMenu(fileName="ConfigInput", menuName= "Config/Services/ConfigInput")]
    public class ConfigInput : ScriptableObject
    {
        public InputType InputType;
    }
}
