using UnityEngine;

namespace Services.InputService
{
    public abstract class InputReader : MonoBehaviour
    {
        private void FixedUpdate()
        {
            CheckHorizontalInput();
            CheckJumpInput();
        }
        
        public virtual void Init() {}

        protected virtual void CheckHorizontalInput() {}

        protected virtual void CheckJumpInput() {}
    }
}