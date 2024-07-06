using System;
using System.Collections.Generic;

namespace FSM
{
    public class FiniteStateMachine
    {
        public State CurrentState { get; private set; }

        private Dictionary<Type, State> _states = new Dictionary<Type, State>();

        public void AddState(State state)
        {
            if (_states.ContainsKey(state.GetType()))
                return;
            _states.Add(state.GetType(), state);
        }

        public void SetState<T>() where T : State
        {
            var type = typeof(T);
            if (CurrentState?.GetType() == type)
                return;
            if (_states.TryGetValue(type, out var state))
            {
                CurrentState?.Exit();
                CurrentState = state;
                CurrentState.Enter();
            }
        }

        public void UpdateState() =>
            CurrentState?.Update();
    }
}