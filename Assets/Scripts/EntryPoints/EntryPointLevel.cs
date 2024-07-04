using UnityEngine;

namespace EntryPoints
{
    public class EntryPointLevel : EntryPoint
    {
        [SerializeField] private GameObject _prefabPlayer;
        [SerializeField] private GameObject[] _prefabsStatic;

        protected override void Start()
        {
            base.Start();
            CreatePlayer();
            CreateStaticObjects();
        }

        private void CreatePlayer()
        {
            Instantiate(_prefabPlayer);
        }

        private void CreateStaticObjects()
        {
            foreach (GameObject prefab in _prefabsStatic)
                Instantiate(prefab);
        }
    }
}