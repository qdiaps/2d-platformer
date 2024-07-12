using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Services.InputService.PC
{
    public class PCInputReader : MonoBehaviour, IInputCallback, IInputDestroy
    {
        public event Action<int> OnHorizontalInput;
        public event Action OnJumpInput;

        private InputSystem _inputSystem;

        private void Start() => 
            _inputSystem = new InputSystem();

        private void FixedUpdate() => 
            HorizontalInputHandler();

        public void Init()
        {
            _inputSystem.Gameplay.Enable();
            _inputSystem.Gameplay.Jump.performed += JumpHandler;
        }

        public void DestroyHandler()
        {
            _inputSystem.Gameplay.Disable();
            _inputSystem.Gameplay.Jump.performed -= JumpHandler;
            Destroy(gameObject);
        }

        private void JumpHandler(InputAction.CallbackContext obj) =>
            OnJumpInput?.Invoke();

        private void HorizontalInputHandler()
        {
            Vector2 direction = _inputSystem.Gameplay.Movement.ReadValue<Vector2>();
            if (direction.x != 0)
                OnHorizontalInput?.Invoke((int)direction.x);
        }
    }
}