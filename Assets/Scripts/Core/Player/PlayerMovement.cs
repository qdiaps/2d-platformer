using System;
using Core.Anim;
using UnityEngine;
using Services.InputService;
using Input = Services.InputService.Input;

namespace Core.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speedMove;
        [SerializeField] private float _jumpForce;
        [SerializeField] private CheckerBackground _checkerBackground;
        
        private IInputCallback _inputService;
        private Rigidbody2D _rigidbody;
        private SpriteRenderer _spriteRenderer;
        private PlayerAnimation _animation;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _animation = GetComponent<PlayerAnimation>();
            InitInput();
        }

        private void OnDestroy()
        {
            _inputService.OnHorizontalInput -= Move;
            _inputService.OnJumpInput -= Jump;
        }

        private void InitInput()
        {
            var input = FindObjectOfType<Input>() ?? throw new Exception("Input Service небыл найден на сцене.");
            _inputService = input.GetInput();
            _inputService.OnHorizontalInput += Move;
            _inputService.OnJumpInput += Jump;
        }

        private void Move(float input)
        {
            _animation.Move();
            transform.Translate(new Vector3(input * _speedMove, 0f));
            if (input < 0f)
                _spriteRenderer.flipX = true;
            else
                _spriteRenderer.flipX = false;
        }

        private void Jump()
        {
            if (_checkerBackground.IsBackground)
            {
                _animation.Jump();
                _rigidbody.AddForce(Vector2.up * _jumpForce * 100);
            }
        }
    }
}
