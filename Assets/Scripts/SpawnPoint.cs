using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _positionSpawn;

    public void SpawnEnemy(Enemy enemy)
    {
        enemy = Instantiate(enemy,transform.position,Quaternion.identity);
        enemy.SetDirectionMove(_positionSpawn);
    }
}
