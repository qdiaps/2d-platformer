using Core.Anim;
using UnityEngine;

namespace Core.Player
{
    public class CheckerBackground : MonoBehaviour
    {
        public bool IsBackground { get; private set; }

        private PlayerAnimation _animation;

        private void Start() =>
            _animation = GetComponentInParent<PlayerAnimation>();

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Background background))
            {
                _animation.EndJump();
                IsBackground = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out Background background))
                IsBackground = false;
        }
    }
}
