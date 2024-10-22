using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public abstract class Mediator : MonoBehaviour
    {
        public virtual void ChangeScene(int index)
        {
            if (index == SceneManager.GetActiveScene().buildIndex)
                throw new ArgumentOutOfRangeException("index");
            SceneManager.LoadScene(index);
        }
    }
}