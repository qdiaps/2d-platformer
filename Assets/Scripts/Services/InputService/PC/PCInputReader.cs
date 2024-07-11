using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Services.InputService.PC
{
    public class PCInputReader : MonoBehaviour, IInputCallback
    {
        public event Action<int> OnHorizontalInput;
        public event Action OnJumpInput;

        private InputSystem _inputSystem;

        private void Start()
        {
            _inputSystem = new InputSystem();
            _inputSystem.Enable();
            _inputSystem.Gameplay.Jump.performed += JumpHandler;
        }

        private void OnDestroy()
        {
            _inputSystem.Gameplay.Jump.performed -= JumpHandler;
        }

        private void FixedUpdate()
        {
            HorizontalInputHandler();
        }

        private void JumpHandler(InputAction.CallbackContext obj) =>
            OnJumpInput?.Invoke();

        private void HorizontalInputHandler()
        {
            var direction = _inputSystem.Gameplay.Movement.ReadValue<Vector2>();
            if (direction.x != 0)
                OnHorizontalInput?.Invoke((int)direction.x);
        }
    }
}