using Core.Player;
using UI;
using UnityEngine;

namespace Core.GameOver
{
    public class GameOver : MonoBehaviour
    {
        private GameLevelMediator _mediator;

        private void Start() =>
            _mediator = FindAnyObjectByType<GameLevelMediator>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerMovement player))
            {
                _mediator.SetPause();
                _mediator.ShowGameOverMenu();
            }
        }
    }
}