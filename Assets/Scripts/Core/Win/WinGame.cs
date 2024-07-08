using Core.Player;
using System;
using UI;
using UnityEngine;

namespace Core.Win
{
    [RequireComponent(typeof(AudioSource))]
    public class WinGame : MonoBehaviour
    {
        public event Action OnWin;

        private const int MaxCherry = 3;

        private GameLevelMediator _mediator;
        private AudioSource _audio;

        private void Start()
        {
            _audio = GetComponent<AudioSource>();
            _mediator = FindAnyObjectByType<GameLevelMediator>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerStorage player))
            {
                if (player.GetCherryCount() < MaxCherry)
                    return;
                OnWin?.Invoke();
                _audio.Play();
                _mediator.SetPause();
                _mediator.ShowWinMenu();
            }
        }
    }
}