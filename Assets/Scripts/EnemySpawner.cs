using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private Vector3 _enemyPositionForward;
    [SerializeField] private Vector3 _enemyPositionRight;

    private float _spawnDelay = 2f;
    private float _startSpawn = 0;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEmeny), _startSpawn, _spawnDelay);
    }

    private void SpawnEmeny()
    {
        int randomPosition = Random.Range(0, _spawnPoint.Length);
            
        _enemy = Instantiate(_enemy, _spawnPoint[randomPosition].position, Quaternion.identity);
        
        if (randomPosition == 0 )
        {
            _enemy.SetDirectionMove(_enemyPositionRight);   
        }
        else
        {
            _enemy.SetDirectionMove(_enemyPositionForward);
        }
    }
}
