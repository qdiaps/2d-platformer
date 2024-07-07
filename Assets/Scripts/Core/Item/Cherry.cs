using Core.Player;
using UnityEngine;

namespace Core.Item
{
    public class Cherry : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerStorage player))
            {
                player.AddCherry();
                Destroy(gameObject);
            }
        }
    }
}