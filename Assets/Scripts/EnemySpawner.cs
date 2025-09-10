using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private int NumerOfEnemiesToSpawn = 0;


    [SerializeField]
    private float SpawnRangeRadius = 10.0f;

    [SerializeField]
    private GameObject EnemyToSpawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (EnemyToSpawn != null)
        {
            for (int i = 0; i < NumerOfEnemiesToSpawn; i++)
            {
                Vector2 modifier = Random.insideUnitCircle * SpawnRangeRadius;
                Vector3 NewPostition = gameObject.transform.position;
                NewPostition.x += modifier.x;
                NewPostition.z += modifier.y;
                Instantiate(EnemyToSpawn, NewPostition, gameObject.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
