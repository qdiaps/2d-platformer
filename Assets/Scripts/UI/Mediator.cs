using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class Mediator : MonoBehaviour
    {
        public void ChangeScene(int index)
        {
            if (index == SceneManager.GetActiveScene().buildIndex)
                throw new ArgumentOutOfRangeException("index");
            SceneManager.LoadScene(index);
        }
    }
}