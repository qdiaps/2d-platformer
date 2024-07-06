using FSM;
using UnityEngine;

namespace Core.GameStates
{
    public class PauseState : State
    {
        public PauseState(FiniteStateMachine fsm) : base(fsm) { }

        public override void Enter() => 
            Time.timeScale = 0;

        public override void Exit() =>
            Time.timeScale = 1;
    }
}