using UnityEngine;

namespace EntryPoints
{
    public class EntryPointGameMenu : EntryPoint
    {
        [SerializeField] private GameObject[] _prefabs;

        protected override void Start()
        {
            base.Start();
            CreatePrefabs();
        }

        private void CreatePrefabs()
        {
            foreach (GameObject prefab in _prefabs)
                Instantiate(prefab);
        }
    }
}