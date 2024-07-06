using System;
using UnityEngine;
using FSM;
using ScriptableObjects.GameLevels;

namespace Core.GameStates
{
    public class GameStateHandler : MonoBehaviour
    {
        private FiniteStateMachine _fsm;

        private void Update() =>
            _fsm.UpdateState();

        public void Init(ConfigLevel config)
        {
            _fsm = new FiniteStateMachine();

            _fsm.AddState(new LevelInitState(_fsm, config));
            _fsm.AddState(new PlayState(_fsm));
            _fsm.AddState(new PauseState(_fsm));

            _fsm.SetState<LevelInitState>();
        }
        
        public void SetState<T>() where T : State =>
            _fsm.SetState<T>();

        public Type GetTypeState() =>
            _fsm.CurrentState.GetType();
    }
}