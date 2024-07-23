using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Animator _animator;
    private string _animationRun = "Speed";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void OnAnimatorMove()
    {
        _animator.SetFloat(_animationRun,_speed);
    }

    private void Move()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}
