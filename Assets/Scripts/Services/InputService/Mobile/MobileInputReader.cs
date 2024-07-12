using System;
using UnityEngine;

namespace Services.InputService.Mobile
{
    public class MobileInputReader : MonoBehaviour, IInputCallback, IInputDestroy
    {
        public event Action<int> OnHorizontalInput;
        public event Action OnJumpInput;

        [SerializeField] private GameObject _prefabUIInput;

        private const string CanvasTag = "Canvas";

        public void Init()
        {
            var ui = GameObject.FindGameObjectWithTag(CanvasTag);
            Instantiate(_prefabUIInput, ui.transform);
        }

        public void DestroyHandler() => 
            Destroy(gameObject);

        public void HorizontalInputHandler(int input) =>
            OnHorizontalInput?.Invoke(input);

        public void JumpHandler() =>
            OnJumpInput?.Invoke();
    }
}