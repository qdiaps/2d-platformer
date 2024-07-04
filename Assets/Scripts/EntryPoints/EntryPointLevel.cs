using UnityEngine;

namespace EntryPoints
{
    public class EntryPointLevel : EntryPoint
    {
        [SerializeField] private GameObject _prefabPlayer;

        protected override void Start()
        {
            base.Start();
            CreatePlayer();
        }

        private void CreatePlayer()
        {
            Instantiate(_prefabPlayer);
        }
    }
}