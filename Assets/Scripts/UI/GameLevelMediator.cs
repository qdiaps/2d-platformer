using UnityEngine;

namespace UI
{
    public class GameLevelMediator : Mediator
    {
        [SerializeField] private GameObject _gameOverMenu;
        [SerializeField] private GameObject _winMenu;

        public void ShowGameOverMenu() =>
            _gameOverMenu.SetActive(true);

        public void ShowWinMenu() =>
            _winMenu.SetActive(true);
    }
}