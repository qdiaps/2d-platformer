using UnityEngine;

namespace Services.InputService.Mobile
{
    public abstract class InputHandler : MonoBehaviour
    {
        protected MobileInputReader _inputReader;

        private void Start() =>
            _inputReader = FindObjectOfType<MobileInputReader>();
    }
}