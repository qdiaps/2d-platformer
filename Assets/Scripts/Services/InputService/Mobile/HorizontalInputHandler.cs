using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Services.InputService.Mobile
{
    public class HorizontalInputHandler : InputHandler, IPointerUpHandler, IPointerDownHandler
    {
        [SerializeField] private int _direction;

        private Coroutine _coroutine;

        public void OnPointerDown(PointerEventData eventData)
        {
            Stop();
            _coroutine = StartCoroutine(MousePress());
        }

        public void OnPointerUp(PointerEventData eventData) => 
            Stop();

        private void Stop()
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }

        private IEnumerator MousePress()
        {
            while (true)
            {
                _inputReader.HorizontalInputHandler(_direction);
                yield return null;
            }
        }
    }
}