using System;
using UnityEngine;

namespace Services.InputService.PC
{
    public class PCInputReader : InputReader, IInputCallback
    {
        public event Action<float> OnHorizontalInput;
        public event Action OnJumpInput;

        private const string Horizontal = "Horizontal";

        protected override void CheckHorizontalInput()
        {
            float input = ReadHorizontalInput();
            if (input != 0f)
                OnHorizontalInput?.Invoke(input);
        }

        private float ReadHorizontalInput() =>
            UnityEngine.Input.GetAxis(Horizontal);

        protected override void CheckJumpInput()
        {
            if (ReadKeyDownInput(KeyCode.Space))
                OnJumpInput?.Invoke();
        }

        private bool ReadKeyDownInput(KeyCode key) =>
            UnityEngine.Input.GetKeyDown(key);
    }
}