using System;

namespace Services.InputService
{
    public interface IInputCallback
    {
        event Action<int> OnHorizontalInput;
        event Action OnJumpInput;

        void Init();
    }
}