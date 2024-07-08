using Core.Win;
using UnityEngine;

namespace Core.Player
{
    [RequireComponent(typeof(AudioSource))]
    public class PlayerAudio : MonoBehaviour
    {
        [SerializeField] private AudioClip _jumpAudio;
        [SerializeField] private AudioClip _deadAudio;
        [SerializeField] private AudioClip _pickUpCherryAudio;

        private AudioSource _audio;
        private PlayerStorage _storage;
        private PlayerMovement _movement;
        private WinGame _winGame;

        private void Start()
        {
            _audio = GetComponent<AudioSource>();
            _storage = GetComponent<PlayerStorage>();
            _movement = GetComponent<PlayerMovement>();
            _winGame = FindObjectOfType<WinGame>();

            _movement.OnJump += Jump;
            _movement.OnDead += Dead;
            _storage.OnPickUpCherry += PickUpCherry;
            _winGame.OnWin += StopSound;
        }

        private void OnDestroy()
        {
            _movement.OnJump -= Jump;
            _movement.OnDead -= Dead;
            _storage.OnPickUpCherry -= PickUpCherry;
            _winGame.OnWin -= StopSound;
        }

        private void Jump() =>
            _audio.PlayOneShot(_jumpAudio);

        private void Dead()
        {
            StopSound();
            _audio.PlayOneShot(_deadAudio);
        }

        private void PickUpCherry() =>
            _audio.PlayOneShot(_pickUpCherryAudio);

        private void StopSound() =>
            _audio.Stop();
    }
}