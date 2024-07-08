using System;
using UI;
using UnityEngine;

namespace Core.Player
{
    public class PlayerStorage : MonoBehaviour
    {
        public event Action OnPickUpCherry;

        private const int MaxCherry = 3;

        private int _cherryCount = 0;
        private GameLevelMediator _mediator;

        private void Start() => 
            _mediator = FindObjectOfType<GameLevelMediator>();

        public void AddCherry()
        {
            if (_cherryCount > MaxCherry)
                return;
            OnPickUpCherry?.Invoke();
            _mediator.AddCherry(_cherryCount);
            _cherryCount++;
        }

        public int GetCherryCount() =>
            _cherryCount;
    }
}