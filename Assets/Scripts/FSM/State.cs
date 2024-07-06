namespace FSM
{
    public abstract class State
    {
        protected readonly FiniteStateMachine _fsm;

        public State(FiniteStateMachine fsm) => 
            _fsm = fsm;

        public virtual void Enter() { }

        public virtual void Exit() { }

        public virtual void Update() { }
    }
}