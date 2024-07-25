using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _directionMove;

    private void Update()
    {
        Move();    
    }

    public void SetDirectionMove(Vector3 direction)
    {
        _directionMove = direction;
    }

    private void Move()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMove);
    }
}
