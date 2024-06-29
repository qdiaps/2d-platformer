using System;

namespace Services.InputService
{
    public interface IInputCallback
    {
        event Action<float> OnHorizontalInput;
        event Action OnJumpInput;
    }
}