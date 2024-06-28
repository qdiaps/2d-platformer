using UnityEngine;
using UnityEngine.SceneManagement;

namespace EntryPoints
{
    public class EntryPoint : MonoBehaviour
    {
        protected virtual void Start()
        {
            Debug.Log($"Scene {SceneManager.GetActiveScene().name} is loaded");
        }
    }
}