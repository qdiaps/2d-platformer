namespace UI
{
    public class GameMenuMediator : Mediator
    {
        public void ChangeLanguage(string language) =>
            Lean.Localization.LeanLocalization.SetCurrentLanguageAll(language);
    }
}