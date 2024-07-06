using Core.GameStates;
using UnityEngine;

namespace UI
{
    public class GameLevelMediator : Mediator
    {
        [SerializeField] private GameObject _gameOverMenu;
        [SerializeField] private GameObject _winMenu;

        private GameStateHandler _gameStateHandler;

        private void Start() => 
            _gameStateHandler = FindObjectOfType<GameStateHandler>();

        public override void ChangeScene(int index)
        {
            if (_gameStateHandler.GetTypeState() == typeof(PauseState))
                SetPlay();
            base.ChangeScene(index);
        }

        public void ShowGameOverMenu() =>
            _gameOverMenu.SetActive(true);

        public void ShowWinMenu() =>
            _winMenu.SetActive(true);

        public void SetPause() => 
            _gameStateHandler.SetState<PauseState>();

        public void SetPlay() =>
            _gameStateHandler.SetState<PlayState>();
    }
}