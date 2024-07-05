using UnityEngine;

namespace UI
{
    public class GameLevelMediator : Mediator
    {
        [SerializeField] private GameObject _gameOverMenu;

        public void ShowGameOverMenu() =>
            _gameOverMenu.SetActive(true);
    }
}