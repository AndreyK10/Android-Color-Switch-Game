using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject colorSwitch;
    [SerializeField] private GameObject[] obstacles;
    public static bool canSpawn;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private float obstacleSpawnDistance;
    [SerializeField] private float colorSwitchSpawnDistance;

    private void Start()
    {
        SpawnObstacles();
    }

    private void Update()
    {
        if (canSpawn)
        {
            SpawnObstacles();
            canSpawn = false;
        }
    }

    private void SpawnObstacles()
    {
        Vector3 obstaclePosition = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y + obstacleSpawnDistance, playerPosition.transform.position.z);
        Vector3 colorSwitchPosition = new Vector3(obstaclePosition.x, obstaclePosition.y + colorSwitchSpawnDistance, obstaclePosition.z);
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], obstaclePosition, Quaternion.identity);
        Instantiate(colorSwitch, colorSwitchPosition, Quaternion.identity);
        canSpawn = false;
    }
}
