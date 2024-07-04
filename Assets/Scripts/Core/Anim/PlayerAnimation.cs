using UnityEngine;

namespace Core.Anim
{
    public class PlayerAnimation : MonoBehaviour
    {
        private readonly int _move = Animator.StringToHash("Move");
        private readonly int _isJumping = Animator.StringToHash("IsJumping");

        private Animator _animator;

        private void Start() =>
            _animator = GetComponent<Animator>();

        public void Move() =>
            _animator.SetTrigger(_move);

        public void Jump() =>
            _animator.SetBool(_isJumping, true);

        public void EndJump() =>
            _animator.SetBool(_isJumping, false);
    }
}