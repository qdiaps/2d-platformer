using FSM;
using ScriptableObjects.GameLevels;

namespace Core.GameStates
{
    public class LevelInitState : State
    {
        private ConfigLevel _config;

        public LevelInitState(FiniteStateMachine fsm, ConfigLevel config) 
            : base(fsm) =>
            _config = config;

        public override void Enter()
        {
            CreatorGameObject.CreateObjects(_config.StaticObjects);
            CreatorGameObject.CreateObject(_config.UI);
            CreatorGameObject.CreateObjects(_config.DynamicObjects);
            CreatorGameObject.CreateObject(_config.Player);
            _fsm.SetState<PlayState>();
        }
    }
}