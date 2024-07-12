namespace Services.InputService.Mobile
{
    public class JumpHandler : InputHandler
    {
        public void Jump() =>
            _inputReader.JumpHandler();
    }
}