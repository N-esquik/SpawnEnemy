using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabEnemy;
    [SerializeField] private Transform[] _positionSpawn;

    private float _spawnTime = 2f;
    private bool _isSpawned = true;

    private void Start()
    {
        StartCoroutine(SpawnTime());
    }

    private void SpawnEnemy()
    {
        int randomPosition = Random.Range(0, _positionSpawn.Length);
        Instantiate(_prefabEnemy, _positionSpawn[randomPosition].position, Quaternion.identity);
    }

    private IEnumerator SpawnTime()
    {
        var wait = new WaitForSecondsRealtime(_spawnTime);

        while (_isSpawned)
        {
            SpawnEnemy();

            yield return wait;
        }
    }
}