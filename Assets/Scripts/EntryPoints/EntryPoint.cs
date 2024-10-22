﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace EntryPoints
{
    public class EntryPoint : MonoBehaviour
    {
        protected virtual void Start()
        {
            if (FindObjectOfType<Bootstrap>() == null)
                Debug.LogWarning("Загрузка не из BootstrapScene");
            Debug.Log($"Scene {SceneManager.GetActiveScene().name} is loaded");
        }
    }
}