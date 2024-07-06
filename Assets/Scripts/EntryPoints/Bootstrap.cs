using UnityEngine;
using UnityEngine.SceneManagement;

namespace EntryPoints
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private int _indexBootstrapScene = 0;
        [SerializeField] private int _indexGameMenuScene = 1;
        [SerializeField] private GameObject[] _prefabsService;

        private void Awake()
        {
            Application.targetFrameRate = 60;
            if (SceneManager.GetActiveScene().buildIndex != _indexBootstrapScene)
                return;
            DontDestroyOnLoad(this);
            
            // init LoadingScreen
            
            InitServices();
            InitGameMenu();

            // hide LoadingScreen
        }

        private void InitServices()
        {
            if (_prefabsService.Length == 0)
                return;
            foreach (GameObject service in _prefabsService)
                DontDestroyOnLoad(Instantiate(service));
            Debug.Log("Services загрузились.");
        }

        private void InitGameMenu() =>
            SceneManager.LoadScene(_indexGameMenuScene);
    }
}
