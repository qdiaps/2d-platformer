using Core.Player;
using UI;
using UnityEngine;

namespace Core.Win
{
    public class WinGame : MonoBehaviour
    {
        private const int MaxCherry = 3;

        private GameLevelMediator _mediator;

        private void Start() =>
            _mediator = FindAnyObjectByType<GameLevelMediator>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerStorage player))
            {
                if (player.GetCherryCount() < MaxCherry)
                    return;
                _mediator.SetPause();
                _mediator.ShowWinMenu();
            }
        }
    }
}