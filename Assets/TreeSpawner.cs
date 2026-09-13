// To-Do
// Raycast downward to make tree spawn on land
// Tree density rules

using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;

    public int treeCount = 50;

    public float areaSize = 50f;

    public float centerClearRadius = 10f;

    void Start()
    {
        SpawnTrees();
    }

    void SpawnTrees()
    {
        for (int i = 0; i < treeCount; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-areaSize, areaSize), 0, Random.Range(-areaSize, areaSize));

            if (Vector3.Distance(randomPosition, Vector3.zero) < centerClearRadius)
            {
                i--;
                continue;
            }

            Instantiate(treePrefab, randomPosition, Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }
}
