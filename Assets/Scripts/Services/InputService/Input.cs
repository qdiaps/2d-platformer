using UnityEngine;

namespace Services.InputService
{
    public class Input : MonoBehaviour
    {
        [SerializeField] private GameObject _prefabPCInput;

        private IInputCallback _input;
        
        private void Start()
        {
            var inputObject = Instantiate(_prefabPCInput);
            DontDestroyOnLoad(inputObject);
            _input = inputObject.GetComponent<IInputCallback>();
        }

        public IInputCallback GetInput() =>
            _input;
    }
}
