using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private SpawnPoint[] _spawnPoint;

    private float _spawnDelay = 2f;
    private float _startSpawn = 0;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _startSpawn, _spawnDelay);
    }

    private void Spawn()
    {
        SpawnPoint spawnPoint = _spawnPoint[Random.Range(0, _spawnPoint.Length)];
        spawnPoint.SpawnEnemy(_enemy);
    }
}
