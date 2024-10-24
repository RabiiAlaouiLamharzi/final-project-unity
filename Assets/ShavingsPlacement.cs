using UnityEngine;

public class ShavingsPlacement : MonoBehaviour
{
    public GameObject shavingPrefab;
    public GameObject table;
    public int numberOfShavings = 15;

    void Start()
    {
        PlaceShavings();
    }

    void PlaceShavings()
    {
        Bounds tableBounds = table.GetComponent<Collider>().bounds;

        float minX = tableBounds.center.x;
        float maxX = tableBounds.max.x;
        float minZ = tableBounds.center.z;
        float maxZ = tableBounds.max.z;

        for (int i = 0; i < numberOfShavings; i++)
        {
            GameObject shaving = Instantiate(shavingPrefab);

            float randomX = Random.Range(minX, maxX);
            float randomZ = Random.Range(minZ, maxZ);

            shaving.transform.position = new Vector3(randomX, tableBounds.max.y + 0.5f, randomZ);

            Rigidbody rb = shaving.AddComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }
}
