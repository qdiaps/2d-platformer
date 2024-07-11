using UnityEngine;

namespace Services.InputService
{
    public class InputService : MonoBehaviour
    {
        [SerializeField] private GameObject _prefabPCInput;

        private IInputCallback _currentInput;
        
        private void Start()
        {
            var inputObject = Instantiate(_prefabPCInput);
            DontDestroyOnLoad(inputObject);
            _currentInput = inputObject.GetComponent<IInputCallback>();
        }

        public IInputCallback GetInput() =>
            _currentInput;
    }
}
