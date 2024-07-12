using ScriptableObjects.Input;
using System;
using UnityEngine;

namespace Services.InputService
{
    public class InputService : MonoBehaviour
    {
        [SerializeField] private GameObject _prefabPCInput;
        [SerializeField] private GameObject _prefabMobileInput;

        private GameObject _currentInput;
        private InputType _currentInputType;
        
        public void Init(ConfigInput config)
        {
            switch (config.InputType)
            {
                case InputType.PC:
                    _currentInput = Instantiate(_prefabPCInput);
                    break;
                case InputType.Mobile:
                    _currentInput = Instantiate(_prefabMobileInput);
                    break;
                default:
                    throw new Exception("Неверный InputType в ConfigInput");
            }
            DontDestroyOnLoad(_currentInput);
            _currentInputType = config.InputType;
        }

        public void ChangeInput(InputType type)
        {
            if (_currentInputType == type)
                return;
            _currentInput.GetComponent<IInputDestroy>()
                .DestroyHandler();
            _currentInput = Instantiate(type == InputType.PC ? _prefabPCInput : _prefabMobileInput);
            DontDestroyOnLoad(_currentInput);
            _currentInputType = type;
        }

        public IInputCallback GetInput() =>
            _currentInput.GetComponent<IInputCallback>();
    }
}
