using Services.InputService;
using UnityEngine;

namespace UI
{
    public class GameMenuMediator : Mediator
    {
        private InputService _inputService;

        private void Start() => 
            _inputService = FindObjectOfType<InputService>();

        public void ChangeLanguage(string language) =>
            Lean.Localization.LeanLocalization.SetCurrentLanguageAll(language);

        public void SetPCInput() =>
            _inputService.ChangeInput(InputType.PC);

        public void SetMobileInput() =>
            _inputService.ChangeInput(InputType.Mobile);

        public void ExitGame() =>
            Application.Quit();
    }
}