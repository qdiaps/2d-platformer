using System;
using Core.Triggers;
using UI;
using UnityEngine;

namespace Core.Player
{
    public class PlayerDead : MonoBehaviour
    {
        public event Action OnDead;

        private GameLevelMediator _mediator;

        private void Start() => 
            _mediator = FindObjectOfType<GameLevelMediator>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out DeadZone deadZone))
            {
                OnDead?.Invoke();
                _mediator.SetPause();
                _mediator.ShowGameOverMenu();
            }
        }
    }
}