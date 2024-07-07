using Core.Anim;
using System.Collections;
using UnityEngine;

namespace Core.Enemyes
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Transform[] _points;
        [SerializeField] private float _speed;
        [SerializeField] private float _cooldownBetweenMoves;

        private SpriteRenderer _spriteRenderer;

        private enum Direction
        {
            Left,
            Right
        }

        private void Start()
        {
            if (_points.Length < 2)
                Debug.LogWarning("_points.Length < 2");
            _spriteRenderer = GetComponent<SpriteRenderer>();
            StartCoroutine(Move());
        }

        private IEnumerator Move()
        {
            var currentPoint = 0;
            var progress = 0f;
            var currentDirection = Direction.Right;
            while (true)
            {
                if (currentDirection == Direction.Right)
                {
                    currentPoint++;
                    if (currentPoint == _points.Length)
                    {
                        currentDirection = Direction.Left;
                        currentPoint -= 2;
                        _spriteRenderer.flipX = true;
                    }
                }
                else
                {
                    currentPoint--;
                    if (currentPoint < 0)
                    {
                        currentDirection = Direction.Right;
                        currentPoint += 2;
                        _spriteRenderer.flipX = false;
                    }
                }

                var startPosition = transform.position;
                var endPosition = _points[currentPoint].position;
                progress = 0f;

                while (progress < 1)
                {
                    progress += Time.deltaTime * _speed;
                    transform.position = Vector3.Lerp(startPosition, endPosition, progress);
                    yield return null;
                }

                transform.position = endPosition;

                yield return new WaitForSeconds(_cooldownBetweenMoves);
            }
        }
    }
}