using System;
using UnityEngine;

namespace EntryPoints
{
    public class EntryPointLevel : EntryPoint
    {
        [SerializeField] private GameObject _prefabPlayer;
        [SerializeField] private GameObject[] _prefabsStatic;
        [SerializeField] private GameObject[] _prefabsDynamic;
        [SerializeField] private GameObject _prefabUI;

        protected override void Start()
        {
            base.Start();
            CreateObjects(_prefabsStatic);
            CreateObject(_prefabUI);
            CreateObjects(_prefabsDynamic);
            CreateObject(_prefabPlayer);
        }

        private void CreateObject(GameObject prefab)
        {
            Instantiate(prefab);
        }

        private void CreateObjects(GameObject[] prefabs)
        {
            foreach (GameObject prefab in prefabs)
                Instantiate(prefab);
        }
    }
}