using UnityEngine;

public class TreeFalling : MonoBehaviour
{
    public GameObject brokenTreePrefab;

    [SerializeField] private float explosionForce = 300f;
    [SerializeField] private float explosionRadius = 3f;
    [SerializeField] private float upwardModifier = 1f;

    public void SpawnLogs()
    {
        GameObject spawnedLogs = Instantiate(brokenTreePrefab, transform.position, transform.rotation);

        Rigidbody[] logRigidbodies = spawnedLogs.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in logRigidbodies)
        {
            Vector3 explosionSource = transform.position + new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f));

            rb.AddExplosionForce(explosionForce, explosionSource, explosionRadius, upwardModifier);
        }

        Destroy(gameObject);
    }
}
