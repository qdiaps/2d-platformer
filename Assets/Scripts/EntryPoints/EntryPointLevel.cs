using Core.GameStates;
using ScriptableObjects.GameLevels;
using UnityEngine;

namespace EntryPoints
{
    public class EntryPointLevel : EntryPoint
    {
        [SerializeField] private ConfigLevel _configLevel;
        [SerializeField] private GameObject _prefabGameStateHandler;

        protected override void Start()
        {
            base.Start();
            Instantiate(_prefabGameStateHandler)
                .GetComponent<GameStateHandler>()
                .Init(_configLevel);
        }
    }
}