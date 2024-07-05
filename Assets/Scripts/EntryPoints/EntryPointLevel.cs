using System;
using UnityEngine;

namespace EntryPoints
{
    public class EntryPointLevel : EntryPoint
    {
        [SerializeField] private GameObject _prefabPlayer;
        [SerializeField] private GameObject[] _prefabsStatic;
        [SerializeField] private GameObject _prefabUI;

        protected override void Start()
        {
            base.Start();
            CreateStaticObjects();
            CreateUI();
            CreatePlayer();
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
        
        private void CreateUI()
        {
            Instantiate(_prefabUI);
        }
    }
}