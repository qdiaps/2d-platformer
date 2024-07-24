using ScriptableObjects.Input;
using Services.InputService;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EntryPoints
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private int _indexBootstrapScene = 0;
        [SerializeField] private int _indexGameMenuScene = 1;
        [SerializeField] private ConfigInput _configInput;
        [SerializeField] private GameObject _prefabInputService;
        [SerializeField] private GameObject _prefabLocalizationService;

        private void Awake()
        {
            Application.targetFrameRate = 60;
            if (SceneManager.GetActiveScene().buildIndex != _indexBootstrapScene)
                return;    
            DontDestroyOnLoad(this);
            InitServices();
            InitGameMenu();
        }

        private void InitServices()
        {
            if (_prefabInputService == null)
                throw new Exception("_prefabInputService == null");
            else if (_prefabLocalizationService == null)
                throw new Exception("_prefabLocalizationService == null");

            InstantiateService(_prefabInputService)
                .GetComponent<InputService>()
                .Init(_configInput);

            InstantiateService(_prefabLocalizationService);

            Debug.Log("Services загрузились.");
        }

        private GameObject InstantiateService(GameObject _prefab)
        {
            var service = Instantiate(_prefab);
            DontDestroyOnLoad(service);
            return service;
        }

        private void InitGameMenu() =>
            SceneManager.LoadScene(_indexGameMenuScene);
    }
}
