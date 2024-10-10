using System.Collections;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private float SpawnRate = 3.5f;
    public float Count;
    private GameObject enemyinst;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine(spawnEnemy(SpawnRate,enemy));
        InvokeRepeating("enemyspawn", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float timer, GameObject enemy)
    {
       
            yield return new WaitForSeconds(timer);
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), Random.Range(5f, 10f), 0f), Quaternion.identity);
            GameObject newEnemy1 = Instantiate(enemy, new Vector3(Random.Range(-10f, -20f), Random.Range(0f, 5f), 0f), Quaternion.identity);
            GameObject newEnemy2 = Instantiate(enemy, new Vector3(Random.Range(10f, 20f), Random.Range(0f, 5f), 0f), Quaternion.identity);
            Count += 1;
            StartCoroutine(spawnEnemy(timer, newEnemy));
        
       
    }

    void enemyspawn()
    {
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(-10f,-20f), Random.Range(0f,5f)), Quaternion.identity);
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(10f, 20f), Random.Range(0f, 5f)), Quaternion.identity);
        enemyinst = Instantiate(enemy, new Vector2(Random.Range(-10f, 10f), Random.Range(5f, 10f)), Quaternion.identity);
    }


}
